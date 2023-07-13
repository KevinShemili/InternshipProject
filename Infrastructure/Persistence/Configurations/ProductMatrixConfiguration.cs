using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class ProductMatrixConfiguration : IEntityTypeConfiguration<ProductMatrix> {
        public void Configure(EntityTypeBuilder<ProductMatrix> builder) {
            builder
                .ToTable("ProductMatrices")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasOne(x => x.Application)
                .WithOne(y => y.ProductMatrix)
                .HasForeignKey<ProductMatrix>(x => x.ApplicationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
