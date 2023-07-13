using Domain.Common;

namespace Domain.Entities {
    public class ProductMatrix : BaseEntity {
        public Guid FileId { get; set; }
        public string FileName { get; set; } = null!;
        public Guid ApplicationId { get; set; }
        public ApplicationEntity Application { get; set; } = null!;
    }
}
