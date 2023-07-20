using Application.UseCases.ViewRoles.Results;
using MediatR;

namespace Application.UseCases.Roles.Queries {
    public class UserRoleQuery : IRequest<List<RoleResult>> {
        public Guid Id { get; set; }
    }
}
