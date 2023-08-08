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
        public DbSet<LenderMatrix> LenderMatrices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User_Role> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role_Permission> RolePermissions { get; set; }
        public DbSet<UserVerificationAndReset> UserVerificationAndReset { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);

            // CompanyTypes
            var soleProprietorship = new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.SoleProprietorship };
            var other = new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.Other };
            var partnershipLimitedByShares = new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.PartnershipLimitedByShares };
            var limitedPartnership = new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.LimitedPartnership };
            var cooperativeSociety = new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.CooperativeSociety };
            var generalPartnership = new CompanyType { Id = Guid.NewGuid(), Type = CompanyTypeSeeds.GeneralPartnership };

            // Permissions
            var canReadBorrowers = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanReadBorrowers };
            var canReadOwnBorrowers = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanReadOwnBorrowers };
            var isSuperAdmin = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.IsSuperAdmin };
            var isRegistered = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.IsRegistered };
            var canAddBorrower = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanAddBorrower };
            var canUpdateBorrower = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanUpdateBorrower };
            var canDeleteBorrower = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanDeleteBorrower };
            var canReadApplications = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanReadApplications };
            var canReadOwnApplications = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanReadOwnApplications };
            var canAddApplication = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanAddApplication };
            var canUpdateApplication = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanUpdateApplication };
            var canDeleteApplication = new Permission { Id = Guid.NewGuid(), Name = PermissionSeeds.CanDeleteApplication };

            // Roles
            var superAdmin = new Role { Id = Guid.NewGuid(), Name = RoleSeeds.SuperAdmin };
            var loanOfficer = new Role { Id = Guid.NewGuid(), Name = RoleSeeds.LoanOfficer };
            var registeredUser = new Role { Id = Guid.NewGuid(), Name = RoleSeeds.RegisteredUser };
            var borrower = new Role { Id = Guid.NewGuid(), Name = RoleSeeds.Borrower };

            // Products
            var fixedRatePreAmortization = new Product {
                Id = Guid.NewGuid(),
                Name = ProductSeeds.FixedRatePreAmortization,
                Description = ProductSeeds.FixedRatePreAmortization,
                ReferenceRate = 0.0025M,
                FinanceMinAmount = 10000.00M,
                FinanceMaxAmount = 2000000.00M,
            };
            var variableRatePreAmortization = new Product {
                Id = Guid.NewGuid(),
                Name = ProductSeeds.VariableRatePreAmortization,
                Description = ProductSeeds.VariableRatePreAmortization,
                ReferenceRate = 0.03M,
                FinanceMinAmount = 10000.00M,
                FinanceMaxAmount = 2000000.00M,
            };

            // Users
            var sa = new User {
                Id = Guid.NewGuid(),
                FirstName = "Kevin",
                LastName = "Shemili",
                Username = "kevinshemili1",
                Email = "kevin.shemili@cardoai.com",
                IsEmailConfirmed = true,
                PhoneNumber = "683363203",
                Prefix = "+355",
                PasswordHash = "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=",
                PasswordSalt = "jWRLoRafDBcFS72uPEqyqg=="
            };

            // Lenders
            var pmiBtech = new Lender {
                Id = Guid.NewGuid(),
                Name = "PMI BTECH",
                RequestedAmount = 100000,
                BorrowerCompanyType = CompanyTypeSeeds.CooperativeSociety,
                MinTenor = 30,
                MaxTenor = 0
            };
            var azif = new Lender {
                Id = Guid.NewGuid(),
                Name = "AZIF",
                RequestedAmount = 400000,
                BorrowerCompanyType = CompanyTypeSeeds.PartnershipLimitedByShares,
                MinTenor = 40,
                MaxTenor = 60
            };
            var logitech = new Lender {
                Id = Guid.NewGuid(),
                Name = "PMI BTECH",
                RequestedAmount = 100000,
                BorrowerCompanyType = CompanyTypeSeeds.SoleProprietorship,
                MinTenor = 30,
                MaxTenor = 60
            };

            // Seeds
            modelBuilder.Entity<CompanyType>().HasData(
                soleProprietorship,
                other,
                partnershipLimitedByShares,
                limitedPartnership,
                cooperativeSociety,
                generalPartnership
            );

            modelBuilder.Entity<Permission>().HasData(
                isSuperAdmin,
                canReadBorrowers,
                isRegistered,
                canAddBorrower,
                canUpdateBorrower,
                canDeleteBorrower,
                canReadApplications,
                canUpdateApplication,
                canAddApplication,
                canDeleteApplication,
                canReadOwnApplications,
                canReadOwnBorrowers
            );

            modelBuilder.Entity<Role>().HasData(
                superAdmin,
                loanOfficer,
                registeredUser,
                borrower
            );

            modelBuilder.Entity<User>().HasData(
                sa
             );

            modelBuilder.Entity<Product>().HasData(
                fixedRatePreAmortization,
                variableRatePreAmortization
            );

            modelBuilder.Entity<Lender>().HasData(
                pmiBtech,
                azif,
                logitech
            );

            modelBuilder.Entity<User_Role>().HasData(
                new User_Role {
                    UserId = sa.Id,
                    RoleId = superAdmin.Id
                }
            );

            modelBuilder.Entity<Role_Permission>().HasData(
                new Role_Permission {
                    RoleId = superAdmin.Id,
                    PermissionId = isSuperAdmin.Id
                },
                new Role_Permission {
                    RoleId = borrower.Id,
                    PermissionId = canReadOwnBorrowers.Id,
                },
                new Role_Permission {
                    RoleId = borrower.Id,
                    PermissionId = canAddBorrower.Id,
                },
                new Role_Permission {
                    RoleId = borrower.Id,
                    PermissionId = canDeleteBorrower.Id,
                },
                new Role_Permission {
                    RoleId = borrower.Id,
                    PermissionId = canUpdateBorrower.Id,
                },
                new Role_Permission {
                    RoleId = borrower.Id,
                    PermissionId = canAddApplication.Id,
                },
                new Role_Permission {
                    RoleId = borrower.Id,
                    PermissionId = canReadOwnApplications.Id,
                },
                new Role_Permission {
                    RoleId = borrower.Id,
                    PermissionId = canDeleteApplication.Id,
                },
                new Role_Permission {
                    RoleId = registeredUser.Id,
                    PermissionId = isRegistered.Id,
                },
                new Role_Permission {
                    RoleId = registeredUser.Id,
                    PermissionId = canAddBorrower.Id,
                },
                new Role_Permission {
                    RoleId = loanOfficer.Id,
                    PermissionId = canUpdateApplication.Id,
                },
                new Role_Permission {
                    RoleId = loanOfficer.Id,
                    PermissionId = canReadApplications.Id,
                },
                new Role_Permission {
                    RoleId = loanOfficer.Id,
                    PermissionId = canReadBorrowers.Id,
                }
            );
        }
    }
}
