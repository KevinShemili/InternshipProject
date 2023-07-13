using Domain.Common;

namespace Domain.Entities {
    public class Loan : BaseEntity {
        public Guid LoanId { get; set; }
        public int RequestedAmount { get; set; }
        public decimal ReferenceRate { get; set; }
        public decimal InterestRate { get; set; }
        public int Tenor { get; set; }
        public string Status { get; set; } = null!;
        public Guid LenderId { get; set; }
        public virtual ApplicationEntity Application { get; set; } = null!;
        public virtual Lender Lender { get; set; } = null!;
    }
}
