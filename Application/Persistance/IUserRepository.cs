using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IUserRepository : IBaseRepository<User> {
        public Task<User> GetByUsernameAsync(string Username);
        Task<HashSet<string>> GetPermissionsAsync(Guid UserId);
        Task<IEnumerable<string>> GetRolesAsync(Guid UserId);
    }
}
