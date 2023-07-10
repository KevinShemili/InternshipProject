using Domain.Common;

namespace Domain.Entities {
    public class Permission : BaseEntity {
        public Guid PermissionId { get; set; }    
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual Roles_Permission RolesPermissions { get; set; } = null!;

    }
}
