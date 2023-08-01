using Application.Persistance.Common;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories.Common {
    public class UnitOfWork : IUnitOfWork {

        private readonly DatabaseContext _databaseContext;

        public UnitOfWork(DatabaseContext databaseContext) {
            _databaseContext = databaseContext;
        }

        public async Task SaveChangesAsync() {
            await _databaseContext.SaveChangesAsync();
        }
    }
}
