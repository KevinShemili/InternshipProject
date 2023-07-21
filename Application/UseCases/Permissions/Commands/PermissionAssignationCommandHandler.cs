﻿using Application.Persistance;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.Permissions.Commands {

    public class PermissionAssignationCommand : IRequest {
        public Guid RoleId { get; set; }
        public List<Guid> Ids { get; set; } = null!;
    }

    public class PermissionAssignationCommandHandler : IRequestHandler<PermissionAssignationCommand> {

        private readonly IRoleRepository _roleRepository;
        private readonly IPermissionRepository _permissionRepository;

        public PermissionAssignationCommandHandler(IPermissionRepository permissionRepository, IRoleRepository roleRepository) {
            _permissionRepository = permissionRepository;
            _roleRepository = roleRepository;
        }

        public async Task Handle(PermissionAssignationCommand request, CancellationToken cancellationToken) {

            if (request.Ids.Any() is false)
                await _roleRepository.ClearPermissionsAsync(request.RoleId);

            var permissions = await _permissionRepository.GetAllAsync();
            var permissionIds = permissions.Select(x => x.Id).AsEnumerable();

            // Check if provided id values exist in database
            var flag = request.Ids.All(item => permissionIds.Contains(item));

            if (flag is false)
                throw new NoSuchEntityExistsException($"Invalid permissions list");

            await _roleRepository.UpdatePermissionsAsync(request.RoleId, GetPermissions(request.Ids, permissions));
        }

        // we are getting a list of Ids, we need to get the entities associated with these ids in order to perform the insertion in the db
        private List<Permission> GetPermissions(IEnumerable<Guid> ids, IEnumerable<Permission> permissions) {
            var list = new List<Permission>();
            foreach (var permission in permissions)
                if (ids.Contains(permission.Id))
                    list.Add(permission);
            return list;
        }
    }

    public class PermissionAssignationCommandValidator : AbstractValidator<PermissionAssignationCommand> {
        public PermissionAssignationCommandValidator() {
            RuleFor(x => x.RoleId)
                .NotEmpty().WithMessage("Role ID cannot be empty");
        }
    }
}