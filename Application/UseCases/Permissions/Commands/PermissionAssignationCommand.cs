using MediatR;

namespace Application.UseCases.Permissions.Commands {
    public class PermissionAssignationCommand : IRequest {
        public Guid UserId { get; set; }
        public List<Guid> AssignIds { get; set; } = null!;
        public List<Guid> UnassignIds { get; set; } = null!;
    }
}
