using Domain.Entities;
using Domain.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class RoleConfigurations : IEntityTypeConfiguration<Role> {
        public void Configure(EntityTypeBuilder<Role> builder) {
            builder
                .ToTable("Roles");

            builder
                .HasKey(x => x.Id);

            builder
                .HasAlternateKey(x => x.Name);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasMany(x => x.Permissions)
                .WithMany(y => y.Roles)
                .UsingEntity<Role_Permission>();

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<Role> builder) {
            builder.HasData(new Role { Id = Guid.Parse("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"), Name = Roles.SuperAdmin });
            builder.HasData(new Role { Id = Guid.NewGuid(), Name = Roles.LoanOfficerBackOffice });
            builder.HasData(new Role { Id = Guid.NewGuid(), Name = Roles.LoanOfficerFrontOffice });
            builder.HasData(new Role { Id = Guid.NewGuid(), Name = Roles.Borrower });
            builder.HasData(new Role { Id = Guid.NewGuid(), Name = Roles.RegisteredUser });
        }
    }
}
