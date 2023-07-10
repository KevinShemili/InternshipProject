using Domain.Common;

namespace Domain.Entities {
    public class Product : BaseEntity {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public decimal ReferenceRate { get; set; } 
        public int FinanceMaxAmount { get; set; }
        public int FinanceMinAmount { get; set; }
        public virtual ApplicationEntity Application { get; set; } = null!;
    }
}
