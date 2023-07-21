using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class UserRepository : BaseRepository<User>, IUserRepository {
        public UserRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task ActivateAccountAsync(string email) {
            var entity = await GetByEmailAsync(email);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            entity.IsEmailConfirmed = true;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            await _databaseContext.SaveChangesAsync();
        }

        public async Task<bool> ContainsEmailAsync(string email) {
            var entity = await _databaseContext.Users
                .Where(x => x.Email == email)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<bool> ContainsUsernameAsync(string username) {
            var entity = await _databaseContext.Users
                .Where(x => x.Username == username)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<User?> GetByUsernameAsync(string username) {
            var entity = await _databaseContext.Users
                .Where(x => x.Username == username)
                .FirstOrDefaultAsync();

            if (entity is null)
                return null;

            return entity;
        }

        public async Task<User?> GetByEmailAsync(string email) {
            var entity = await _databaseContext.Users
                .Where(x => x.Email == email)
                .FirstOrDefaultAsync();

            if (entity is null)
                return null;

            return entity;
        }

        public async Task<HashSet<string>> GetPermissionsAsync(Guid userId) {
            var roles = await _databaseContext.Users
                .Include(x => x.Roles)
                .ThenInclude(x => x.Permissions)
                .Where(x => x.Id == userId)
                .Select(x => x.Roles)
                .ToArrayAsync();

            var permissions = roles
                .SelectMany(x => x)
                .SelectMany(x => x.Permissions)
                .Select(x => x.Name)
                .ToHashSet();

            return permissions;
        }

        public async Task<bool?> ChangePasswordAsync(string email, string passwordHash, string passwordSalt) {
            var entity = await GetByEmailAsync(email);

            if (entity is null)
                return null;

            entity.PasswordHash = passwordHash;
            entity.PasswordSalt = passwordSalt;
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<HashSet<Role>> GetRolesAsync(Guid userId) {
            var roles = await _databaseContext.Users
                .Include(x => x.Roles)
                .Where(x => x.Id == userId)
                .SelectMany(x => x.Roles)
                .ToListAsync();

            return roles.ToHashSet();
        }

        public async Task<bool> UpdateRolesAsync(Guid id, IEnumerable<Role> roles) {
            var user = await _databaseContext.Users
                .Include(x => x.Roles)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
                return false;

            user.Roles.Clear();

            foreach (var role in roles)
                user.Roles.Add(role);

            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ClearRolesAsync(Guid id) {
            var user = await _databaseContext.Users
                .Include(x => x.Roles)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
                return false;

            user.Roles.Clear();
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
