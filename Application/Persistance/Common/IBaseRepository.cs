namespace Application.Persistance.Common {
    public interface IBaseRepository<T> {
        public Task CreateAsync(T entity);
        void DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);
    }
}
