using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IUserRepository : IBaseRepository<User> {
        public Task<User> GetByUsernameAsync(string Username);
        public Task<User> GetByEmailAsync(string Email);
        Task<HashSet<string>> GetPermissionsAsync(Guid UserId);
        Task<IEnumerable<string>> GetRolesAsync(Guid UserId);
        Task<bool> ContainsUsername(string Username);
        Task<bool> ContainsEmail(string Email);
        Task ActivateAccount(string Email);
    }
}
