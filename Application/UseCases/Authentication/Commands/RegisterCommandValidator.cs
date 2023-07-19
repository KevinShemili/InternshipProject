using FluentValidation;

namespace Application.UseCases.Authentication.Commands {
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand> {
        public RegisterCommandValidator() {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username cannot be empty")
                .MinimumLength(8).WithMessage("Your username length must be at least 8 characters.")
                .Matches(@"[0-9]+").WithMessage("Your username must contain at least one number.");

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name cannot be empty")
                .MaximumLength(25).WithMessage("Your first name length must not exceed 25 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name cannot be empty")
                .MaximumLength(25).WithMessage("Your last name length must not exceed 25 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email format johndoe@mail.com");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Your password cannot be empty")
                .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                .MaximumLength(14).WithMessage("Your password length must not exceed 16.")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");

            RuleFor(x => x.Prefix)
                .NotEmpty()
                .WithMessage("Prefix cannot be empty")
                .Matches(@"^\+\d{2,3}$")
                .WithMessage("Prefix format +XX/+XXX");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone Number cannot be empty")
                .MinimumLength(8).WithMessage("More 8 characters required")
                .MaximumLength(20).WithMessage("PhoneNumber must not exceed 20 characters.");
        }
    }
}
