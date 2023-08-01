using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class BorrowerRepository : BaseRepository<Borrower>, IBorrowerRepository {
        public BorrowerRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> IsFiscalCodeUniqueAsync(Guid id, string fiscalCode) {
            var borrowers = await _databaseContext.Borrowers
                .Where(x => x.UserId == id)
                .ToListAsync();

            if (borrowers.Any() is false)
                return true;

            var flag = borrowers.Any(x => x.FiscalCode == fiscalCode);

            if (flag is false)
                return true;
            else
                return false;
        }
    }
}
