using MediatR;

namespace Application.UseCases.Roles.Commands {
    public class AssignationCommand : IRequest {
        public Guid UserId { get; set; }
        public List<Guid> AssignIds { get; set; } = null!;
        public List<Guid> UnassignIds { get; set; } = null!;
    }
}
