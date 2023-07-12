using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Infrastructure.Persistence.Context {
    public class DatabaseContext : DbContext {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {

        }

        public DbSet<ApplicationEntity> Applications { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<CompanyProfile> CompanyProfiles { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Lender> Lenders { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductMatrix> ProductMatrices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Roles_Permission> Roles_Permissions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            UserConfigurations(modelBuilder);
            RolesConfigurations(modelBuilder);
            PermissionsConfigurations(modelBuilder);
            RolePermissionsConfigurations(modelBuilder);
            ApplicationConfigurations(modelBuilder);
            BorrowerConfigurations(modelBuilder);
            CompanyProfileConfigurations(modelBuilder);
            CompanyTypeConfigurations(modelBuilder);
            LenderConfigurations(modelBuilder);
            LoanConfigurations(modelBuilder);
            ProductMatricesConfigurations(modelBuilder);
            ProductsConfigurations(modelBuilder);

            PermissionsSeed(modelBuilder);
        }
        
        private void UserConfigurations(ModelBuilder builder) {
            builder.Entity<User>()
                .ToTable("Users")
                .HasKey(user => user.Id);

            builder.Entity<User>()
                .Property(user => user.FirstName)
                .HasMaxLength(50);

            builder.Entity<User>()
                .Property(user => user.LastName)
                .HasMaxLength(50);

            builder.Entity<User>()
                .Property(user => user.Username)
                .HasMaxLength(50);

            builder.Entity<User>()
                .Property(user => user.Email)
                .HasMaxLength(150);

            builder.Entity<User>()
                .Property(user => user.PhoneNumber)
                .HasMaxLength(20);

            builder.Entity<User>()
                .Property(user => user.Prefix)
                .HasMaxLength(5);

            builder.Entity<User>()
                .Property(user => user.PasswordHash)
                .HasMaxLength(255);

            builder.Entity<User>()
                .Property(user => user.PasswordSalt)
                .HasMaxLength(20);
        }

        private void ApplicationConfigurations(ModelBuilder builder) {
            builder.Entity<ApplicationEntity>()
                .ToTable("Applications")
                .HasKey(a => a.ApplicationId);

            builder.Entity<ApplicationEntity>()
                .HasOne(a => a.Borrower)
                .WithOne(b => b.Application)
                .HasForeignKey<ApplicationEntity>(a => a.BorrowerId)
                .IsRequired(false);

            builder.Entity<ApplicationEntity>()
                .HasOne(a => a.Borrower)
                .WithOne(b => b.Application)
                .HasForeignKey<ApplicationEntity>(a => a.BorrowerId)
                .IsRequired(false);

            builder.Entity<ApplicationEntity>()
                .HasOne(a => a.ProductMatrix)
                .WithOne(pm => pm.Application)
                .HasForeignKey<ApplicationEntity>(a => a.FileId)
                .IsRequired(false);

            builder.Entity<ApplicationEntity>()
                .HasOne(a => a.Product)
                .WithOne(p => p.Application)
                .HasForeignKey<ApplicationEntity>(a => a.ProductId);
        }

        private void BorrowerConfigurations(ModelBuilder builder) {
            builder.Entity<Borrower>()
                .ToTable("Borrowers")
                .HasKey(b => b.BorrowedId);

            builder.Entity<Borrower>()
                .HasOne(b => b.User)
                .WithMany(u => u.Borrowers)
                .HasForeignKey(b => b.UserId);

            builder.Entity<Borrower>()
                .HasOne(b => b.CompanyType)
                .WithOne(ct => ct.Borrower)
                .HasForeignKey<Borrower>(b => b.CompanyTypeId);

            builder.Entity<Borrower>()
                .HasOne(b => b.CompanyProfile)
                .WithOne(cp => cp.Borrower)
                .HasForeignKey<Borrower>(b => b.ProfileId);
        }

        private void CompanyProfileConfigurations(ModelBuilder builder) {
            builder.Entity<CompanyProfile>()
                .ToTable("CompanyProfiles")
                .HasKey(cp => cp.ProfileId);
        }

        private void CompanyTypeConfigurations(ModelBuilder builder) {
            builder.Entity<CompanyType>()
                .ToTable("CompanyTypes")
                .HasKey(ct => ct.CompanyTypeId);
        }

        private void LenderConfigurations(ModelBuilder builder) {
            builder.Entity<Lender>()
                .ToTable("Lenders")
                .HasKey(l => l.LenderId);              
        }

        private void LoanConfigurations(ModelBuilder builder) {
            builder.Entity<Loan>()
                .ToTable("Loans")
                .HasKey(l => l.LoanId);

            builder.Entity<Loan>()
                .HasOne(l => l.Application)
                .WithOne(a => a.Loan)
                .HasForeignKey<Loan>(a => a.ApplicationId);

            builder.Entity<Loan>()
                .HasOne(l => l.Lender)
                .WithMany(a => a.Loans)
                .HasForeignKey(a => a.LenderId);
        }

        private void PermissionsConfigurations(ModelBuilder builder) {
            builder.Entity<Permission>()
                .ToTable("Permissions")
                .HasKey(permission => permission.PermissionId);

            builder.Entity<Permission>()
                .Property(permission => permission.Name)
                .HasMaxLength(50);

            builder.Entity<Permission>()
                .Property(permission => permission.Description)
                .HasMaxLength(50)
                .IsRequired(false);
        }

        private void ProductsConfigurations(ModelBuilder builder) {
            builder.Entity<Product>()
                .ToTable("Products")
                .HasKey(p => p.ProductId);
        }

        private void ProductMatricesConfigurations(ModelBuilder builder) {
            builder.Entity<ProductMatrix>()
                .ToTable("ProductMatrices")
                .HasKey(pm => pm.FileId);
        }

        private void RolesConfigurations(ModelBuilder builder) {
            builder.Entity<Role>()
                .ToTable("Roles")
                .HasKey(role => role.RoleId);

            builder.Entity<Role>()
                .Property(role => role.RoleName)
                .HasMaxLength(50);
        }

        private void RolePermissionsConfigurations(ModelBuilder builder) {
            builder.Entity<Roles_Permission>()
                .ToTable("Roles_Permissions")
                .HasKey(rp => new { rp.UserId, rp.RoleId });

            builder.Entity<Roles_Permission>()
                .HasOne(r => r.Role)
                .WithOne(rp => rp.RolesPermissions)
                .HasForeignKey<Roles_Permission>(rp => rp.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Roles_Permission>()
                .HasOne(rp => rp.User)
                .WithOne(u => u.RolesPermissions)
                .HasForeignKey<Roles_Permission>(rp => rp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Roles_Permission>()
                .HasOne(rp => rp.Permission)
                .WithOne(p => p.RolesPermissions)
                .HasForeignKey<Roles_Permission>(rp => rp.PermissionId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private void PermissionsSeed(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Permission>().HasData(
                new Permission { PermissionId = Guid.NewGuid(), Name = "Write" },
                new Permission { PermissionId = Guid.NewGuid(), Name = "Read" },
                new Permission { PermissionId = Guid.NewGuid(), Name = "Edit" },
                new Permission { PermissionId = Guid.NewGuid(), Name = "Delete" }
            );
        }
    }
}
