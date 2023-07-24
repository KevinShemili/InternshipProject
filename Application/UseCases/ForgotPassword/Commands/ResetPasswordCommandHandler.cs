using Application.Interfaces.Authentication;
using Application.Interfaces.Email;
using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.ForgotPassword.Commands
{

    public class ResetPasswordCommand : IRequest {
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
    }

    public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand> {

        private readonly IUserRepository _userRepository;
        private readonly IMailService _mailService;
        private readonly IMailBodyService _mailBodyService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;
        private readonly IHasherService _hasherService;

        public ResetPasswordCommandHandler(IUserRepository userRepository, IMailService mailService, IMailBodyService mailBodyService, IUserVerificationAndResetRepository userVerificationAndResetRepository, IHasherService hasherService) {
            _userRepository = userRepository;
            _mailService = mailService;
            _mailBodyService = mailBodyService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _hasherService = hasherService;
        }

        public async Task Handle(ResetPasswordCommand request, CancellationToken cancellationToken) {

            var entity = await _userVerificationAndResetRepository.GetByEmailAsync(request.Email);

            var passwordToken = entity.PasswordResetToken;
            var passwordTokenExpiry = entity.PasswordResetTokenExpiry;

            if (passwordToken is null)
                throw new ForbiddenException("Invalid token");

            if (passwordTokenExpiry is null)
                throw new ForbiddenException("Invalid token");

            if (passwordToken == request.Token
                && passwordTokenExpiry > DateTime.Now) {
                var tuple = _hasherService.HashPassword(request.Password);
                var passwordHash = tuple.Item1;
                var passwordSalt = tuple.Item2;

                await _userRepository.ChangePasswordAsync(request.Email, passwordHash, passwordSalt);

                var body = await _mailBodyService.GetSuccessfulPasswordChangeMailBodyAsync();
                var subject = "Password Reset";
                var mailData = new MailData(request.Email, subject, body);
                await _mailService.SendAsync(mailData, cancellationToken);
            }
            else if (passwordToken == request.Token
                && passwordTokenExpiry < DateTime.Now)
                throw new TokenExpiredException("Token has expired");
            else
                throw new ForbiddenException("Invalid token");


        }
    }

    public class ResetPasswordCommandValidator : AbstractValidator<ResetPasswordCommand> {
        public ResetPasswordCommandValidator() {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email format johndoe@mail.com");

            RuleFor(x => x.Token)
                .NotEmpty().WithMessage("Invalid token");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Your password cannot be empty")
                .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                .MaximumLength(14).WithMessage("Your password length must not exceed 16.")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("Passwords do not match");
        }
    }
}
