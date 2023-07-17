using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IUserRepository : IBaseRepository<User> {
        public User GetUserByUsername(string Username);
        Task<HashSet<string>> GetPermissionsAsync(Guid UserId);
        Task<IEnumerable<string>> GetRolesAsync(Guid UserId);
    }
}
