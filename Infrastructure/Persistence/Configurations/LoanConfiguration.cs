using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class LoanConfiguration : IEntityTypeConfiguration<Loan> {
        public void Configure(EntityTypeBuilder<Loan> builder) {
            builder
                .ToTable("Loans")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.RequestedAmount)
                .IsRequired();

            builder
                .Property(x => x.ReferenceRate)
                .HasPrecision(18, 4)
                .IsRequired();

            builder
                .Property(x => x.InterestRate)
                .HasPrecision(18, 4)
                .IsRequired();

            builder
                .Property(x => x.Tenor)
                .IsRequired();

            builder
                .Property(x => x.Status)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasOne(x => x.Lender)
                .WithMany(y => y.Loans)
                .HasForeignKey(x => x.LenderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
