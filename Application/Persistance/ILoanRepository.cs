using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface ILoanRepository : IBaseRepository<Loan> {
        Task<bool> ContainsAsync(Guid id);
        Task<IEnumerable<Loan>> GetLoansByBorrowerAsync(Guid borrowerId);
        Task<Loan?> GetLoanByBorrowerAsync(Guid borrowerId, Guid loanId);
    }
}
