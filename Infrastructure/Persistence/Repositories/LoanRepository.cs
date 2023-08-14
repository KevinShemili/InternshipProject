using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class LoanRepository : BaseRepository<Loan>, ILoanRepository {
        public LoanRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> ContainsAsync(Guid id) {
            var loan = await _databaseContext.Loans
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return loan != null;
        }

        public async Task<Loan?> GetLoanByBorrowerAsync(Guid borrowerId, Guid loanId) {
#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            var borrower = await _databaseContext.Borrowers
                .Include(x => x.Applications)
                .ThenInclude(x => x.Loan)
                .Where(x => x.Id == borrowerId)
                .FirstOrDefaultAsync();
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.

            var applications = borrower.Applications;
            foreach (var application in applications)
                if (application.Loan is not null && application.Loan.Id == loanId)
                    return application.Loan;

            return null;
        }

        public async Task<IEnumerable<Loan>> GetLoansByBorrowerAsync(Guid borrowerId) {
            var borrower = await _databaseContext.Borrowers
                .Include(x => x.Applications)
                .ThenInclude(x => x.Loan)
                .Where(x => x.Id == borrowerId)
                .FirstOrDefaultAsync();

            var list = new List<Loan>();
            var applications = borrower.Applications;
            foreach (var application in applications)
                if (application.Loan is not null)
                    list.Add(application.Loan);

            return list.AsEnumerable();
        }
    }
}
