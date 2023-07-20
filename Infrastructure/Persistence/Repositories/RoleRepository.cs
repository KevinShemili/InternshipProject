using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories {
    public class RoleRepository : BaseRepository<Role>, IRoleRepository {
        public RoleRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }
    }
}
