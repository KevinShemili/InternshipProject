using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IBorrowerRepository : IBaseRepository<Borrower> {
        Task<bool> IsFiscalCodeUniqueAsync(Guid userId, string fiscalCode);
    }
}
