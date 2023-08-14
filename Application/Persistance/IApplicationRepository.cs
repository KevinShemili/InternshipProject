using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IApplicationRepository : IBaseRepository<ApplicationEntity> {
        new Task<ApplicationEntity> GetByIdAsync(Guid id);
        Task<bool> ContainsAsync(Guid id);
        Task UpdateAsync(ApplicationEntity entity);
        Task<List<ApplicationEntity>> GetApplications(Guid borrowerId);
        Task<ApplicationEntity> GetApplicationByBorrower(Guid borrowerId, Guid applicationId);
        Task<string> GetCompanyTypeAsync(Guid id);
        Task<ApplicationEntity> GetWithProductAsync(Guid id);
        Task<bool> IsApprovedAsLoanAsync(Guid id);
        Task UpdateStatus(Guid applicationId, Guid statusId);
    }
}
