using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class LenderConfiguration : IEntityTypeConfiguration<Lender> {
        public void Configure(EntityTypeBuilder<Lender> builder) {
            builder
                .ToTable("Lenders")
                .HasKey(x => x.LenderId);
        }
    }
}
