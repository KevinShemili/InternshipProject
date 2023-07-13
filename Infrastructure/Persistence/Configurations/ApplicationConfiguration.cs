using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class ApplicationConfiguration : IEntityTypeConfiguration<ApplicationEntity> {
        public void Configure(EntityTypeBuilder<ApplicationEntity> builder) {
            builder
                .ToTable("Applications")
                .HasKey(x => x.ApplicationId);

            builder
                .HasOne(x => x.Product)
                .WithOne(y => y.Application)
                .HasForeignKey<ApplicationEntity>(x => x.ProductId)
                .IsRequired(true);

            builder
                .HasOne(x => x.Loan)
                .WithOne(y => y.Application)
                .HasForeignKey<ApplicationEntity>(x => x.LoanId)
                .IsRequired(false);
        }
    }
}
