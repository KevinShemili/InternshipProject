using Application.Persistance;
using Application.UseCases.ViewPermissions.Results;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Permissions.Commands {
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
}
