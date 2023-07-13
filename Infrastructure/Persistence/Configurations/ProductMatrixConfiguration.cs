using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class ProductMatrixConfiguration : IEntityTypeConfiguration<ProductMatrix> {
        public void Configure(EntityTypeBuilder<ProductMatrix> builder) {
            builder
                .ToTable("ProductMatrices")
                .HasKey(x => x.FileId);

            builder
                .HasOne(x => x.Application)
                .WithOne(y => y.ProductMatrix)
                .HasForeignKey<ProductMatrix>(x => x.ApplicationId)
                .IsRequired(false);
        }
    }
}
