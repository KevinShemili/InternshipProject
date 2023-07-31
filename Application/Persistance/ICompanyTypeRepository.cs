using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface ICompanyTypeRepository : IBaseRepository<CompanyType> {
        Task<bool> ContainsAsync(string type);
        Task<CompanyType> GetByNameAsync(string name);
    }
}
