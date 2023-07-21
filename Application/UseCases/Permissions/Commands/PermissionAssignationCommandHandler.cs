using Application.Persistance;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;

namespace Application.UseCases.Permissions.Commands {
    public class PermissionAssignationCommandHandler : IRequestHandler<PermissionAssignationCommand> {

        private readonly IRoleRepository _roleRepository;
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public PermissionAssignationCommandHandler(IMapper mapper, IPermissionRepository permissionRepository, IRoleRepository roleRepository) {
            _mapper = mapper;
            _permissionRepository = permissionRepository;
            _roleRepository = roleRepository;
        }

        public async Task Handle(PermissionAssignationCommand request, CancellationToken cancellationToken) {
            var permissions = await _permissionRepository.GetAllAsync();
            var permissionIds = permissions.Select(x => x.Id).AsEnumerable();

            var flag = CheckList(permissionIds, request.AssignIds);
            if (flag is not null)
                throw new NoSuchEntityExistsException($"Permission with ID: \"{flag}\" does not exist");

            flag = CheckList(permissionIds, request.UnassignIds);
            if (flag is not null)
                throw new NoSuchEntityExistsException($"Permission with ID: \"{flag}\" does not exist");

            if (request.AssignIds.Any() is true
                && request.UnassignIds.Any() is true) {
                var assignRoles = GetPermissions(request.AssignIds, permissions);
                var unassignRoles = GetPermissions(request.UnassignIds, permissions);

                await _roleRepository.UpdatePermissions(request.UserId, assignRoles, unassignRoles);
            }
            else if (request.AssignIds.Any() is true
                && request.UnassignIds.Any() is false) {
                var assignRoles = GetPermissions(request.AssignIds, permissions);

                await _roleRepository.AddPermissions(request.UserId, assignRoles);
            }
            else if (request.AssignIds.Any() is false
                && request.UnassignIds.Any() is true) {
                var unassignRoles = GetPermissions(request.UnassignIds, permissions);

                await _roleRepository.RemovePermissions(request.UserId, unassignRoles);
            }
            else {
                return;
            }
        }

        private Guid? CheckList(IEnumerable<Guid> permissionIds, IEnumerable<Guid> checkIds) {
            foreach (var roleId in checkIds)
                if (permissionIds.Contains(roleId) is false)
                    return roleId;
            return null;
        }

        private List<Permission> GetPermissions(IEnumerable<Guid> ids, IEnumerable<Permission> permissions) {
            var list = new List<Permission>();
            foreach (var permission in permissions)
                if (ids.Contains(permission.Id))
                    list.Add(permission);
            return list;
        }
    }
}
