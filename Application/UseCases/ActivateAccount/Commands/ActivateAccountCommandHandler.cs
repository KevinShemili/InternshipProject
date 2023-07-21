using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.ActivateAccount.Commands {

    public class ActivateAccountCommand : IRequest {
        public string Token { get; set; } = null!;
        public string Email { get; set; } = null!;
    }

    public class ActivateAccountCommandHandler : IRequestHandler<ActivateAccountCommand> {

        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;
        private readonly IUserRepository _userRepository;

        public ActivateAccountCommandHandler(IUserVerificationAndResetRepository userVerificationAndResetRepository, IUserRepository userRepository) {
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _userRepository = userRepository;
        }

        public async Task Handle(ActivateAccountCommand request, CancellationToken cancellationToken) {

            var entity = await _userVerificationAndResetRepository.GetByEmailAsync(request.Email);
            var VerificationToken = entity.EmailVerificationToken;
            var VerificationTokenExpiry = entity.EmailVerificationTokenExpiry;

            if (VerificationToken is null)
                throw new ForbiddenException("Invalid token");

            if (VerificationTokenExpiry is null)
                throw new ForbiddenException("Invalid token");

            if (VerificationToken == request.Token
                && VerificationTokenExpiry > DateTime.Now)
                await _userRepository.ActivateAccountAsync(request.Email);
            else if (VerificationToken == request.Token
                && VerificationTokenExpiry < DateTime.Now)
                throw new TokenExpiredException("Token has expired");
            else
                throw new ForbiddenException("Invalid token");
        }
    }

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
