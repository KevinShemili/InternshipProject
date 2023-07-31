using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IBorrowerRepository : IBaseRepository<Borrower> {
        Task<bool> AddCompanyTypeAsync(Guid id, CompanyType companyType);
    }
}
