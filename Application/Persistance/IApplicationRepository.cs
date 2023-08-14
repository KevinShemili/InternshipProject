﻿using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IApplicationRepository : IBaseRepository<ApplicationEntity> {
        Task<bool> ContainsAsync(Guid id);
        Task UpdateAsync(Guid id, ApplicationEntity entity);
        Task<List<ApplicationEntity>> GetApplications(Guid borrowerId);
        Task<ApplicationEntity> GetApplicationByBorrower(Guid borrowerId, Guid applicationId);
        Task<string> GetCompanyTypeAsync(Guid id);
        Task<ApplicationEntity> GetWithProductAsync(Guid id);
        Task<bool> IsApprovedAsLoanAsync(Guid id);
    }
}
