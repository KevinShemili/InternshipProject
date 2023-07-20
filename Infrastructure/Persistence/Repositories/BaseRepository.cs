using Application.Persistance.Common;
using Domain.Common;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity {

        protected readonly DatabaseContext _databaseContext;

        public BaseRepository(DatabaseContext databaseContext) {
            _databaseContext = databaseContext;
        }

        public async Task CreateAsync(T entity) {
            await _databaseContext.Set<T>().AddAsync(entity);
            await _databaseContext.SaveChangesAsync();
        }

        public async void DeleteAsync(int id) {
            var toBeDeleted = await GetByIdAsync(id);
            var entity = _databaseContext.Set<T>().Remove(toBeDeleted);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync() {
            return await _databaseContext.Set<T>().ToListAsync();
        }


        public async Task<T> GetByIdAsync(int id) {
            var entity = await _databaseContext.Set<T>().FindAsync(id);
            if (entity == null)
                return null;

            return entity;
        }
    }
}
