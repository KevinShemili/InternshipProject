using Domain.Entities;
using Infrastructure.Persistence.Seeds;
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
            builder.HasData(Guid.NewGuid(), Roles.SuperAdmin);
            builder.HasData(Guid.NewGuid(), Roles.LoanOfficerBackOffice);
            builder.HasData(Guid.NewGuid(), Roles.LoanOfficerFrontOffice);
            builder.HasData(Guid.NewGuid(), Roles.Borrower);
            builder.HasData(Guid.NewGuid(), Roles.RegisteredUser);
        }
    }
}
