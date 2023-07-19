using FluentValidation;

namespace Application.UseCases.ForgotUsername.Queries {
    public class ForgotUsernameQueryValidator : AbstractValidator<ForgotUsernameQuery> {
        public ForgotUsernameQueryValidator() {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email format johndoe@mail.com");
        }
    }
}
