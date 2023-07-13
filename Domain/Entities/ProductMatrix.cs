using Domain.Common;

namespace Domain.Entities {
    public class ProductMatrix : BaseEntity {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid ApplicationId { get; set; }
        public ApplicationEntity Application { get; set; } = null!;
    }
}
