using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IUserRepository : IBaseRepository<User> {
        public Task<User?> GetByUsernameAsync(string username);
        public Task<User?> GetByEmailAsync(string email);
        Task<HashSet<string>> GetPermissionsAsync(Guid userId);
        public Task<HashSet<Role>> GetRolesAsync(Guid userId);
        Task<bool> ContainsUsername(string username);
        Task<bool> ContainsEmail(string email);
        Task ActivateAccount(string email);
        Task<bool?> ChangePassword(string email, string passwordSalt, string passwordHash);
        Task<bool> UpdateRoles(Guid id, IEnumerable<Role> assign, IEnumerable<Role> unassign);
        Task<bool> AddRoles(Guid id, IEnumerable<Role> assign);
        Task<bool> RemoveRoles(Guid id, IEnumerable<Role> unassign);
    }
}
