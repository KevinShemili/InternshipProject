using Application.Interfaces.Authentication;
using Application.Persistance;
using Application.Services;
using Application.UseCases.Authentication.Results;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.Authentication.Queries {

    public class LoginQuery : IRequest<LoginResult> {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }

    public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginResult> {

        private readonly IUserRepository _userRepository;
        private readonly IJwtToken _jwtToken;
        private readonly IHasherService _hasherService;
        private readonly ITokenService _tokenService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;

        public LoginQueryHandler(IUserRepository userRepository, IJwtToken jwtToken, IHasherService hasherService, ITokenService tokenService, IUserVerificationAndResetRepository userVerificationAndResetRepository) {
            _userRepository = userRepository;
            _jwtToken = jwtToken;
            _hasherService = hasherService;
            _tokenService = tokenService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
        }

        public async Task<LoginResult> Handle(LoginQuery request, CancellationToken cancellationToken) {
            var user = await _userRepository.GetByUsernameAsync(request.Username);

            if (user == null)
                throw new NoSuchEntityExistsException("Username doesn't exist");

            if (user.IsEmailConfirmed is false)
                throw new ForbiddenException("Unverified email");

            var flag = _hasherService.VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt);

            if (flag is false)
                throw new InvalidPasswordException("Incorrect Password");

            var roles = await _userRepository.GetRolesAsync(user.Id);

            var roleNames = roles.Select(x => x.Name).AsEnumerable();

            var token = _jwtToken.GenerateToken(user.Id, user.Username, roleNames);
            var refreshToken = await _tokenService.GenerateRefreshTokenAsync();

            await _userRepository.SetRefreshToken(user.Id, refreshToken, DateTime.Now.AddDays(7));

            var loginResult = new LoginResult {
                Id = user.Id,
                Token = token,
                RefreshToken = refreshToken
            };

            return loginResult;
        }
    }

    public class LoginQueryValidator : AbstractValidator<LoginQuery> {
        public LoginQueryValidator() {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username cannot be empty");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password cannot be empty");
        }
    }
}
