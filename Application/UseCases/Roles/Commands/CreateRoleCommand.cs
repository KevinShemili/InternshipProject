using Application.UseCases.ViewRoles.Results;
using MediatR;

namespace Application.UseCases.Roles.Commands {
    public class CreateRoleCommand : IRequest<RoleResult> {
        public string Name { get; set; } = null!;
    }
}
