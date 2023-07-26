using Application.Exceptions;
using Application.Interfaces.Authentication;
using Application.Persistance;
using Application.UseCases.Authentication.Results;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

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
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;

        public LoginCommandHandler(IUserRepository userRepository, IJwtToken jwtToken, IHasherService hasherService, ITokenService tokenService, IUserVerificationAndResetRepository userVerificationAndResetRepository) {
            _userRepository = userRepository;
            _jwtToken = jwtToken;
            _hasherService = hasherService;
            _tokenService = tokenService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
        }

        public async Task<LoginResult> Handle(LoginCommand request, CancellationToken cancellationToken) {

            var flag = await _userRepository.ContainsUsernameAsync(request.Username);
            if (flag is false)
                throw new NoSuchEntityExistsException("Username doesn't exist");

            var user = await _userRepository.GetByUsernameAsync(request.Username);

            if (user.IsEmailConfirmed is false)
                throw new ForbiddenException("Unverified email");

            if (user.IsBlocked is true)
                throw new BlockedAccountException("Account is blocked due to multiple incorrect tries");

            flag = _hasherService.VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt);

            if (flag is false) {
                if (await _userRepository.IncrementTriesAsync(user.Id) is false) {
                    await _userRepository.BlockAccountAsync(user.Id);
                    throw new BlockedAccountException("Account is blocked due to multiple incorrect tries");
                }
                throw new InvalidPasswordException("Incorrect Password");
            }

            var roles = await _userRepository.GetRolesAsync(user.Id);

            var roleNames = roles.Select(x => x.Name).AsEnumerable();

            var token = _jwtToken.GenerateToken(user.Id, user.Username, roleNames);
            var refreshToken = await _tokenService.GenerateRefreshTokenAsync();

            await _userRepository.ResetTriesAsync(user.Id);
            await _userRepository.SetRefreshTokenAsync(user.Id, refreshToken, DateTime.Now.AddDays(7));

            var loginResult = new LoginResult {
                Id = user.Id,
                Token = token,
                RefreshToken = refreshToken
            };

            return loginResult;
        }
    }

    public class LoginCommandValidator : AbstractValidator<LoginCommand> {
        public LoginCommandValidator() {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username cannot be empty");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password cannot be empty");
        }
    }
}
