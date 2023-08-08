using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IProductRepository : IBaseRepository<Product> {
        Task<Product> GetByNameAsync(string name);
        Task<bool> ContainsAsync(string name);
        Task<bool> ContainsAsync(Guid id);
    }
}
