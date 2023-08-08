using Domain.Common;

namespace Domain.Entities {
    public class LenderMatrix : BaseEntity {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
