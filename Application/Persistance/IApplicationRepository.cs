using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IApplicationRepository : IBaseRepository<ApplicationEntity> {
        Task<bool> ContainsAsync(Guid id);
        Task UpdateAsync(Guid id, ApplicationEntity entity);
    }
}
