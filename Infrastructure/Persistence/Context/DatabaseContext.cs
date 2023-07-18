using Domain.Entities;
using Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<User_Role> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role_Permission> RolePermissions { get; set; }
        public DbSet<UserVerificationAndReset> UserVerificationAndReset { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
