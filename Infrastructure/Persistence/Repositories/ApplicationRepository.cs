using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class ApplicationRepository : BaseRepository<ApplicationEntity>, IApplicationRepository {
        public ApplicationRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> ContainsAsync(Guid id) {
            var application = await _databaseContext.Applications
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return application != null;
        }

        public async Task<ApplicationEntity> GetApplicationByBorrower(Guid borrowerId, Guid applicationId) {
            var application = await _databaseContext.Applications
                .Include(x => x.ApplicationStatus)
                .Where(x => x.BorrowerId == borrowerId
                            && x.Id == applicationId)
                .FirstOrDefaultAsync();

            return application;
        }

        public async Task<List<ApplicationEntity>> GetApplications(Guid borrowerId) {
            var applications = await _databaseContext.Applications
                .Include(x => x.ApplicationStatus)
                .Where(x => x.BorrowerId == borrowerId)
                .ToListAsync();

            return applications;
        }

        public async Task<ApplicationEntity> GetWithProductAsync(Guid id) {
            var application = await _databaseContext.Applications
                .Include(x => x.Product)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return application;
        }

        public async Task<string> GetCompanyTypeAsync(Guid id) {
            var application = await _databaseContext.Applications
                .Include(x => x.Borrower)
                .ThenInclude(x => x.CompanyType)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            var companyType = application.Borrower.CompanyType.Type;
            return companyType;
        }

        public async Task UpdateAsync(Guid id, ApplicationEntity entity) {
            var application = await base.GetByIdAsync(id);
            application.Product = entity.Product;
            application.RequestedAmount = entity.RequestedAmount;
            application.RequestedTenor = entity.RequestedTenor;
            application.FinancePurposeDefinition = entity.FinancePurposeDefinition;
            application.Name = entity.Name;
        }

        public async Task<bool> IsApprovedAsLoanAsync(Guid id) {
            var application = await _databaseContext.Applications
                .Include(x => x.Loan)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return application.Loan != null;
        }

        public async Task UpdateStatus(Guid applicationId, Guid statusId) {
            var application = await _databaseContext.Applications
                .Where(x => x.Id == applicationId)
                .FirstOrDefaultAsync();

            application.ApplicationStatusId = statusId;
        }

        public new async Task<ApplicationEntity?> GetByIdAsync(Guid id) {
            var application = await _databaseContext.Applications
                .Include(x => x.ApplicationStatus)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return application;
        }
    }
}
