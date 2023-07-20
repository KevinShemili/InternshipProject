namespace Application.Persistance.Common {
    public interface IBaseRepository<T> {
        public Task<List<T>> GetAllAsync();
        public Task CreateAsync(T entity);
        void DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);
    }
}
