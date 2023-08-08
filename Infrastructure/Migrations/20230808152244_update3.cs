using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("0b00f1d6-56df-45f6-a575-c693df004d03"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("17d747b8-7695-4fd9-8eaf-38c1930f10bd"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("282ccac5-ffb4-4d85-bd7c-bbae48b753bd"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("69421fa1-3116-49b0-80fa-5c7bdbe77e59"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7d291cfe-7319-428f-b30f-58e880021e9f"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8386f64a-8757-458a-bd73-1af1e641b1a6"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("190f3ceb-46e4-4953-84df-4bb7589fd822"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("ee142133-dc54-49b7-b1fe-07108226344b"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("ff663709-cdf4-43dd-84d9-522a7e19635a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a446505-7a64-4865-a4e8-b70342f2ec95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50f23242-e5b0-4819-9c87-1aabcd9e4fcf"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("58b90d78-677d-4404-bf67-a632499a43ee"), new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("58de110a-650b-47bd-9605-f74e539f16ab"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("d1f8563a-8afe-4539-a887-77b356c38141"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("ed0a6095-d8ab-4b15-815d-cf0b14a5ab0a"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("09f0f634-7361-4d7c-9ca2-0dc8ae4fedea"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("1dc3cd7e-3e02-4d0c-9b49-7c5e831c6718"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("346b8cc8-5c89-4695-b22c-a7ab457e5c90"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("8a042266-b542-45c4-af4e-304049986643"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("e1771e48-ea3b-4a56-93ca-02f62c5e9cbb"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("f4134d5e-1def-46f1-8615-c318141e0aaf"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("c947dc46-bc7c-407c-9ad8-e2050d24b9c7"), new Guid("f6146789-7d87-470b-bd72-45d88209f05d") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f6146789-7d87-470b-bd72-45d88209f05d"), new Guid("5a9dbbd4-8ae9-4be6-b785-f215eed29e2d") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("09f0f634-7361-4d7c-9ca2-0dc8ae4fedea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1dc3cd7e-3e02-4d0c-9b49-7c5e831c6718"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("346b8cc8-5c89-4695-b22c-a7ab457e5c90"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("58b90d78-677d-4404-bf67-a632499a43ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("58de110a-650b-47bd-9605-f74e539f16ab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8a042266-b542-45c4-af4e-304049986643"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c947dc46-bc7c-407c-9ad8-e2050d24b9c7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d1f8563a-8afe-4539-a887-77b356c38141"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e1771e48-ea3b-4a56-93ca-02f62c5e9cbb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed0a6095-d8ab-4b15-815d-cf0b14a5ab0a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f4134d5e-1def-46f1-8615-c318141e0aaf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f6146789-7d87-470b-bd72-45d88209f05d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a9dbbd4-8ae9-4be6-b785-f215eed29e2d"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "LenderMatrices");

            migrationBuilder.AddColumn<Guid>(
                name: "LenderId",
                table: "LenderMatrices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "LenderMatrices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Spread",
                table: "LenderMatrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tenor",
                table: "LenderMatrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("093a991f-5249-4a29-a585-f7388000727e"), null, "Sole Proprietorship" },
                    { new Guid("3226609e-0a60-40a2-a3c2-29a9d905bee5"), null, "Limited Partnership" },
                    { new Guid("4bce84ca-cad4-4e0c-bfcf-0cc4fa5e2c6e"), null, "General Partnership" },
                    { new Guid("8e961611-d59f-4ac7-b37e-0d43336dd920"), null, "Other" },
                    { new Guid("9c3e9ab7-e571-49d4-8774-807eeee78108"), null, "Cooperative Society" },
                    { new Guid("aebba1cb-ae33-4757-84e1-8ae00e084d00"), null, "Partnership Limited by Shares" }
                });

            migrationBuilder.InsertData(
                table: "Lenders",
                columns: new[] { "Id", "BorrowerCompanyType", "MaxTenor", "MinTenor", "Name", "RequestedAmount" },
                values: new object[,]
                {
                    { new Guid("49d70e21-6032-4dd9-bc07-a522abce16c5"), "Cooperative Society", 0, 30, "PMI BTECH", 100000 },
                    { new Guid("bfea5960-35e0-4aa0-9877-240da3336876"), "Sole Proprietorship", 60, 30, "PMI BTECH", 100000 },
                    { new Guid("fba9c0f7-3298-466e-908d-fcf1bf81e64e"), "Partnership Limited by Shares", 60, 40, "AZIF", 400000 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1de47ea6-0479-44c3-b814-61677745dc91"), null, "CanReadApplications" },
                    { new Guid("25e9445a-ae2f-4abd-a98b-7c793db99799"), null, "CanReadOwnApplications" },
                    { new Guid("3b9db73e-71c8-49ae-a1e9-feb9bc39e8f2"), null, "CanAddBorrower" },
                    { new Guid("4fa87bfe-0ff6-45c8-b4c2-3f260b2de1a7"), null, "CanAddApplication" },
                    { new Guid("8506d801-9b1e-4e8d-af74-8f571bb03409"), null, "CanUpdateApplication" },
                    { new Guid("921f5252-01a5-4fc2-9485-e83a0aa54400"), null, "IsSuperAdmin" },
                    { new Guid("92e836aa-536a-43a5-8112-7e77fbd99fd5"), null, "CanDeleteBorrower" },
                    { new Guid("bf7339ca-bc33-4f6d-9926-07ab5f7a32e7"), null, "CanReadBorrowers" },
                    { new Guid("e4d2a042-a495-4715-b148-02c9d2422d0b"), null, "CanUpdateBorrower" },
                    { new Guid("e7bf11dd-876b-441b-a28d-e6f1cca68340"), null, "CanDeleteApplication" },
                    { new Guid("f6b466be-13f6-4a31-aa83-894889318483"), null, "IsRegistered" },
                    { new Guid("fcf49c77-b59a-4da2-be85-0dffe1fdfefc"), null, "CanReadOwnBorrowers" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("32701267-5fb1-49f6-81b9-9e72698ce750"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m },
                    { new Guid("a71c9255-991d-4e0b-b8d9-9e378d80dcd9"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("53449878-c34d-4948-bd87-85ce93fb0412"), "Borrower" },
                    { new Guid("7ccac654-3259-47a8-bc6a-0e1e3a3cfd79"), "LoanOfficer" },
                    { new Guid("7e117337-33b4-4572-b0ed-9be28a47716c"), "RegisteredUser" },
                    { new Guid("a7ff1fe1-4b72-44d1-8ddd-470beea7a900"), "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("a5794375-c197-4896-85c7-f91ed248e2dc"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("25e9445a-ae2f-4abd-a98b-7c793db99799"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") },
                    { new Guid("3b9db73e-71c8-49ae-a1e9-feb9bc39e8f2"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") },
                    { new Guid("4fa87bfe-0ff6-45c8-b4c2-3f260b2de1a7"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") },
                    { new Guid("92e836aa-536a-43a5-8112-7e77fbd99fd5"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") },
                    { new Guid("e4d2a042-a495-4715-b148-02c9d2422d0b"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") },
                    { new Guid("e7bf11dd-876b-441b-a28d-e6f1cca68340"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") },
                    { new Guid("fcf49c77-b59a-4da2-be85-0dffe1fdfefc"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") },
                    { new Guid("1de47ea6-0479-44c3-b814-61677745dc91"), new Guid("7ccac654-3259-47a8-bc6a-0e1e3a3cfd79") },
                    { new Guid("8506d801-9b1e-4e8d-af74-8f571bb03409"), new Guid("7ccac654-3259-47a8-bc6a-0e1e3a3cfd79") },
                    { new Guid("bf7339ca-bc33-4f6d-9926-07ab5f7a32e7"), new Guid("7ccac654-3259-47a8-bc6a-0e1e3a3cfd79") },
                    { new Guid("3b9db73e-71c8-49ae-a1e9-feb9bc39e8f2"), new Guid("7e117337-33b4-4572-b0ed-9be28a47716c") },
                    { new Guid("f6b466be-13f6-4a31-aa83-894889318483"), new Guid("7e117337-33b4-4572-b0ed-9be28a47716c") },
                    { new Guid("921f5252-01a5-4fc2-9485-e83a0aa54400"), new Guid("a7ff1fe1-4b72-44d1-8ddd-470beea7a900") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a7ff1fe1-4b72-44d1-8ddd-470beea7a900"), new Guid("a5794375-c197-4896-85c7-f91ed248e2dc") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("093a991f-5249-4a29-a585-f7388000727e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("3226609e-0a60-40a2-a3c2-29a9d905bee5"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("4bce84ca-cad4-4e0c-bfcf-0cc4fa5e2c6e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8e961611-d59f-4ac7-b37e-0d43336dd920"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("9c3e9ab7-e571-49d4-8774-807eeee78108"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("aebba1cb-ae33-4757-84e1-8ae00e084d00"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("49d70e21-6032-4dd9-bc07-a522abce16c5"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("bfea5960-35e0-4aa0-9877-240da3336876"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("fba9c0f7-3298-466e-908d-fcf1bf81e64e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32701267-5fb1-49f6-81b9-9e72698ce750"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a71c9255-991d-4e0b-b8d9-9e378d80dcd9"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("25e9445a-ae2f-4abd-a98b-7c793db99799"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3b9db73e-71c8-49ae-a1e9-feb9bc39e8f2"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("4fa87bfe-0ff6-45c8-b4c2-3f260b2de1a7"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("92e836aa-536a-43a5-8112-7e77fbd99fd5"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("e4d2a042-a495-4715-b148-02c9d2422d0b"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("e7bf11dd-876b-441b-a28d-e6f1cca68340"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("fcf49c77-b59a-4da2-be85-0dffe1fdfefc"), new Guid("53449878-c34d-4948-bd87-85ce93fb0412") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("1de47ea6-0479-44c3-b814-61677745dc91"), new Guid("7ccac654-3259-47a8-bc6a-0e1e3a3cfd79") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("8506d801-9b1e-4e8d-af74-8f571bb03409"), new Guid("7ccac654-3259-47a8-bc6a-0e1e3a3cfd79") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("bf7339ca-bc33-4f6d-9926-07ab5f7a32e7"), new Guid("7ccac654-3259-47a8-bc6a-0e1e3a3cfd79") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3b9db73e-71c8-49ae-a1e9-feb9bc39e8f2"), new Guid("7e117337-33b4-4572-b0ed-9be28a47716c") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("f6b466be-13f6-4a31-aa83-894889318483"), new Guid("7e117337-33b4-4572-b0ed-9be28a47716c") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("921f5252-01a5-4fc2-9485-e83a0aa54400"), new Guid("a7ff1fe1-4b72-44d1-8ddd-470beea7a900") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a7ff1fe1-4b72-44d1-8ddd-470beea7a900"), new Guid("a5794375-c197-4896-85c7-f91ed248e2dc") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1de47ea6-0479-44c3-b814-61677745dc91"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("25e9445a-ae2f-4abd-a98b-7c793db99799"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3b9db73e-71c8-49ae-a1e9-feb9bc39e8f2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4fa87bfe-0ff6-45c8-b4c2-3f260b2de1a7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8506d801-9b1e-4e8d-af74-8f571bb03409"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("921f5252-01a5-4fc2-9485-e83a0aa54400"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("92e836aa-536a-43a5-8112-7e77fbd99fd5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bf7339ca-bc33-4f6d-9926-07ab5f7a32e7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e4d2a042-a495-4715-b148-02c9d2422d0b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e7bf11dd-876b-441b-a28d-e6f1cca68340"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f6b466be-13f6-4a31-aa83-894889318483"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fcf49c77-b59a-4da2-be85-0dffe1fdfefc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("53449878-c34d-4948-bd87-85ce93fb0412"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7ccac654-3259-47a8-bc6a-0e1e3a3cfd79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7e117337-33b4-4572-b0ed-9be28a47716c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a7ff1fe1-4b72-44d1-8ddd-470beea7a900"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5794375-c197-4896-85c7-f91ed248e2dc"));

            migrationBuilder.DropColumn(
                name: "LenderId",
                table: "LenderMatrices");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "LenderMatrices");

            migrationBuilder.DropColumn(
                name: "Spread",
                table: "LenderMatrices");

            migrationBuilder.DropColumn(
                name: "Tenor",
                table: "LenderMatrices");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LenderMatrices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("0b00f1d6-56df-45f6-a575-c693df004d03"), null, "Partnership Limited by Shares" },
                    { new Guid("17d747b8-7695-4fd9-8eaf-38c1930f10bd"), null, "Cooperative Society" },
                    { new Guid("282ccac5-ffb4-4d85-bd7c-bbae48b753bd"), null, "Limited Partnership" },
                    { new Guid("69421fa1-3116-49b0-80fa-5c7bdbe77e59"), null, "General Partnership" },
                    { new Guid("7d291cfe-7319-428f-b30f-58e880021e9f"), null, "Other" },
                    { new Guid("8386f64a-8757-458a-bd73-1af1e641b1a6"), null, "Sole Proprietorship" }
                });

            migrationBuilder.InsertData(
                table: "Lenders",
                columns: new[] { "Id", "BorrowerCompanyType", "MaxTenor", "MinTenor", "Name", "RequestedAmount" },
                values: new object[,]
                {
                    { new Guid("190f3ceb-46e4-4953-84df-4bb7589fd822"), "Partnership Limited by Shares", 60, 40, "AZIF", 400000 },
                    { new Guid("ee142133-dc54-49b7-b1fe-07108226344b"), "Cooperative Society", 0, 30, "PMI BTECH", 100000 },
                    { new Guid("ff663709-cdf4-43dd-84d9-522a7e19635a"), "Sole Proprietorship", 60, 30, "PMI BTECH", 100000 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("09f0f634-7361-4d7c-9ca2-0dc8ae4fedea"), null, "CanReadOwnBorrowers" },
                    { new Guid("1dc3cd7e-3e02-4d0c-9b49-7c5e831c6718"), null, "CanDeleteApplication" },
                    { new Guid("346b8cc8-5c89-4695-b22c-a7ab457e5c90"), null, "CanDeleteBorrower" },
                    { new Guid("58b90d78-677d-4404-bf67-a632499a43ee"), null, "IsRegistered" },
                    { new Guid("58de110a-650b-47bd-9605-f74e539f16ab"), null, "CanUpdateApplication" },
                    { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), null, "CanAddBorrower" },
                    { new Guid("8a042266-b542-45c4-af4e-304049986643"), null, "CanReadOwnApplications" },
                    { new Guid("c947dc46-bc7c-407c-9ad8-e2050d24b9c7"), null, "IsSuperAdmin" },
                    { new Guid("d1f8563a-8afe-4539-a887-77b356c38141"), null, "CanReadBorrowers" },
                    { new Guid("e1771e48-ea3b-4a56-93ca-02f62c5e9cbb"), null, "CanUpdateBorrower" },
                    { new Guid("ed0a6095-d8ab-4b15-815d-cf0b14a5ab0a"), null, "CanReadApplications" },
                    { new Guid("f4134d5e-1def-46f1-8615-c318141e0aaf"), null, "CanAddApplication" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("2a446505-7a64-4865-a4e8-b70342f2ec95"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m },
                    { new Guid("50f23242-e5b0-4819-9c87-1aabcd9e4fcf"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf"), "RegisteredUser" },
                    { new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d"), "LoanOfficer" },
                    { new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd"), "Borrower" },
                    { new Guid("f6146789-7d87-470b-bd72-45d88209f05d"), "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("5a9dbbd4-8ae9-4be6-b785-f215eed29e2d"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("58b90d78-677d-4404-bf67-a632499a43ee"), new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf") },
                    { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf") },
                    { new Guid("58de110a-650b-47bd-9605-f74e539f16ab"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") },
                    { new Guid("d1f8563a-8afe-4539-a887-77b356c38141"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") },
                    { new Guid("ed0a6095-d8ab-4b15-815d-cf0b14a5ab0a"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") },
                    { new Guid("09f0f634-7361-4d7c-9ca2-0dc8ae4fedea"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("1dc3cd7e-3e02-4d0c-9b49-7c5e831c6718"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("346b8cc8-5c89-4695-b22c-a7ab457e5c90"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("8a042266-b542-45c4-af4e-304049986643"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("e1771e48-ea3b-4a56-93ca-02f62c5e9cbb"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("f4134d5e-1def-46f1-8615-c318141e0aaf"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("c947dc46-bc7c-407c-9ad8-e2050d24b9c7"), new Guid("f6146789-7d87-470b-bd72-45d88209f05d") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f6146789-7d87-470b-bd72-45d88209f05d"), new Guid("5a9dbbd4-8ae9-4be6-b785-f215eed29e2d") });
        }
    }
}
