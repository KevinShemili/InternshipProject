using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface ILenderMatrixRepository : IBaseRepository<LenderMatrix> {
        Task UploadAsync(LenderMatrix entity);
        Task<int> GetTenorAsync(Guid lenderId, Guid productId);
        Task<bool> ContainsAsync(Guid lenderId, Guid productId);
        Task<List<Guid>> GetLenderIdsAsync(Guid productId);
    }
}
