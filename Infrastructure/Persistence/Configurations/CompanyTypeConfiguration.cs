using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class CompanyTypeConfiguration : IEntityTypeConfiguration<CompanyType> {
        public void Configure(EntityTypeBuilder<CompanyType> builder) {
            builder
                .ToTable("CompanyTypes")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Type)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.Description)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasOne(x => x.Borrower)
                .WithOne(y => y.CompanyType)
                .HasForeignKey<CompanyType>(x => x.BorrowerId)
                .IsRequired();
        }
    }
}
