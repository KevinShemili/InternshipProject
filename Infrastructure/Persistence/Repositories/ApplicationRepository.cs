using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Common;

namespace Infrastructure.Persistence.Repositories {
    public class ApplicationRepository : BaseRepository<ApplicationEntity>, IApplicationRepository {
        public ApplicationRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }
    }
}
