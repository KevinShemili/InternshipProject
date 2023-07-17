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
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanReadBorrowers });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanAddBorrower });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanUpdateBorrower });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanDeleteBorrower });

            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanReadUsers });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanAddUser });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanUpdateUser });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanDeleteUser });

        }
    }
}
