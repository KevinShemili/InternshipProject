using Domain.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CompanyType = Domain.Entities.CompanyType;

namespace Infrastructure.Persistence.Configurations {
    public class CompanyTypeConfiguration : IEntityTypeConfiguration<CompanyType> {
        public void Configure(EntityTypeBuilder<CompanyType> builder) {
            builder
                .ToTable("CompanyTypes")
                .HasKey(x => x.Id);

            builder
                .HasAlternateKey(x => x.Type);

            builder
                .Property(x => x.Type)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.Description)
                .HasMaxLength(100)
                .IsRequired(false);

            builder
                .HasMany(x => x.Borrowers)
                .WithOne(y => y.CompanyType)
                .IsRequired();

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<CompanyType> builder) {
            builder.HasData(new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypes.SoleProprietorship });
            builder.HasData(new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypes.Other });
            builder.HasData(new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypes.PartnershipLimitedByShares });
            builder.HasData(new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypes.LimitedPartnership });
            builder.HasData(new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypes.CooperativeSociety });
            builder.HasData(new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypes.GeneralPartnership });
        }
    }
}
