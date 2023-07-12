using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories {
    public class UserRepository : BaseRepository<User>, IUserRepository {
        public UserRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public User GetUserByUsername(string Username) {
            var entity = _databaseContext.Users
                .Where(x => x.Username == Username)
                .FirstOrDefault();

            if (entity == null) 
                return null;

            return entity;
        }
    }
}
