using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class CompanyTypeConfiguration : IEntityTypeConfiguration<CompanyType> {
        public void Configure(EntityTypeBuilder<CompanyType> builder) {
            builder
                .ToTable("CompanyTypes")
                .HasKey(x => x.CompanyTypeId);

            builder
                .HasOne(x => x.Borrower)
                .WithOne(y => y.CompanyType)
                .HasForeignKey<CompanyType>(x => x.BorrowerId);
        }
    }
}
