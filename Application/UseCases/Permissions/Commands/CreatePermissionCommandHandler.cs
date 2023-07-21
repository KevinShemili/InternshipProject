using Application.Persistance;
using Application.UseCases.ViewPermissions.Results;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;

namespace Application.UseCases.Permissions.Commands {

    public class CreatePermissionCommand : IRequest<PermissionsResult> {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }

    public class CreatePermissionCommandHandler : IRequestHandler<CreatePermissionCommand, PermissionsResult> {

        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public CreatePermissionCommandHandler(IPermissionRepository permissionRepository, IMapper mapper) {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }

        public async Task<PermissionsResult> Handle(CreatePermissionCommand request, CancellationToken cancellationToken) {
            var permission = _mapper.Map<Permission>(request);
            permission.Id = Guid.NewGuid();

            await _permissionRepository.CreateAsync(permission);

            return _mapper.Map<PermissionsResult>(permission);
        }
    }

    public class CreatePermissionCommandValidator : AbstractValidator<CreatePermissionCommand> {
        public CreatePermissionCommandValidator() {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name cannot be empty");

            RuleFor(x => x.Description)
                .MaximumLength(250).WithMessage("Description cannot exceed 250 characters.");
        }
    }
}
