using FluentValidation;

namespace Application.UseCases.ActivateAccount.Commands {
    public class ActivateCommandValidator : AbstractValidator<ActivateAccountCommand> {
        public ActivateCommandValidator() {
            RuleFor(x => x.Token)
                .NotEmpty().WithMessage("Token cannot be empty");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email format johndoe@mail.com");
        }
    }
}
