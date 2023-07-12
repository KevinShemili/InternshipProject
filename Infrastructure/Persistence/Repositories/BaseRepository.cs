using Application.Persistance.Common;
using Domain.Common;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories {
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity {

        protected readonly DatabaseContext _databaseContext;

        public BaseRepository(DatabaseContext databaseContext) {
            _databaseContext = databaseContext;
        }

        public void Create(T entity) {
            _databaseContext.Set<T>().Add(entity);
            _databaseContext.SaveChanges();
        }

        public void Delete(int id) {
            var toBeDeleted = GetById(id);
            var entity = _databaseContext.Set<T>().Remove(toBeDeleted);
            _databaseContext.SaveChanges();
        }

        public T GetById(int id) {
            var entity = _databaseContext.Set<T>().Find(id);
            if (entity == null) {
                return null;
            }
            return entity;
        }
    }
}
