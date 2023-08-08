using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class LenderMatrixConfiguration : IEntityTypeConfiguration<LenderMatrix> {
        public void Configure(EntityTypeBuilder<LenderMatrix> builder) {
            builder
                .ToTable("LenderMatrices")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
