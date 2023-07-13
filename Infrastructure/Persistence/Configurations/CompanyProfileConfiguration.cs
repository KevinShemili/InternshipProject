using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class CompanyProfileConfiguration : IEntityTypeConfiguration<CompanyProfile> {
        public void Configure(EntityTypeBuilder<CompanyProfile> builder) {
            builder
                .ToTable("CompanyProfiles")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Country)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.Currency)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.Exchange)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.IPO)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property (x => x.MarketCapitalization)
                .IsRequired();

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.Phone)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.ShareOutstanding)
                .HasPrecision(18, 4)
                .IsRequired();

            builder
                .Property(x => x.Ticker)
                .HasMaxLength(50)
                .IsRequired();
            
            builder
                .Property(x => x.WebUrl)
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(x => x.Logo)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.FinnhubIndustry)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasOne(x => x.Borrower)
                .WithOne(y => y.CompanyProfile)
                .HasForeignKey<CompanyProfile>(x => x.BorrowerId)
                .IsRequired();
        }
    }
}
