using Domain.Common;

namespace Domain.Entities {
    public class Lender : BaseEntity {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int RequestedAmount { get; set; }
        public int Tenor { get; set; }
        public string BorrowerCompanyType { get; set; } = null!;
        public virtual ICollection<Loan>? Loans { get; set; }
    }
}
