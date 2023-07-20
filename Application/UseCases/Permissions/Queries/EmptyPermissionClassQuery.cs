using Application.UseCases.ViewPermissions.Results;
using MediatR;

namespace Application.UseCases.ViewPermissions.Queries {
    public class EmptyPermissionClassQuery : IRequest<List<PermissionsResult>> {
    }
}
