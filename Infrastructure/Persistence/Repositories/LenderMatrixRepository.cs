using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class LenderMatrixRepository : BaseRepository<LenderMatrix>, ILenderMatrixRepository {
        public LenderMatrixRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> ContainsAsync(Guid lenderId, Guid productId) {
            var matrix = await _databaseContext.LenderMatrices
            .Where(e => e.LenderId == lenderId && e.ProductId == productId)
            .FirstOrDefaultAsync();

            return matrix != null;
        }

        public async Task<List<Guid>> GetLenderIdsAsync(Guid productId) {
            var lenderIds = await _databaseContext.LenderMatrices
                .Where(x => x.ProductId == productId)
                .Select(x => x.LenderId)
                .ToListAsync();

            return lenderIds;
        }

        public async Task<int> GetTenorAsync(Guid lenderId, Guid productId) {
            var matrix = await _databaseContext.LenderMatrices
            .Where(e => e.LenderId == lenderId && e.ProductId == productId)
            .FirstOrDefaultAsync();

            return matrix.Tenor;
        }

        public async Task UploadAsync(LenderMatrix entity) {
            var existingEntity = await _databaseContext.LenderMatrices
                .Where(e => e.LenderId == entity.LenderId && e.ProductId == entity.ProductId) // check if row already exists & just update Tenor & Spread
                .FirstOrDefaultAsync();

            // else create a new entry
            if (existingEntity == null)
                await base.CreateAsync(entity);
            else {
                existingEntity.Tenor = entity.Tenor;
                existingEntity.Spread = entity.Spread;
            }
        }
    }
}

