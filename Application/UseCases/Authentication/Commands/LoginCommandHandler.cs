using Application.Exceptions.ClientErrors;
using Application.Exceptions.ServerErrors;
using Application.Interfaces.Authentication;
using Application.Persistance;
using Application.Persistance.Common;
using Application.UseCases.Authentication.Results;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.Authentication.Commands {

    public class LoginCommand : IRequest<LoginResult> {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }

    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResult> {

        private readonly IUserRepository _userRepository;
        private readonly IJwtToken _jwtToken;
        private readonly IHasherService _hasherService;
        private readonly ITokenService _tokenService;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public LoginCommandHandler(IUserRepository userRepository,
                                   IJwtToken jwtToken,
                                   IHasherService hasherService,
                                   ITokenService tokenService,
                                   IStringLocalizer<LocalizationResources> localizer,
                                   IUnitOfWork unitOfWork) {
            _userRepository = userRepository;
            _jwtToken = jwtToken;
            _hasherService = hasherService;
            _tokenService = tokenService;
            _localizer = localizer;
            _unitOfWork = unitOfWork;
        }

        public async Task<LoginResult> Handle(LoginCommand request, CancellationToken cancellationToken) {

            if (await _userRepository.ContainsUsernameAsync(request.Username) is false)
                throw new NotFoundException(_localizer.GetString("InvalidUsername").Value);

            var user = await _userRepository.GetByUsernameAsync(request.Username);

            if (user.IsEmailConfirmed is false)
                throw new ForbiddenException(_localizer.GetString("UnverifiedEmail").Value);

            if (user.IsBlocked is true)
                throw new BlockedException(_localizer.GetString("BlockedAccount").Value);

            var flag = _hasherService.VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt);

            if (flag is false) {
                if (await _userRepository.IncrementTriesAsync(user.Id) is false) {
                    await _userRepository.BlockAccountAsync(user.Id);
                    throw new BlockedException(_localizer.GetString("BlockedAccount").Value);
                }
                throw new UnauthorizedException(_localizer.GetString("IncorrectPassword").Value);
            }

            var roles = await _userRepository.GetRolesAsync(user.Id);
            var roleNames = roles.Select(x => x.Name).AsEnumerable();

            // put roles in token
            var token = _jwtToken.GenerateToken(user.Id, user.Username, roleNames);

            // generate refresh token for the user
            var refreshToken = await _tokenService.GenerateRefreshTokenAsync();

            // logic successful by this point 
            await _userRepository.ResetTriesAsync(user.Id);
            await _userRepository.SetRefreshTokenAsync(user.Id, refreshToken, DateTime.Now.AddDays(7));

            var dbFlag = await _unitOfWork.SaveChangesAsync();
            if (dbFlag is false)
                throw new DatabaseException(_localizer.GetString("DatabaseException").Value);

            return new LoginResult {
                Id = user.Id,
                Token = token,
                RefreshToken = refreshToken
            }; ;
        }
    }

    public class LoginCommandValidator : AbstractValidator<LoginCommand> {
        public LoginCommandValidator() {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("EmptyUsername");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("EmptyPassword");
        }
    }
}
