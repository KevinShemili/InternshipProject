using Application.UseCases.ViewPermissions.Results;
using MediatR;

namespace Application.UseCases.Permissions.Commands {
    public class CreatePermissionCommand : IRequest<PermissionsResult> {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
