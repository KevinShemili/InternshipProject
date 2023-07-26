using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.UnblockAccount.Command {

    public class UnblockAccountCommand : IRequest {
        public Guid Id { get; set; }
    }

    public class UnblockAccountCommandHandler : IRequestHandler<UnblockAccountCommand> {

        private readonly IUserRepository _userRepository;

        public UnblockAccountCommandHandler(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public async Task Handle(UnblockAccountCommand request, CancellationToken cancellationToken) {
            if (await _userRepository.ContainsIdAsync(request.Id) is false)
                throw new NoSuchEntityExistsException("Username doesn't exist");

            await _userRepository.ResetTriesAsync(request.Id);
            await _userRepository.UnblockAccountAsync(request.Id);
        }
    }

    public class UnblockAccountCommandValidator : AbstractValidator<UnblockAccountCommand> {
        public UnblockAccountCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Account ID cannot be empty");
        }
    }
}
