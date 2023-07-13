using Azure;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Hosting;

namespace Infrastructure.Persistence.Configurations {
    public class UserConfiguration : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> builder) {
            builder
                .ToTable("Users")
                .HasKey(user => user.Id);

            builder
                .Property(user => user.FirstName)
                .HasMaxLength(50);

            builder
                .Property(user => user.LastName)
                .HasMaxLength(50);

            builder
                .Property(user => user.Username)
                .HasMaxLength(50);

            builder
                .Property(user => user.Email)
                .HasMaxLength(150);

            builder     
                .Property(user => user.PhoneNumber)
                .HasMaxLength(20);

            builder
                .Property(user => user.Prefix)
                .HasMaxLength(5);

            builder
                .Property(user => user.PasswordHash)
                .HasMaxLength(255);

            builder
                .Property(user => user.PasswordSalt)
                .HasMaxLength(20);

            builder
                .HasMany(x => x.Roles)
                .WithMany(y => y.Users)
                .UsingEntity<User_Role>();
        }
    }
}
