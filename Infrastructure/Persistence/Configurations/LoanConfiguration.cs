using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class LoanConfiguration : IEntityTypeConfiguration<Loan> {
        public void Configure(EntityTypeBuilder<Loan> builder) {
            builder
                .ToTable("Loans")
                .HasKey(x => x.LoanId);

            builder
                .HasOne(x => x.Lender)
                .WithMany(y => y.Loans)
                .HasForeignKey(x => x.LenderId);
        }
    }
}
