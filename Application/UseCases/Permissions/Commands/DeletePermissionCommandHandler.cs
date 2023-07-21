using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.Permissions.Commands {

    public class DeletePermissionCommand : IRequest {
        public Guid Id { get; set; }
    }

    public class DeletePermissionCommandHandler : IRequestHandler<DeletePermissionCommand> {

        private readonly IPermissionRepository _permissionRepository;

        public DeletePermissionCommandHandler(IPermissionRepository permissionRepository) {
            _permissionRepository = permissionRepository;
        }

        public async Task Handle(DeletePermissionCommand request, CancellationToken cancellationToken) {
            if (await _permissionRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException("Permission does not exist.");

            await _permissionRepository.DeleteAsync(request.Id);
        }
    }

    public class DeletePermissionCommandValidator : AbstractValidator<DeletePermissionCommand> {
        public DeletePermissionCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Permission ID cannot be empty");
        }
    }

}
