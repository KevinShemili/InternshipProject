using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class CompanyProfileConfiguration : IEntityTypeConfiguration<CompanyProfile> {
        public void Configure(EntityTypeBuilder<CompanyProfile> builder) {
            builder
                .ToTable("CompanyProfiles")
                .HasKey(x => x.ProfileId);

            builder
                .HasOne(x => x.Borrower)
                .WithOne(y => y.CompanyProfile)
                .HasForeignKey<CompanyProfile>(x => x.BorrowerId);
        }
    }
}
