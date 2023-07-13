using Domain.Common;

namespace Domain.Entities {
    public class Role : BaseEntity {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public virtual ICollection<User> Users { get; set; } = null!;
        public virtual ICollection<Permission> Permissions { get; set; } = null!;
    }
}
