using Domain.Common;

namespace Domain.Entities {
    public class ApplicationEntity : BaseEntity {
        public Guid ApplicationId { get; set; }
        public string ApplicationName { get; set; } = null!;
        public int RequestedAmount { get; set; }
        public int RequestedTenor { get; set; }
        public string FinancePurposeDefinition { get; set; } = null!;
        public string ApplicationStatus { get; set; } = null!;
        public Guid ProductId { get; set; }
        public Guid LoanId { get; set; }
        public virtual Borrower Borrower { get; set; } = null!;
        public virtual ProductMatrix? ProductMatrix { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual Loan Loan { get; set; } = null!;
    }
}
