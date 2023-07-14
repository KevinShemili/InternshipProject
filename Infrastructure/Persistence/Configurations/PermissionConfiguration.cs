using Domain.Entities;
using Infrastructure.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission> {
        public void Configure(EntityTypeBuilder<Permission> builder) {
            builder
                .ToTable("Permissions")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.Description)
                .HasMaxLength(100)
                .IsRequired(false);

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<Permission> builder) {

        }
    }
}
