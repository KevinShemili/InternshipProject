using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories {
    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository {
        public PermissionRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }
    }
}
