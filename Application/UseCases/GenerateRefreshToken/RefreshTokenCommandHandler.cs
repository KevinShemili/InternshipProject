using Application.Interfaces.Authentication;
using Application.Persistance;
using Application.UseCases.GenerateRefreshToken.Results;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Application.UseCases.GenerateRefreshToken {

    public class RefreshTokenCommand : IRequest<RefreshTokenResult> {
        public string AccessToken { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
    }

    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, RefreshTokenResult> {

        private readonly ITokenService _tokenService;
        private readonly IUserRepository _userRepository;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;
        private readonly IJwtToken _jwtToken;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public RefreshTokenCommandHandler(ITokenService tokenService, IUserRepository userRepository, IUserVerificationAndResetRepository userVerificationAndResetRepository, IJwtToken jwtToken, IStringLocalizer<LocalizationResources> localizer) {
            _tokenService = tokenService;
            _userRepository = userRepository;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _jwtToken = jwtToken;
            _localizer = localizer;
        }

        public async Task<RefreshTokenResult> Handle(RefreshTokenCommand request, CancellationToken cancellationToken) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jsonToken = tokenHandler.ReadToken(request.AccessToken);
            var tokenS = jsonToken as JwtSecurityToken;

            var userId = Guid.Parse(tokenS.Claims.First(x => x.Type == "sub").Value);

            if (await _userRepository.ContainsIdAsync(userId) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("InvalidToken").Value);

            var user = await _userRepository.GetByIdAsync(userId);

            var entity = await _userVerificationAndResetRepository.GetByEmailAsync(user.Email);

            var oldRefreshToken = entity.RefreshToken;
            var refreshTokenExpiry = entity.RefreshTokenExpiry;

            if (oldRefreshToken is null || refreshTokenExpiry is null)
                throw new ForbiddenException(_localizer.GetString("InvalidToken").Value);
            else if (request.RefreshToken != oldRefreshToken)
                throw new ForbiddenException(_localizer.GetString("InvalidToken").Value);
            else if (refreshTokenExpiry <= DateTime.Now)
                throw new TokenExpiredException(_localizer.GetString("TokenExpired").Value);

            var refreshToken = await _tokenService.GenerateRefreshTokenAsync();
            await _userRepository.SetRefreshTokenAsync(user.Id, refreshToken, DateTime.Now.AddDays(7));

            var roles = tokenS.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value).ToList();

            var accessToken = _jwtToken.GenerateToken(userId, user.Username, roles.AsEnumerable());

            return new RefreshTokenResult {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };

        }
    }

    public class RefreshTokenCommandValidator : AbstractValidator<RefreshTokenCommand> {
        public RefreshTokenCommandValidator() {
            RuleFor(x => x.AccessToken)
                .NotEmpty().WithMessage("EmptyAccessToken");
            RuleFor(x => x.RefreshToken)
                .NotEmpty().WithMessage("EmptyRefreshToken");
        }
    }
}
