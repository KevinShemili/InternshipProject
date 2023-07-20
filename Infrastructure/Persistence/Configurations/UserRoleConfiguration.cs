using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class UserRoleConfiguration : IEntityTypeConfiguration<User_Role> {
        public void Configure(EntityTypeBuilder<User_Role> builder) {
            builder
                .ToTable("UserRoles")
                .HasKey(x => new { x.UserId, x.RoleId });

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<User_Role> builder) {
            builder.HasData(new User_Role {
                UserId = Guid.Parse("0f7195df-de82-429c-a430-dc0742edf721"),
                RoleId = Guid.Parse("6b8f8ee8-d394-487a-847a-cd9e40df4fcf")
            });
        }
    }
}
