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
                    b.Property<Guid>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BorrowerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FinancePurposeDefinition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RequestedAmount")
                        .HasColumnType("int");

                    b.Property<int>("RequestedTenor")
                        .HasColumnType("int");

                    b.HasKey("ApplicationId");

                    b.HasIndex("BorrowerId")
                        .IsUnique();

                    b.HasIndex("FileId")
                        .IsUnique();

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Applications", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Borrower", b =>
                {
                    b.Property<Guid>("BorrowedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FiscalCode")
                        .HasColumnType("int");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VATNumber")
                        .HasColumnType("int");

                    b.HasKey("BorrowedId");

                    b.HasIndex("CompanyTypeId")
                        .IsUnique();

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Borrowers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CompanyProfile", b =>
                {
                    b.Property<Guid>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinnhubIndustry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MarketCapitalization")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ShareOutstanding")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileId");

                    b.ToTable("CompanyProfiles", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CompanyType", b =>
                {
                    b.Property<Guid>("CompanyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyTypeId");

                    b.ToTable("CompanyTypes", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Lender", b =>
                {
                    b.Property<Guid>("LenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BorrowerCompanyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestedAmount")
                        .HasColumnType("int");

                    b.Property<int>("Tenor")
                        .HasColumnType("int");

                    b.HasKey("LenderId");

                    b.ToTable("Lenders", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.Property<Guid>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("LenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ReferenceRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RequestedAmount")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tenor")
                        .HasColumnType("int");

                    b.HasKey("LoanId");

                    b.HasIndex("ApplicationId")
                        .IsUnique();

                    b.HasIndex("LenderId");

                    b.ToTable("Loans", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Permission", b =>
                {
                    b.Property<Guid>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FinanceMaxAmount")
                        .HasColumnType("int");

                    b.Property<int>("FinanceMinAmount")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ReferenceRate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ProductMatrix", b =>
                {
                    b.Property<Guid>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FileId");

                    b.ToTable("ProductMatrices", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Roles_Permission", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("PermissionId")
                        .IsUnique();

                    b.HasIndex("RoleId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Roles_Permissions", (string)null);
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

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

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

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ApplicationEntity", b =>
                {
                    b.HasOne("Domain.Entities.Borrower", "Borrower")
                        .WithOne("Application")
                        .HasForeignKey("Domain.Entities.ApplicationEntity", "BorrowerId");

                    b.HasOne("Domain.Entities.ProductMatrix", "ProductMatrix")
                        .WithOne("Application")
                        .HasForeignKey("Domain.Entities.ApplicationEntity", "FileId");

                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithOne("Application")
                        .HasForeignKey("Domain.Entities.ApplicationEntity", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Borrower");

                    b.Navigation("Product");

                    b.Navigation("ProductMatrix");
                });

            modelBuilder.Entity("Domain.Entities.Borrower", b =>
                {
                    b.HasOne("Domain.Entities.CompanyType", "CompanyType")
                        .WithOne("Borrower")
                        .HasForeignKey("Domain.Entities.Borrower", "CompanyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.CompanyProfile", "CompanyProfile")
                        .WithOne("Borrower")
                        .HasForeignKey("Domain.Entities.Borrower", "ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Borrowers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyProfile");

                    b.Navigation("CompanyType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.HasOne("Domain.Entities.ApplicationEntity", "Application")
                        .WithOne("Loan")
                        .HasForeignKey("Domain.Entities.Loan", "ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Lender", "Lender")
                        .WithMany("Loans")
                        .HasForeignKey("LenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");

                    b.Navigation("Lender");
                });

            modelBuilder.Entity("Domain.Entities.Roles_Permission", b =>
                {
                    b.HasOne("Domain.Entities.Permission", "Permission")
                        .WithOne("RolesPermissions")
                        .HasForeignKey("Domain.Entities.Roles_Permission", "PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Role", "Role")
                        .WithOne("RolesPermissions")
                        .HasForeignKey("Domain.Entities.Roles_Permission", "RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithOne("RolesPermissions")
                        .HasForeignKey("Domain.Entities.Roles_Permission", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.ApplicationEntity", b =>
                {
                    b.Navigation("Loan")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Borrower", b =>
                {
                    b.Navigation("Application");
                });

            modelBuilder.Entity("Domain.Entities.CompanyProfile", b =>
                {
                    b.Navigation("Borrower")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.CompanyType", b =>
                {
                    b.Navigation("Borrower")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Lender", b =>
                {
                    b.Navigation("Loans");
                });

            modelBuilder.Entity("Domain.Entities.Permission", b =>
                {
                    b.Navigation("RolesPermissions")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Navigation("Application")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.ProductMatrix", b =>
                {
                    b.Navigation("Application")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Navigation("RolesPermissions")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Borrowers");

                    b.Navigation("RolesPermissions")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
