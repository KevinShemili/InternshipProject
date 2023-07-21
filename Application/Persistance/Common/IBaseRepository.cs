namespace Application.Persistance.Common {
    public interface IBaseRepository<T> {
        Task<List<T>> GetAllAsync();
        Task CreateAsync(T entity);
        void DeleteAsync(int id);
        Task<T?> GetByIdAsync(int id);
    }
}
