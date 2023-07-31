using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class BorrowerRepository : BaseRepository<Borrower>, IBorrowerRepository {
        public BorrowerRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> AddCompanyTypeAsync(Guid id, CompanyType companyType) {
            var borrower = await _databaseContext.Borrowers
                .Include(x => x.CompanyType)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (borrower is null)
                return false;

            borrower.CompanyType = companyType;
            await _databaseContext.SaveChangesAsync();

            return true;
        }
    }
}
