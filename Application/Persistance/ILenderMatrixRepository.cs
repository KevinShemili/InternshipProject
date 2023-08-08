using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface ILenderMatrixRepository : IBaseRepository<LenderMatrix> {
        Task UploadAsync(LenderMatrix entity);
    }
}
