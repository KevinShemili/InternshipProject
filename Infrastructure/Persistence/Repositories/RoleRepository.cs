using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class RoleRepository : BaseRepository<Role>, IRoleRepository {
        public RoleRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> ClearPermissionsAsync(Guid id) {
            var role = await _databaseContext.Roles
                .Include(x => x.Permissions)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (role is null)
                return false;

            role.Permissions.Clear();
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ContainsAsync(Guid id) {
            var entity = await _databaseContext.Roles
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<Role> GetByName(string name) {
            var entity = await _databaseContext.Roles
                .Where(x => x.Name == name)
                .FirstOrDefaultAsync();

            if (entity is null)
                return null;
            return entity;
        }

        public async Task<HashSet<Permission>> GetPermissionsAsync(Guid id) {
            var permissions = await _databaseContext.Roles
                .Include(x => x.Permissions)
                .Where(x => x.Id == id)
                .SelectMany(x => x.Permissions)
                .ToListAsync();

            return permissions.ToHashSet();
        }

        public async Task<bool> UpdatePermissionsAsync(Guid id, IEnumerable<Permission> permissions) {
            var role = await _databaseContext.Roles
                .Include(x => x.Permissions)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (role is null)
                return false;

            role.Permissions.Clear();

            role.Permissions.ToList().AddRange(permissions);

            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
