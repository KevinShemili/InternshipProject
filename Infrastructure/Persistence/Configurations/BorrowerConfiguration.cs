using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations {
    public class BorrowerConfiguration : IEntityTypeConfiguration<Borrower> {
        public void Configure(EntityTypeBuilder<Borrower> builder) {
            builder
                .ToTable("Borrowers")
                .HasKey(x => x.BorrowedId);
            
            builder
                 .HasOne(x => x.Application)
                 .WithOne(y => y.Borrower)
                 .HasForeignKey<Borrower>(x => x.ApplicationId)
                 .IsRequired(false);

            builder
                .HasOne(x => x.User)
                .WithMany(y => y.Borrowers)
                .HasForeignKey(x => x.UserId);
        }
    }
}
