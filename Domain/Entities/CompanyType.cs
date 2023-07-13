using Domain.Common;

namespace Domain.Entities {
    public class CompanyType : BaseEntity {
        public Guid CompanyTypeId { get; set; }
        public string Type { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid BorrowerId { get; set; }
        public virtual Borrower Borrower { get; set; } = null!;
    }
}
