using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.Roles.Commands {

    public class DeleteRoleCommand : IRequest {
        public Guid Id { get; set; }
    }

    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand> {

        private readonly IRoleRepository _roleRepository;

        public DeleteRoleCommandHandler(IRoleRepository roleRepository) {
            _roleRepository = roleRepository;
        }

        public async Task Handle(DeleteRoleCommand request, CancellationToken cancellationToken) {
            if (await _roleRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException("Role does not exist.");

            await _roleRepository.DeleteAsync(request.Id);
        }
    }

    public class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand> {
        public DeleteRoleCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Role ID cannot be empty");
        }
    }
}
