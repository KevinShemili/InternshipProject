using FluentValidation;

namespace Application.UseCases.ForgotPassword.Queries {
    public class ForgotPasswordQueryValidator : AbstractValidator<ForgotPasswordQuery> {
        public ForgotPasswordQueryValidator() {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email cannot be empty")
                .EmailAddress();
        }
    }
}
