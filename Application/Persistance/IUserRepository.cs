using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IUserRepository : IBaseRepository<User> {
        Task<User?> GetByUsernameAsync(string username);
        Task<User?> GetByEmailAsync(string email);
        Task<HashSet<string>> GetPermissionsAsync(Guid userId);
        Task<HashSet<Role>> GetRolesAsync(Guid userId);
        Task<bool> ContainsUsernameAsync(string username);
        Task<bool> ContainsEmailAsync(string email);
        Task ActivateAccountAsync(string email);
        Task<bool?> ChangePasswordAsync(string email, string passwordSalt, string passwordHash);
        Task<bool> UpdateRolesAsync(Guid id, IEnumerable<Role> roles);
        Task<bool> ClearRolesAsync(Guid id);
    }
}
