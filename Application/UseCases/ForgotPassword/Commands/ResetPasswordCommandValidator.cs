using FluentValidation;

namespace Application.UseCases.ForgotPassword.Commands {
    public class ResetPasswordCommandValidator : AbstractValidator<ResetPasswordCommand> {
        public ResetPasswordCommandValidator() {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email cannot be empty")
                .EmailAddress();

            RuleFor(x => x.Token)
                .NotEmpty()
                .WithMessage("Invalid token");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Your password cannot be empty")
                .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                .MaximumLength(16).WithMessage("Your password length must not exceed 16.")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("Passwords do not match");
        }
    }
}
