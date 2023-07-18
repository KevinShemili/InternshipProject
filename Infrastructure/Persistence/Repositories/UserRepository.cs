using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class UserRepository : BaseRepository<User>, IUserRepository {
        public UserRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task ActivateAccount(string Email) {
            var entity = await GetByEmailAsync(Email);
            entity.IsEmailConfirmed = true;
            await _databaseContext.SaveChangesAsync();
        }

        public async Task<bool> ContainsEmail(string Email) {
            var entity = await _databaseContext.Users
                .Where(x => x.Email == Email)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<bool> ContainsUsername(string Username) {
            var entity = await _databaseContext.Users
                .Where(x => x.Username == Username)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<User> GetByUsernameAsync(string Username) {
            var entity = await _databaseContext.Users
                .Where(x => x.Username == Username)
                .FirstOrDefaultAsync();

            if (entity is null)
                return null;

            return entity;
        }

        public async Task<User> GetByEmailAsync(string Email) {
            var entity = await _databaseContext.Users
                .Where(x => x.Email == Email)
                .FirstOrDefaultAsync();

            if (entity is null)
                return null;

            return entity;
        }

        public async Task<HashSet<string>> GetPermissionsAsync(Guid UserId) {
            var roles = await _databaseContext.Users
                .Include(x => x.Roles)
                .ThenInclude(x => x.Permissions)
                .Where(x => x.Id == UserId)
                .Select(x => x.Roles)
                .ToArrayAsync();

            var permissions = roles
                .SelectMany(x => x)
                .SelectMany(x => x.Permissions)
                .Select(x => x.Name)
                .ToHashSet();

            return permissions;
        }

        public async Task<IEnumerable<string>> GetRolesAsync(Guid userId) {
            var roles = await _databaseContext.Users
                .Include(x => x.Roles)
                .Where(x => x.Id == userId)
                .SelectMany(x => x.Roles)
                .Select(x => x.Name)
                .ToListAsync();

            return roles.AsEnumerable();
        }
    }
}
