using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class RoleRepository : BaseRepository<Role>, IRoleRepository {
        public RoleRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> AddPermissions(Guid id, IEnumerable<Permission> assign) {
            var role = await _databaseContext.Roles
                .Include(x => x.Permissions)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (role is null)
                return false;

            foreach (var permission in assign)
                role.Permissions.Add(permission);

            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<HashSet<Permission>> GetPermissionsAsync(Guid roleId) {
            var permissions = await _databaseContext.Roles
                .Include(x => x.Permissions)
                .Where(x => x.Id == roleId)
                .SelectMany(x => x.Permissions)
                .ToListAsync();

            return permissions.ToHashSet();
        }

        public async Task<bool> RemovePermissions(Guid id, IEnumerable<Permission> unassign) {
            var role = await _databaseContext.Roles
                .Include(x => x.Permissions)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (role is null)
                return false;

            foreach (var permission in unassign)
                role.Permissions.Remove(permission);

            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePermissions(Guid id, IEnumerable<Permission> assign, IEnumerable<Permission> unassign) {
            var role = await _databaseContext.Roles
                .Include(x => x.Permissions)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (role is null)
                return false;

            foreach (var permission in assign)
                role.Permissions.Add(permission);

            foreach (var permission in unassign)
                role.Permissions.Remove(permission);

            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
