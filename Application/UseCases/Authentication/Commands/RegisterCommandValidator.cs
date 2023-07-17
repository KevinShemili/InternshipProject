using FluentValidation;
using System.Text.RegularExpressions;

namespace Application.UseCases.Authentication.Commands {
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand> {
        public RegisterCommandValidator() {
            RuleFor(x => x.Username)
                .NotEmpty()
                .WithMessage("Username cannot be empty");
            
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("FirstName cannot be empty");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("LastName cannot be empty");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email cannot be empty")
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Your password cannot be empty")
                .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                .MaximumLength(16).WithMessage("Your password length must not exceed 16.")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");

            RuleFor(x => x.Prefix)
                .NotEmpty()
                .WithMessage("Prefix cannot be empty")
                .Matches(@"^\+\d{3,4}$")
                .WithMessage("Prefix format +XXX");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("Phone Number cannot be empty")
                .MinimumLength(8)
                .WithMessage("More 8 characters required")
                .MaximumLength(20)
                .WithMessage("PhoneNumber must not exceed 50 characters.");
        }
    }
}
