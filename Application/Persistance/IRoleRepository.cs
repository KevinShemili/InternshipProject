using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IRoleRepository : IBaseRepository<Role> {
        public Task<HashSet<Permission>> GetPermissionsAsync(Guid roleId);
        Task<bool> UpdatePermissions(Guid id, IEnumerable<Permission> assign, IEnumerable<Permission> unassign);
        Task<bool> AddPermissions(Guid id, IEnumerable<Permission> assign);
        Task<bool> RemovePermissions(Guid id, IEnumerable<Permission> unassign);
    }
}
