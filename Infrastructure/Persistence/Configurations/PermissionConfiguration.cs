using Domain.Entities;
using Domain.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission> {
        public void Configure(EntityTypeBuilder<Permission> builder) {
            builder
                .ToTable("Permissions")
                .HasKey(x => x.Id);

            builder
                .HasAlternateKey(x => x.Name);

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
            builder.HasData(new Permission { Id = Guid.Parse("445248ae-bc8b-4a7e-90ce-1636f8206fa5"), Name = Permissions.IsSuperAdmin });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.IsRegistered });

            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanReadBorrowers });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanAddBorrower });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanUpdateBorrower });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanDeleteBorrower });

            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanReadUsers });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanAddUser });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanUpdateUser });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanDeleteUser });

            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanReadApplications });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanAddApplication });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanUpdateApplication });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanDeleteApplication });

            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanReadLenders });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanAddLender });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanUpdateLender });
            builder.HasData(new Permission { Id = Guid.NewGuid(), Name = Permissions.CanDeleteLender });
        }
    }
}
