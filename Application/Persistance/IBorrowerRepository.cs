using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IBorrowerRepository : IBaseRepository<Borrower> {
        Task<bool> IsFiscalCodeUniqueAsync(Guid userId, string fiscalCode);
        Task<bool> HasApplicationsAsync(Guid id);
        Task<bool> ContainsAsync(Guid id);
        Task<bool> UpdateAsync(Guid Id, Borrower borrower);
        new Task<Borrower?> GetByIdAsync(Guid id);
        Task<CompanyProfile> GetCompanyProfile(Guid id);
        Task<IEnumerable<Borrower>> GetUserBorrowers(Guid userId);
    }
}
