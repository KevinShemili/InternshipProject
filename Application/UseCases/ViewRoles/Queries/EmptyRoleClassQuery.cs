using Application.UseCases.ViewRoles.Results;
using MediatR;

namespace Application.UseCases.ViewPermissions.Queries {
    public class EmptyRoleClassQuery : IRequest<List<RoleResult>> {
    }
}
