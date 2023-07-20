using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IRoleRepository : IBaseRepository<Role> {
        public Task<HashSet<Permission>> GetPermissionsAsync(Guid roleId);
        public Task<bool> Contains(IEnumerable<Guid> ids);
        public Task<IEnumerable<Role>> GetByIdAsync(IEnumerable<Guid> ids);
    }
}
