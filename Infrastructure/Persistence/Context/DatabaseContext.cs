using Domain.Entities;
using Domain.Seeds;
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

            modelBuilder.Entity<CompanyType>().HasData(
                new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.SoleProprietorship },
                new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.Other },
                new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.PartnershipLimitedByShares },
                new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.LimitedPartnership },
                new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.CooperativeSociety },
                new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.GeneralPartnership }
            );

            modelBuilder.Entity<Permission>().HasData(
                new Permission { Id = Guid.Parse("445248ae-bc8b-4a7e-90ce-1636f8206fa5"), Name = PermissionSeeds.IsSuperAdmin },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.IsRegistered },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanReadBorrowers },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanAddBorrower },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanUpdateBorrower },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanDeleteBorrower },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanReadUsers },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanAddUser },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanUpdateUser },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanDeleteUser },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanReadApplications },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanAddApplication },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanUpdateApplication },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanDeleteApplication },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanReadLenders },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanAddLender },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanUpdateLender },
                new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanDeleteLender }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = Guid.Parse("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"), Name = RoleSeeds.SuperAdmin },
                new Role { Id = Guid.NewGuid(), Name = RoleSeeds.LoanOfficerBackOffice },
                new Role { Id = Guid.NewGuid(), Name = RoleSeeds.LoanOfficerFrontOffice },
                new Role { Id = Guid.NewGuid(), Name = RoleSeeds.Borrower },
                new Role { Id = Guid.NewGuid(), Name = RoleSeeds.RegisteredUser }
            );

            modelBuilder.Entity<Role_Permission>().HasData(
                new Role_Permission {
                    RoleId = Guid.Parse("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"),
                    PermissionId = Guid.Parse("445248ae-bc8b-4a7e-90ce-1636f8206fa5")
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User {
                    Id = Guid.Parse("0f7195df-de82-429c-a430-dc0742edf721"),
                    FirstName = "Kevin",
                    LastName = "Shemili",
                    Username = "kevinshemili1",
                    Email = "kevin.shemili@cardoai.com",
                    IsEmailConfirmed = true,
                    PhoneNumber = "683363203",
                    Prefix = "+355",
                    PasswordHash = "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=",
                    PasswordSalt = "jWRLoRafDBcFS72uPEqyqg=="
                }
             );

            modelBuilder.Entity<User_Role>().HasData(
                new User_Role {
                    UserId = Guid.Parse("0f7195df-de82-429c-a430-dc0742edf721"),
                    RoleId = Guid.Parse("6b8f8ee8-d394-487a-847a-cd9e40df4fcf")
                }
            );
        }
    }
}
