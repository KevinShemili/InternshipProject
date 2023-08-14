using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class BorrowerRepository : BaseRepository<Borrower>, IBorrowerRepository {
        public BorrowerRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> ContainsAsync(Guid id) {
            var borrower = await _databaseContext.Borrowers
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return borrower != null;
        }

        public new async Task<Borrower?> GetByIdAsync(Guid id) {
            var borrower = await _databaseContext.Borrowers
                .Where(x => x.Id == id)
                .Include(x => x.User)
                .Include(x => x.CompanyProfile)
                .FirstOrDefaultAsync();
            return borrower;
        }

        public async Task<CompanyProfile> GetCompanyProfile(Guid id) {
            var entity = await _databaseContext.Borrowers
                .Where(x => x.Id == id)
                .Include(x => x.CompanyProfile)
                .FirstOrDefaultAsync();

            return entity.CompanyProfile;
        }

        public async Task<IEnumerable<Borrower>> GetUserBorrowers(Guid userId) {
            var user = await _databaseContext.Users
                .Include(x => x.Borrowers)
                .Where(x => x.Id == userId)
                .FirstOrDefaultAsync();

            var borrowers = user.Borrowers;
            return borrowers;
        }

        public async Task<bool> HasApplicationsAsync(Guid id) {
            var borrower = await _databaseContext.Borrowers
                .Include(x => x.Applications)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            var applications = borrower.Applications;
            if (applications is null || applications.Any() is false)
                return false;

            return true;
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

        public async Task<bool> UpdateAsync(Guid Id, Borrower borrower) {
            var entity = await base.GetByIdAsync(Id);
            entity.CompanyName = borrower.CompanyName;
            entity.CompanyType = borrower.CompanyType;
            entity.VATNumber = borrower.VATNumber;
            entity.FiscalCode = borrower.FiscalCode;
            return true;
        }
    }
}
