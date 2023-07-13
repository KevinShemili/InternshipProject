using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class LenderConfiguration : IEntityTypeConfiguration<Lender> {
        public void Configure(EntityTypeBuilder<Lender> builder) {
            builder
                .ToTable("Lenders")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.RequestedAmount)
                .IsRequired();

            builder
                .Property(x => x.Tenor)
                .IsRequired();

            builder
                .Property(x => x.BorrowerCompanyType)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasMany(x => x.Loans)
                .WithOne(y => y.Lender)
                .IsRequired(false);
        }
    }
}
