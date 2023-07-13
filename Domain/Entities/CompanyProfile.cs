using Domain.Common;

namespace Domain.Entities {
    public class CompanyProfile : BaseEntity {
        public Guid Id { get; set; }
        public string Country { get; set; } = null!;
        public string Currency { get; set; } = null!;
        public string Exchange { get; set; } = null!;
        public string IPO { get; set; } = null!;
        public int MarketCapitalization { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public decimal ShareOutstanding { get; set; }
        public string Ticker { get; set; } = null!;
        public string WebUrl { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public string FinnhubIndustry { get; set; } = null!;
        public Guid BorrowerId { get; set; }
        public virtual Borrower Borrower { get; set; } = null!;
    }
}
