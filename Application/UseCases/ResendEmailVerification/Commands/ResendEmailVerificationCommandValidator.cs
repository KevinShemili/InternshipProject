﻿using FluentValidation;

namespace Application.UseCases.ResendEmailVerification.Commands {
    public class ResendEmailVerificationCommandValidator : AbstractValidator<ResendEmailVerificationCommand> {
        public ResendEmailVerificationCommandValidator() {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email cannot be empty")
                .EmailAddress();
        }
    }
}