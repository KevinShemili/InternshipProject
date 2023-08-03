using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface ICompanyProfileRepository : IBaseRepository<CompanyProfile> {
        Task UpdateAsync(Guid id, CompanyProfile companyProfile);
    }
}
