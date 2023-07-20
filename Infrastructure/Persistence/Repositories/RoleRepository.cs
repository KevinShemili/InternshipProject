using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class RoleRepository : BaseRepository<Role>, IRoleRepository {
        public RoleRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }


        public async Task<IEnumerable<Role>> GetByIdAsync(IEnumerable<Guid> ids) {
            var roles = await _databaseContext.Roles
                .Where(role => ids.Contains(role.Id))
                .ToListAsync();

            return roles.AsEnumerable();
        }

        public async Task<HashSet<Permission>> GetPermissionsAsync(Guid roleId) {
            var permissions = await _databaseContext.Roles
                .Include(x => x.Permissions)
                .Where(x => x.Id == roleId)
                .SelectMany(x => x.Permissions)
                .ToListAsync();

            return permissions.ToHashSet();
        }

        public async Task<bool> Contains(IEnumerable<Guid> ids) {
            var roleIds = await _databaseContext.Roles
                .Select(role => role.Id)
                .ToListAsync();

            foreach (var id in ids)
                if (!roleIds.Contains(id))
                    return false;
            return true;
        }

    }
}
