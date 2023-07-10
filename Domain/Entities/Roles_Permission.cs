using Domain.Common;

namespace Domain.Entities {
    public class Roles_Permission : BaseEntity {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
        public virtual Role Role { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual Permission Permission { get; set; } = null!;
    }
}
