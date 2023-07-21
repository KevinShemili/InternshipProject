using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IRoleRepository : IBaseRepository<Role> {
        Task<HashSet<Permission>> GetPermissionsAsync(Guid id);
        Task<bool> ClearPermissionsAsync(Guid id);
        Task<bool> UpdatePermissionsAsync(Guid id, IEnumerable<Permission> permissions);
    }
}
