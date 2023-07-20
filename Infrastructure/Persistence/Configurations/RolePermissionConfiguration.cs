using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class RolePermissionConfiguration : IEntityTypeConfiguration<Role_Permission> {
        public void Configure(EntityTypeBuilder<Role_Permission> builder) {
            builder
                .ToTable("RolePermissions")
                .HasKey(x => new { x.RoleId, x.PermissionId });

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<Role_Permission> builder) {
            builder.HasData(new Role_Permission {
                RoleId = Guid.Parse("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"),
                PermissionId = Guid.Parse("445248ae-bc8b-4a7e-90ce-1636f8206fa5")
            });
        }
    }
}
