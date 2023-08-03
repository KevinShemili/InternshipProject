using Application.Persistance.Common;
using Domain.Common;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Common {
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity {

        protected readonly DatabaseContext _databaseContext;

        public BaseRepository(DatabaseContext databaseContext) {
            _databaseContext = databaseContext;
        }

        public async Task CreateAsync(T entity) {
            await _databaseContext.Set<T>().AddAsync(entity);
        }

        public async Task DeleteAsync(Guid id) {
            var toBeDeleted = await GetByIdAsync(id);
#pragma warning disable CS8604 // Possible null reference argument.
            var _ = _databaseContext.Set<T>().Remove(toBeDeleted);
#pragma warning restore CS8604 // Possible null reference argument.
        }

        public async Task<List<T>> GetAllAsync() {
            return await _databaseContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id) {
            var entity = await _databaseContext.Set<T>().FindAsync(id);
            if (entity == null)
                return null;

            return entity;
        }
    }
}
