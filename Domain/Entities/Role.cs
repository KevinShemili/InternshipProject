using Domain.Common;

namespace Domain.Entities {
    public class Role : BaseEntity {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public virtual Roles_Permission RolesPermissions { get; set; } = null!;
    }
}
