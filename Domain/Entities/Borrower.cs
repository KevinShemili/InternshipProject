using Domain.Common;

namespace Domain.Entities {
    public class Borrower : BaseEntity {
        public Guid BorrowedId { get; set; }
        public string CompanyName { get; set; } = null!;
        public int VATNumber { get; set; }
        public int FiscalCode { get; set; }
        public Guid UserId { get; set; }
        public Guid ApplicationId { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual CompanyType CompanyType { get; set; } = null!;
        public virtual CompanyProfile CompanyProfile { get; set; } = null!;
        public virtual ApplicationEntity? Application { get; set; }
    }
}
