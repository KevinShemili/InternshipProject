﻿// <auto-generated />
using System;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.ApplicationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BorrowerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FinancePurposeDefinition")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("LoanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RequestedAmount")
                        .HasColumnType("int");

                    b.Property<int>("RequestedTenor")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BorrowerId");

                    b.HasIndex("LoanId")
                        .IsUnique();

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Applications", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Borrower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("CompanyTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FiscalCode")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VATNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Borrowers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CompanyProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BorrowerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Exchange")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FinnhubIndustry")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IPO")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MarketCapitalization")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ShareOutstanding")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WebUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("BorrowerId")
                        .IsUnique();

                    b.ToTable("CompanyProfiles", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CompanyType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Type");

                    b.ToTable("CompanyTypes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e6a8c08-5aee-42ce-abef-8ddf8750606d"),
                            Type = "Sole Proprietorship"
                        },
                        new
                        {
                            Id = new Guid("075546d9-568b-4868-8020-962366a2ffb2"),
                            Type = "Other"
                        },
                        new
                        {
                            Id = new Guid("318c7b04-63b0-41d3-a9dc-8b317e623fd6"),
                            Type = "Partnership Limited by Shares"
                        },
                        new
                        {
                            Id = new Guid("9d219820-d5de-4f99-8c80-4571f4ca0d1b"),
                            Type = "Limited Partnership"
                        },
                        new
                        {
                            Id = new Guid("fa7b3cc2-8657-4fd8-ab59-15335482a8d8"),
                            Type = "Cooperative Society"
                        },
                        new
                        {
                            Id = new Guid("e61543fb-89eb-4f03-b8a3-17c62fdf4421"),
                            Type = "General Partnership"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Lender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BorrowerCompanyType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RequestedAmount")
                        .HasColumnType("int");

                    b.Property<int>("Tenor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lenders", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("InterestRate")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<Guid>("LenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ReferenceRate")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("RequestedAmount")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Tenor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LenderId");

                    b.ToTable("Loans", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.ToTable("Permissions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("445248ae-bc8b-4a7e-90ce-1636f8206fa5"),
                            Name = "IsSuperAdmin"
                        },
                        new
                        {
                            Id = new Guid("116183f9-b584-4b9f-9972-f912d32e9511"),
                            Name = "IsRegistered"
                        },
                        new
                        {
                            Id = new Guid("40ea2f82-f467-4ec5-b4b0-42b6091017b4"),
                            Name = "CanReadBorrowers"
                        },
                        new
                        {
                            Id = new Guid("f6275f8f-dbc5-4bc1-b815-cfd659d5cce0"),
                            Name = "CanAddBorrower"
                        },
                        new
                        {
                            Id = new Guid("b71d86b8-ccd1-40ab-a8ff-22e088e9f2e8"),
                            Name = "CanUpdateBorrower"
                        },
                        new
                        {
                            Id = new Guid("bd08e19f-e5e6-4bfd-838d-d9165add8195"),
                            Name = "CanDeleteBorrower"
                        },
                        new
                        {
                            Id = new Guid("b5cd47b0-2bf9-460e-bddb-4f91d9ddece7"),
                            Name = "CanReadUsers"
                        },
                        new
                        {
                            Id = new Guid("8f43ad05-2377-4362-a52b-3594eed399e4"),
                            Name = "CanAddUser"
                        },
                        new
                        {
                            Id = new Guid("d45627e4-340b-45d2-93f7-78f9761191db"),
                            Name = "CanUpdateUser"
                        },
                        new
                        {
                            Id = new Guid("ff4f125c-a10d-4949-bc34-3a665d384f72"),
                            Name = "CanDeleteUser"
                        },
                        new
                        {
                            Id = new Guid("bad8a841-4be5-4d54-b37b-b4c1a7436283"),
                            Name = "CanReadApplications"
                        },
                        new
                        {
                            Id = new Guid("3a1ab1af-718d-41ed-beab-208c4f556fdc"),
                            Name = "CanAddApplication"
                        },
                        new
                        {
                            Id = new Guid("9ff1851e-3bb7-495b-879d-376d5327cefa"),
                            Name = "CanUpdateApplication"
                        },
                        new
                        {
                            Id = new Guid("efc01d57-a50d-433e-9f50-3fc4b5aa82f8"),
                            Name = "CanDeleteApplication"
                        },
                        new
                        {
                            Id = new Guid("82373667-c6ac-4405-ac39-0ed1b7968410"),
                            Name = "CanReadLenders"
                        },
                        new
                        {
                            Id = new Guid("99e2abb5-c7e0-4342-87a3-5394a48dced6"),
                            Name = "CanAddLender"
                        },
                        new
                        {
                            Id = new Guid("e20b1636-6c73-4a2c-8dc0-dbc9454a2512"),
                            Name = "CanUpdateLender"
                        },
                        new
                        {
                            Id = new Guid("84aff3e1-a115-4389-a8ea-428b0cab288f"),
                            Name = "CanDeleteLender"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("FinanceMaxAmount")
                        .HasColumnType("int");

                    b.Property<int>("FinanceMinAmount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ReferenceRate")
                        .HasMaxLength(50)
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ProductMatrix", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId")
                        .IsUnique();

                    b.ToTable("ProductMatrices", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"),
                            Name = "SuperAdmin"
                        },
                        new
                        {
                            Id = new Guid("73729c43-5579-41ba-9b8e-a0a7556c23a4"),
                            Name = "LoanOfficerBackOffice"
                        },
                        new
                        {
                            Id = new Guid("31ccc2fd-4ad6-4eb9-b866-29affa5f6871"),
                            Name = "LoanOfficerFrontOffice"
                        },
                        new
                        {
                            Id = new Guid("d54387af-9647-4c1e-b6f1-d6643bfb5251"),
                            Name = "Borrower"
                        },
                        new
                        {
                            Id = new Guid("5aaf3a16-3598-44cb-ae16-4ba3193da1e6"),
                            Name = "RegisteredUser"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Role_Permission", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermissions", (string)null);

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"),
                            PermissionId = new Guid("445248ae-bc8b-4a7e-90ce-1636f8206fa5")
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LoginTries")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Username");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0f7195df-de82-429c-a430-dc0742edf721"),
                            Email = "kevin.shemili@cardoai.com",
                            FirstName = "Kevin",
                            IsBlocked = false,
                            IsEmailConfirmed = true,
                            LastName = "Shemili",
                            LoginTries = 0,
                            PasswordHash = "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=",
                            PasswordSalt = "jWRLoRafDBcFS72uPEqyqg==",
                            PhoneNumber = "683363203",
                            Prefix = "+355",
                            Username = "kevinshemili1"
                        });
                });

            modelBuilder.Entity("Domain.Entities.UserVerificationAndReset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailVerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmailVerificationTokenExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PasswordResetTokenExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("UserEmail")
                        .IsUnique();

                    b.ToTable("UserVerificationAndReset", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User_Role", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("0f7195df-de82-429c-a430-dc0742edf721"),
                            RoleId = new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf")
                        });
                });

            modelBuilder.Entity("Domain.Entities.ApplicationEntity", b =>
                {
                    b.HasOne("Domain.Entities.Borrower", "Borrower")
                        .WithMany("Applications")
                        .HasForeignKey("BorrowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Loan", "Loan")
                        .WithOne("Application")
                        .HasForeignKey("Domain.Entities.ApplicationEntity", "LoanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithOne("Application")
                        .HasForeignKey("Domain.Entities.ApplicationEntity", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Borrower");

                    b.Navigation("Loan");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Entities.Borrower", b =>
                {
                    b.HasOne("Domain.Entities.CompanyType", "CompanyType")
                        .WithMany("Borrowers")
                        .HasForeignKey("CompanyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Borrowers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.CompanyProfile", b =>
                {
                    b.HasOne("Domain.Entities.Borrower", "Borrower")
                        .WithOne("CompanyProfile")
                        .HasForeignKey("Domain.Entities.CompanyProfile", "BorrowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Borrower");
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.HasOne("Domain.Entities.Lender", "Lender")
                        .WithMany("Loans")
                        .HasForeignKey("LenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lender");
                });

            modelBuilder.Entity("Domain.Entities.ProductMatrix", b =>
                {
                    b.HasOne("Domain.Entities.ApplicationEntity", "Application")
                        .WithOne("ProductMatrix")
                        .HasForeignKey("Domain.Entities.ProductMatrix", "ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("Domain.Entities.Role_Permission", b =>
                {
                    b.HasOne("Domain.Entities.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.UserVerificationAndReset", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithOne("UserVerificationAndReset")
                        .HasForeignKey("Domain.Entities.UserVerificationAndReset", "UserEmail")
                        .HasPrincipalKey("Domain.Entities.User", "Email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.User_Role", b =>
                {
                    b.HasOne("Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.ApplicationEntity", b =>
                {
                    b.Navigation("ProductMatrix");
                });

            modelBuilder.Entity("Domain.Entities.Borrower", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("CompanyProfile")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.CompanyType", b =>
                {
                    b.Navigation("Borrowers");
                });

            modelBuilder.Entity("Domain.Entities.Lender", b =>
                {
                    b.Navigation("Loans");
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.Navigation("Application")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Navigation("Application")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Borrowers");

                    b.Navigation("UserVerificationAndReset")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
