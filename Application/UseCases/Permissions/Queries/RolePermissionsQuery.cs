using Application.UseCases.ViewPermissions.Results;
using MediatR;

namespace Application.UseCases.Permissions.Queries {
    public class RolePermissionsQuery : IRequest<List<PermissionsResult>> {
        public Guid Id { get; set; }
    }
}
