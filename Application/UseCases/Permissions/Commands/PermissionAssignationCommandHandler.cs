﻿using Application.Exceptions;
using Application.Exceptions.ServerErrors;
using Application.Persistance;
using Application.Persistance.Common;
using Domain.Entities;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.Permissions.Commands {

    public class PermissionAssignationCommand : IRequest<bool> {
        public Guid RoleId { get; set; }
        public List<Guid> Ids { get; set; } = null!;
    }

    public class PermissionAssignationCommandHandler : IRequestHandler<PermissionAssignationCommand, bool> {

        private readonly IRoleRepository _roleRepository;
        private readonly IPermissionRepository _permissionRepository;
        private readonly IStringLocalizer<LocalizationResources> _localization;
        private readonly IUnitOfWork _unitOfWork;

        public PermissionAssignationCommandHandler(IPermissionRepository permissionRepository,
                                                   IRoleRepository roleRepository,
                                                   IStringLocalizer<LocalizationResources> localizer,
                                                   IUnitOfWork unitOfWork) {
            _permissionRepository = permissionRepository;
            _roleRepository = roleRepository;
            _localization = localizer;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(PermissionAssignationCommand request, CancellationToken cancellationToken) {

            // all permissions are removed
            if (request.Ids.Any() is false)
                await _roleRepository.ClearPermissionsAsync(request.RoleId);

            var permissions = await _permissionRepository.GetAllAsync();
            var permissionIds = permissions.Select(x => x.Id).AsEnumerable();

            // Check if provided id values exist in database
            var flag = request.Ids.All(item => permissionIds.Contains(item));

            if (flag is false)
                throw new InvalidInputException(_localization.GetString("InvalidPermissions").Value);

            await _roleRepository.UpdatePermissionsAsync(request.RoleId, GetPermissions(request.Ids, permissions));

            var dbFlag = await _unitOfWork.SaveChangesAsync();
            if (flag is false)
                throw new DatabaseException(_localization.GetString("DatabaseException").Value);
            return true;
        }

        // we are getting a list of Ids, we need to get the entities associated with these ids in order to perform the insertion in the db
        private static List<Permission> GetPermissions(IEnumerable<Guid> ids, IEnumerable<Permission> permissions) {
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
                .NotEmpty().WithMessage("EmptyRoleId");
        }
    }
}
