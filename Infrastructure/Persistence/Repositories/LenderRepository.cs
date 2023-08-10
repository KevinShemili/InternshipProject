using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class LenderRepository : BaseRepository<Lender>, ILenderRepository {
        public LenderRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> ContainsAsync(Guid id) {
            var entity = await _databaseContext.Lenders
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<List<Guid>> GetIdsAsync() {
            var ids = await _databaseContext.Lenders.Select(x => x.Id).ToListAsync();
            return ids;
        }

        public async Task<List<Lender>> GetLendersAsync(List<Guid> ids) {
            var lenders = await _databaseContext.Lenders
                .Where(lender => ids.Contains(lender.Id))
                .ToListAsync();

            return lenders;
        }
    }
}
