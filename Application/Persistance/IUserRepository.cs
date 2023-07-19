using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IUserRepository : IBaseRepository<User> {
        public Task<User> GetByUsernameAsync(string username);
        public Task<User> GetByEmailAsync(string email);
        Task<HashSet<string>> GetPermissionsAsync(Guid userId);
        Task<IEnumerable<string>> GetRolesAsync(Guid userId);
        Task<bool> ContainsUsername(string username);
        Task<bool> ContainsEmail(string email);
        Task ActivateAccount(string email);
        Task<bool?> ChangePassword(string email, string passwordSalt, string passwordHash);
    }
}
