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
        public DbSet<ApplicationStatus> ApplicationStatuses { get; set; }
        public DbSet<LoanStatus> LoanStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);

            #region entities
            // CompanyTypes
            var soleProprietorship = new CompanyType {
                Id = DefinedCompanyTypes.SoleProprietorship.Id,
                Type = DefinedCompanyTypes.SoleProprietorship.Name,
                Description = DefinedCompanyTypes.SoleProprietorship.Description
            };
            var other = new CompanyType {
                Id = DefinedCompanyTypes.Other.Id,
                Type = DefinedCompanyTypes.Other.Name,
                Description = DefinedCompanyTypes.Other.Description
            };
            var partnershipLimitedByShares = new CompanyType {
                Id = DefinedCompanyTypes.PartnershipLimitedByShares.Id,
                Type = DefinedCompanyTypes.PartnershipLimitedByShares.Name,
                Description = DefinedCompanyTypes.PartnershipLimitedByShares.Description
            };
            var limitedPartnership = new CompanyType {
                Id = DefinedCompanyTypes.LimitedPartnership.Id,
                Type = DefinedCompanyTypes.LimitedPartnership.Name,
                Description = DefinedCompanyTypes.LimitedPartnership.Description
            };
            var cooperativeSociety = new CompanyType {
                Id = DefinedCompanyTypes.CooperativeSociety.Id,
                Type = DefinedCompanyTypes.CooperativeSociety.Name,
                Description = DefinedCompanyTypes.CooperativeSociety.Description
            };
            var generalPartnership = new CompanyType {
                Id = DefinedCompanyTypes.GeneralPartnership.Id,
                Type = DefinedCompanyTypes.GeneralPartnership.Name,
                Description = DefinedCompanyTypes.GeneralPartnership.Description
            };

            // Permissions
            var canReadBorrowers = new Permission {
                Id = DefinedPermissions.CanReadBorrowers.Id,
                Name = DefinedPermissions.CanReadBorrowers.Name
            };
            var canReadOwnBorrowers = new Permission {
                Id = DefinedPermissions.CanReadOwnBorrowers.Id,
                Name = DefinedPermissions.CanReadOwnBorrowers.Name
            };
            var canUpdateBorrower = new Permission {
                Id = DefinedPermissions.CanUpdateBorrower.Id,
                Name = DefinedPermissions.CanUpdateBorrower.Name
            };
            var canAddBorrower = new Permission {
                Id = DefinedPermissions.CanAddBorrower.Id,
                Name = DefinedPermissions.CanAddBorrower.Name
            };

            var isSuperAdmin = new Permission {
                Id = DefinedPermissions.IsSuperAdmin.Id,
                Name = DefinedPermissions.IsSuperAdmin.Name
            };
            var isRegistered = new Permission {
                Id = DefinedPermissions.IsRegistered.Id,
                Name = DefinedPermissions.IsRegistered.Name
            };

            var canReadApplications = new Permission {
                Id = DefinedPermissions.CanReadApplications.Id,
                Name = DefinedPermissions.CanReadApplications.Name
            };
            var canReadOwnApplications = new Permission {
                Id = DefinedPermissions.CanReadOwnApplications.Id,
                Name = DefinedPermissions.CanReadOwnApplications.Name
            };
            var canAddApplication = new Permission {
                Id = DefinedPermissions.CanAddApplication.Id,
                Name = DefinedPermissions.CanAddApplication.Name
            };
            var canUpdateApplication = new Permission {
                Id = DefinedPermissions.CanUpdateApplication.Id,
                Name = DefinedPermissions.CanUpdateApplication.Name
            };

            var canGenerateMatrix = new Permission {
                Id = DefinedPermissions.CanGenerateMatrix.Id,
                Name = DefinedPermissions.CanGenerateMatrix.Name
            };
            var canCreateMatrix = new Permission {
                Id = DefinedPermissions.CanCreateMatrix.Id,
                Name = DefinedPermissions.CanCreateMatrix.Name
            };

            var canAddLoan = new Permission {
                Id = DefinedPermissions.CanAddLoan.Id,
                Name = DefinedPermissions.CanAddLoan.Name
            };

            var canUpdateLoan = new Permission {
                Id = DefinedPermissions.CanUpdateLoan.Id,
                Name = DefinedPermissions.CanUpdateLoan.Name
            };

            // Roles
            var superAdmin = new Role {
                Id = DefinedRoles.SuperAdmin.Id,
                Name = DefinedRoles.SuperAdmin.Name
            };
            var loanOfficer = new Role {
                Id = DefinedRoles.LoanOfficer.Id,
                Name = DefinedRoles.LoanOfficer.Name
            };
            var registeredUser = new Role {
                Id = DefinedRoles.RegisteredUser.Id,
                Name = DefinedRoles.RegisteredUser.Name
            };
            var borrower = new Role {
                Id = DefinedRoles.Borrower.Id,
                Name = DefinedRoles.Borrower.Name
            };

            // Products
            var fixedRatePreAmortization = new Product {
                Id = DefinedProducts.FixedRatePreAmortization.Id,
                Name = DefinedProducts.FixedRatePreAmortization.Name,
                Description = DefinedProducts.FixedRatePreAmortization.Description,
                ReferenceRate = DefinedProducts.FixedRatePreAmortization.ReferenceRate,
                FinanceMinAmount = DefinedProducts.FixedRatePreAmortization.FinanceMinAmount,
                FinanceMaxAmount = DefinedProducts.FixedRatePreAmortization.FinanceMaxAmount,
            };
            var variableRatePreAmortization = new Product {
                Id = DefinedProducts.VariableRatePreAmortization.Id,
                Name = DefinedProducts.VariableRatePreAmortization.Name,
                Description = DefinedProducts.VariableRatePreAmortization.Description,
                ReferenceRate = DefinedProducts.VariableRatePreAmortization.ReferenceRate,
                FinanceMinAmount = DefinedProducts.VariableRatePreAmortization.FinanceMinAmount,
                FinanceMaxAmount = DefinedProducts.VariableRatePreAmortization.FinanceMaxAmount,
            };

            // Users
            var sa = new User {
                Id = DefinedUsers.SA.Id,
                FirstName = DefinedUsers.SA.FirstName,
                LastName = DefinedUsers.SA.LastName,
                Username = DefinedUsers.SA.Username,
                Email = DefinedUsers.SA.Email,
                IsEmailConfirmed = DefinedUsers.SA.IsEmailConfirmed,
                PhoneNumber = DefinedUsers.SA.PhoneNumber,
                Prefix = DefinedUsers.SA.Prefix,
                PasswordHash = DefinedUsers.SA.PasswordHash,
                PasswordSalt = DefinedUsers.SA.PasswordSalt,
            };

            // Lenders
            var pmiBtech = new Lender {
                Id = DefinedLenders.PmiBtech.Id,
                Name = DefinedLenders.PmiBtech.Name,
                RequestedAmount = DefinedLenders.PmiBtech.RequestedAmount,
                BorrowerCompanyType = DefinedCompanyTypes.CooperativeSociety.Name,
                MinTenor = DefinedLenders.PmiBtech.MinTenor,
                MaxTenor = DefinedLenders.PmiBtech.MaxTenor
            };
            var azif = new Lender {
                Id = DefinedLenders.Azif.Id,
                Name = DefinedLenders.Azif.Name,
                RequestedAmount = DefinedLenders.Azif.RequestedAmount,
                BorrowerCompanyType = DefinedCompanyTypes.PartnershipLimitedByShares.Name,
                MinTenor = DefinedLenders.Azif.MinTenor,
                MaxTenor = DefinedLenders.Azif.MaxTenor
            };
            var logitech = new Lender {
                Id = DefinedLenders.Logitech.Id,
                Name = DefinedLenders.Logitech.Name,
                RequestedAmount = DefinedLenders.Logitech.RequestedAmount,
                BorrowerCompanyType = DefinedCompanyTypes.SoleProprietorship.Name,
                MinTenor = DefinedLenders.Logitech.MinTenor,
                MaxTenor = DefinedLenders.Logitech.MaxTenor
            };

            // Application status
            var a_inCharge = new ApplicationStatus {
                Id = DefinedApplicationStatuses.InCharge.Id,
                Name = DefinedApplicationStatuses.InCharge.Name
            };
            var a_canceled = new ApplicationStatus {
                Id = DefinedApplicationStatuses.Canceled.Id,
                Name = DefinedApplicationStatuses.Canceled.Name
            };
            var a_defaulted = new ApplicationStatus {
                Id = DefinedApplicationStatuses.Defaulted.Id,
                Name = DefinedApplicationStatuses.Defaulted.Name
            };
            var a_disbursed = new ApplicationStatus {
                Id = DefinedApplicationStatuses.Disbursed.Id,
                Name = DefinedApplicationStatuses.Disbursed.Name
            };
            var a_guaranteed = new ApplicationStatus {
                Id = DefinedApplicationStatuses.Guaranted.Id,
                Name = DefinedApplicationStatuses.Guaranted.Name
            };
            var a_rejected = new ApplicationStatus {
                Id = DefinedApplicationStatuses.Rejected.Id,
                Name = DefinedApplicationStatuses.Rejected.Name
            };
            var a_repaid = new ApplicationStatus {
                Id = DefinedApplicationStatuses.Repaid.Id,
                Name = DefinedApplicationStatuses.Repaid.Name
            };

            // Loan status
            var l_created = new LoanStatus {
                Id = DefinedLoanStatuses.Created.Id,
                Name = DefinedLoanStatuses.Created.Name
            };
            var l_erased = new LoanStatus {
                Id = DefinedLoanStatuses.Erased.Id,
                Name = DefinedLoanStatuses.Erased.Name
            };
            var l_defaulted = new LoanStatus {
                Id = DefinedLoanStatuses.Defaulted.Id,
                Name = DefinedLoanStatuses.Defaulted.Name
            };
            var l_disbursed = new LoanStatus {
                Id = DefinedLoanStatuses.Disbursed.Id,
                Name = DefinedLoanStatuses.Disbursed.Name
            };
            var l_guaranteed = new LoanStatus {
                Id = DefinedLoanStatuses.Guaranted.Id,
                Name = DefinedLoanStatuses.Guaranted.Name
            };
            var l_rejected = new LoanStatus {
                Id = DefinedLoanStatuses.Rejected.Id,
                Name = DefinedLoanStatuses.Rejected.Name
            };
            var l_repaid = new LoanStatus {
                Id = DefinedLoanStatuses.Repaid.Id,
                Name = DefinedLoanStatuses.Repaid.Name
            };
            #endregion

            #region seeds
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
                canReadApplications,
                canUpdateApplication,
                canAddApplication,
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

            modelBuilder.Entity<ApplicationStatus>().HasData(
                a_inCharge,
                a_canceled,
                a_defaulted,
                a_disbursed,
                a_guaranteed,
                a_rejected,
                a_repaid
            );

            modelBuilder.Entity<LoanStatus>().HasData(
                l_created,
                l_erased,
                l_defaulted,
                l_disbursed,
                l_guaranteed,
                l_rejected,
                l_repaid
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
            #endregion
        }
    }
}
