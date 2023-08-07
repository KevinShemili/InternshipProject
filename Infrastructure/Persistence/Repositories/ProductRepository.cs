using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class ProductRepository : BaseRepository<Product>, IProductRepository {
        public ProductRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> ContainsAsync(string name) {
            var entity = await _databaseContext.Products
                .Where(x => x.Name == name)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<Product> GetByNameAsync(string name) {
            var entity = await _databaseContext.Products
                .Where(x => x.Name == name)
                .FirstOrDefaultAsync();

            if (entity is null)
                return null;
            return entity;
        }
    }
}
