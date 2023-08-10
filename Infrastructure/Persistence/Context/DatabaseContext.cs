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

            #region entities
            // CompanyTypes
            var soleProprietorship = new CompanyType {
                Id = Guid.Parse("7DB974F8-6321-4B35-8EF4-65EDDA9FE1D6"),
                Type = CompanyTypeSeeds.SoleProprietorship
            };
            var other = new CompanyType {
                Id = Guid.Parse("A7EEA608-196C-4A52-A5C7-9694E0EB190B"),
                Type = CompanyTypeSeeds.Other
            };
            var partnershipLimitedByShares = new CompanyType {
                Id = Guid.Parse("67D5FD0E-F3A4-4AA7-BEF8-8A587BCB475E"),
                Type = CompanyTypeSeeds.PartnershipLimitedByShares
            };
            var limitedPartnership = new CompanyType {
                Id = Guid.Parse("B2B5CE14-79B1-402E-92F5-2536BCE91DDA"),
                Type = CompanyTypeSeeds.LimitedPartnership
            };
            var cooperativeSociety = new CompanyType {
                Id = Guid.Parse("BE9A7220-0773-4D4D-8EF7-B5FBF480E952"),
                Type = CompanyTypeSeeds.CooperativeSociety
            };
            var generalPartnership = new CompanyType {
                Id = Guid.Parse("AFBB07DD-70AD-471D-8448-67539B17B872"),
                Type = CompanyTypeSeeds.GeneralPartnership
            };

            // Permissions
            var canReadBorrowers = new Permission {
                Id = Guid.Parse("F2A1FBA5-A23E-4686-9C0F-3E636B1AC3E4"),
                Name = PermissionSeeds.CanReadBorrowers
            };
            var canReadOwnBorrowers = new Permission {
                Id = Guid.Parse("2C9DAD73-3625-4ECB-9522-C0F59A003E17"),
                Name = PermissionSeeds.CanReadOwnBorrowers
            };
            var canUpdateBorrower = new Permission {
                Id = Guid.Parse("96C36A8C-BE53-442D-A2F6-B2BCD71B3524"),
                Name = PermissionSeeds.CanUpdateBorrower
            };
            var canDeleteBorrower = new Permission {
                Id = Guid.Parse("537B42BD-DB04-4DB1-B4D8-C945A63116F6"),
                Name = PermissionSeeds.CanDeleteBorrower
            };
            var canAddBorrower = new Permission {
                Id = Guid.Parse("D3E011D6-53D4-46C7-8866-840593334476"),
                Name = PermissionSeeds.CanAddBorrower
            };

            var isSuperAdmin = new Permission {
                Id = Guid.Parse("FF9F62DE-AB2A-4BA2-A15D-11A1F214AC66"),
                Name = PermissionSeeds.IsSuperAdmin
            };
            var isRegistered = new Permission {
                Id = Guid.Parse("6FC1CBAF-B307-4EFA-8CA9-2CCED12A6028"),
                Name = PermissionSeeds.IsRegistered
            };

            var canReadApplications = new Permission {
                Id = Guid.Parse("4D74CE4F-B8D9-4C87-8F48-365C00DC612C"),
                Name = PermissionSeeds.CanReadApplications
            };
            var canReadOwnApplications = new Permission {
                Id = Guid.Parse("A333628C-0918-47DD-9C84-30342E0E95E3"),
                Name = PermissionSeeds.CanReadOwnApplications
            };
            var canAddApplication = new Permission {
                Id = Guid.Parse("6FE53FC9-8FDE-45F2-B3EB-F988E7ABD00D"),
                Name = PermissionSeeds.CanAddApplication
            };
            var canUpdateApplication = new Permission {
                Id = Guid.Parse("3B12B41C-CDD3-45C8-8466-31750B8D3E3C"),
                Name = PermissionSeeds.CanUpdateApplication
            };
            var canDeleteApplication = new Permission {
                Id = Guid.Parse("E12C2B57-DE8B-4191-A325-AB74C712E7DD"),
                Name = PermissionSeeds.CanDeleteApplication
            };

            var canGenerateMatrix = new Permission {
                Id = Guid.Parse("CD978177-AA39-45F5-B6A6-783B9795196C"),
                Name = PermissionSeeds.CanGenerateMatrix
            };
            var canUploadMatrix = new Permission {
                Id = Guid.Parse("2FE0991B-7A0B-4700-8F2C-036782B973BC"),
                Name = PermissionSeeds.CanUploadMatrix
            };

            var canAddLoan = new Permission {
                Id = Guid.Parse("4F29D160-B6C3-4BFF-9BAE-D1E6BE1DAC8B"),
                Name = PermissionSeeds.CanAddLoan
            };
            var canDeleteLoan = new Permission {
                Id = Guid.Parse("9ED89079-F9BF-498A-A7BA-F19AD0AC08F1"),
                Name = PermissionSeeds.CanDeleteLoan
            };
            var canUpdateLoan = new Permission {
                Id = Guid.Parse("00E181E4-0549-4EBC-8730-77C901BFE676"),
                Name = PermissionSeeds.CanUpdateLoan
            };


            // Roles
            var superAdmin = new Role {
                Id = Guid.Parse("1AFAC8E2-D840-40AA-A97F-C3F2BC5931B0"),
                Name = RoleSeeds.SuperAdmin
            };
            var loanOfficer = new Role {
                Id = Guid.Parse("D6013A21-70D7-4C08-9DE9-482F339147A8"),
                Name = RoleSeeds.LoanOfficer
            };
            var registeredUser = new Role {
                Id = Guid.Parse("846D0436-FFCE-49A2-A8FF-BF22AEDF0A83"),
                Name = RoleSeeds.RegisteredUser
            };
            var borrower = new Role {
                Id = Guid.Parse("B05D025A-62EE-4D6C-AEF4-9433CC52DCD0"),
                Name = RoleSeeds.Borrower
            };

            // Products
            var fixedRatePreAmortization = new Product {
                Id = Guid.Parse("5FF6A3BE-482E-4826-B027-B7AEA05DE030"),
                Name = ProductSeeds.FixedRatePreAmortization,
                Description = ProductSeeds.FixedRatePreAmortization,
                ReferenceRate = 0.0025M,
                FinanceMinAmount = 10000.00M,
                FinanceMaxAmount = 2000000.00M,
            };
            var variableRatePreAmortization = new Product {
                Id = Guid.Parse("B2C0E6AE-2A83-4FD3-ACCE-DD1C647B1B1C"),
                Name = ProductSeeds.VariableRatePreAmortization,
                Description = ProductSeeds.VariableRatePreAmortization,
                ReferenceRate = 0.03M,
                FinanceMinAmount = 10000.00M,
                FinanceMaxAmount = 2000000.00M,
            };

            // Users
            var sa = new User {
                Id = Guid.Parse("1B2031FF-DF77-4CE4-A2F0-00E60546F243"),
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
                Id = Guid.Parse("8D1AC5ED-0E1E-4DE1-A7FC-A7DF9E095653"),
                Name = "PMI BTECH",
                RequestedAmount = 100000,
                BorrowerCompanyType = CompanyTypeSeeds.CooperativeSociety,
                MinTenor = 30,
                MaxTenor = 65
            };
            var azif = new Lender {
                Id = Guid.Parse("7F83C404-EFEE-4900-98EE-38D3C95DAF56"),
                Name = "AZIF",
                RequestedAmount = 400000,
                BorrowerCompanyType = CompanyTypeSeeds.PartnershipLimitedByShares,
                MinTenor = 40,
                MaxTenor = 60
            };
            var logitech = new Lender {
                Id = Guid.Parse("0F3C377F-89AD-4FD6-AF55-62F783B0EA52"),
                Name = "LOGITECH",
                RequestedAmount = 100000,
                BorrowerCompanyType = CompanyTypeSeeds.SoleProprietorship,
                MinTenor = 30,
                MaxTenor = 60
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
            #endregion
        }
    }
}
