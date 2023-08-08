using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("020d97e0-6f1d-4792-ab20-966c06ca961c"), null, "Limited Partnership" },
                    { new Guid("3d31c1b7-e050-4fb6-a069-d1852f771cc7"), null, "Cooperative Society" },
                    { new Guid("4ac33fdf-41b6-4f3d-ab44-55fe513149a8"), null, "Other" },
                    { new Guid("51bbf32d-822d-408c-9eb6-3d5b124e7036"), null, "General Partnership" },
                    { new Guid("989bcf62-39b5-4112-9aa8-4f09cb4cd445"), null, "Partnership Limited by Shares" },
                    { new Guid("a219ebd3-4c1a-411c-b261-a3b55722860e"), null, "Sole Proprietorship" }
                });

            migrationBuilder.InsertData(
                table: "Lenders",
                columns: new[] { "Id", "BorrowerCompanyType", "MaxTenor", "MinTenor", "Name", "RequestedAmount" },
                values: new object[,]
                {
                    { new Guid("10ff740e-4fc1-4f1c-8b92-e4336f1822dd"), "Partnership Limited by Shares", 60, 40, "AZIF", 400000 },
                    { new Guid("55a8ef25-4416-4423-8c80-5e135bf43616"), "Sole Proprietorship", 60, 30, "LOGITECH", 100000 },
                    { new Guid("d70a975e-8f84-460a-9455-58c453379c3e"), "Cooperative Society", 0, 30, "PMI BTECH", 100000 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("28c7175d-a210-476b-907c-71a81cffed41"), null, "CanReadApplications" },
                    { new Guid("3180ef81-38af-4aaf-acf1-70f33de1c638"), null, "CanDeleteApplication" },
                    { new Guid("33c159ba-e992-40ea-80b5-c50a142cf450"), null, "IsSuperAdmin" },
                    { new Guid("414509a5-2249-41a0-99b0-32299075a4bf"), null, "CanReadOwnBorrowers" },
                    { new Guid("45dc0cfc-2096-472a-916c-e7297aabc09d"), null, "CanAddBorrower" },
                    { new Guid("88f9a398-af50-4a5a-8bcc-3dd4c94ffd3a"), null, "IsRegistered" },
                    { new Guid("a0facd56-2f17-4846-80cb-80e6eb43ce68"), null, "CanReadOwnApplications" },
                    { new Guid("a23e98ac-966e-4459-8107-960d2fa6b3b3"), null, "CanUpdateApplication" },
                    { new Guid("a3d95c71-5981-4700-90f7-b432cb88e52f"), null, "CanAddApplication" },
                    { new Guid("a8682a19-0301-4c18-b90a-2ccad4fc6537"), null, "CanDeleteBorrower" },
                    { new Guid("c0ac9632-ab15-4db7-8bae-217c623560e9"), null, "CanReadBorrowers" },
                    { new Guid("e46d7435-6c4f-4aeb-9872-e3f3452bd392"), null, "CanUpdateBorrower" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("0fcfab6d-4ad6-4607-a44d-e39d0a89b1a2"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m },
                    { new Guid("4cb4e9b6-ad9a-41e4-b8f8-0ed1982462d6"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9"), "Borrower" },
                    { new Guid("c2c231e8-26b5-4aa4-98a1-e373a9f04e4b"), "LoanOfficer" },
                    { new Guid("f364006d-018b-4255-b368-9ce0e6df06c0"), "SuperAdmin" },
                    { new Guid("f64a131e-e091-4f89-b273-65323100edc1"), "RegisteredUser" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("626b6473-f14c-4910-9428-4ecf54d02eef"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("3180ef81-38af-4aaf-acf1-70f33de1c638"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") },
                    { new Guid("414509a5-2249-41a0-99b0-32299075a4bf"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") },
                    { new Guid("45dc0cfc-2096-472a-916c-e7297aabc09d"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") },
                    { new Guid("a0facd56-2f17-4846-80cb-80e6eb43ce68"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") },
                    { new Guid("a3d95c71-5981-4700-90f7-b432cb88e52f"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") },
                    { new Guid("a8682a19-0301-4c18-b90a-2ccad4fc6537"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") },
                    { new Guid("e46d7435-6c4f-4aeb-9872-e3f3452bd392"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") },
                    { new Guid("28c7175d-a210-476b-907c-71a81cffed41"), new Guid("c2c231e8-26b5-4aa4-98a1-e373a9f04e4b") },
                    { new Guid("a23e98ac-966e-4459-8107-960d2fa6b3b3"), new Guid("c2c231e8-26b5-4aa4-98a1-e373a9f04e4b") },
                    { new Guid("c0ac9632-ab15-4db7-8bae-217c623560e9"), new Guid("c2c231e8-26b5-4aa4-98a1-e373a9f04e4b") },
                    { new Guid("33c159ba-e992-40ea-80b5-c50a142cf450"), new Guid("f364006d-018b-4255-b368-9ce0e6df06c0") },
                    { new Guid("45dc0cfc-2096-472a-916c-e7297aabc09d"), new Guid("f64a131e-e091-4f89-b273-65323100edc1") },
                    { new Guid("88f9a398-af50-4a5a-8bcc-3dd4c94ffd3a"), new Guid("f64a131e-e091-4f89-b273-65323100edc1") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f364006d-018b-4255-b368-9ce0e6df06c0"), new Guid("626b6473-f14c-4910-9428-4ecf54d02eef") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("020d97e0-6f1d-4792-ab20-966c06ca961c"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("3d31c1b7-e050-4fb6-a069-d1852f771cc7"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("4ac33fdf-41b6-4f3d-ab44-55fe513149a8"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("51bbf32d-822d-408c-9eb6-3d5b124e7036"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("989bcf62-39b5-4112-9aa8-4f09cb4cd445"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a219ebd3-4c1a-411c-b261-a3b55722860e"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("10ff740e-4fc1-4f1c-8b92-e4336f1822dd"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("55a8ef25-4416-4423-8c80-5e135bf43616"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("d70a975e-8f84-460a-9455-58c453379c3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fcfab6d-4ad6-4607-a44d-e39d0a89b1a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cb4e9b6-ad9a-41e4-b8f8-0ed1982462d6"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3180ef81-38af-4aaf-acf1-70f33de1c638"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("414509a5-2249-41a0-99b0-32299075a4bf"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("45dc0cfc-2096-472a-916c-e7297aabc09d"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("a0facd56-2f17-4846-80cb-80e6eb43ce68"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("a3d95c71-5981-4700-90f7-b432cb88e52f"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("a8682a19-0301-4c18-b90a-2ccad4fc6537"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("e46d7435-6c4f-4aeb-9872-e3f3452bd392"), new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("28c7175d-a210-476b-907c-71a81cffed41"), new Guid("c2c231e8-26b5-4aa4-98a1-e373a9f04e4b") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("a23e98ac-966e-4459-8107-960d2fa6b3b3"), new Guid("c2c231e8-26b5-4aa4-98a1-e373a9f04e4b") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("c0ac9632-ab15-4db7-8bae-217c623560e9"), new Guid("c2c231e8-26b5-4aa4-98a1-e373a9f04e4b") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("33c159ba-e992-40ea-80b5-c50a142cf450"), new Guid("f364006d-018b-4255-b368-9ce0e6df06c0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("45dc0cfc-2096-472a-916c-e7297aabc09d"), new Guid("f64a131e-e091-4f89-b273-65323100edc1") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("88f9a398-af50-4a5a-8bcc-3dd4c94ffd3a"), new Guid("f64a131e-e091-4f89-b273-65323100edc1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f364006d-018b-4255-b368-9ce0e6df06c0"), new Guid("626b6473-f14c-4910-9428-4ecf54d02eef") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("28c7175d-a210-476b-907c-71a81cffed41"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3180ef81-38af-4aaf-acf1-70f33de1c638"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("33c159ba-e992-40ea-80b5-c50a142cf450"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("414509a5-2249-41a0-99b0-32299075a4bf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("45dc0cfc-2096-472a-916c-e7297aabc09d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("88f9a398-af50-4a5a-8bcc-3dd4c94ffd3a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a0facd56-2f17-4846-80cb-80e6eb43ce68"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a23e98ac-966e-4459-8107-960d2fa6b3b3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a3d95c71-5981-4700-90f7-b432cb88e52f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a8682a19-0301-4c18-b90a-2ccad4fc6537"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c0ac9632-ab15-4db7-8bae-217c623560e9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e46d7435-6c4f-4aeb-9872-e3f3452bd392"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("844e8eec-bd58-4353-9197-042ebcf9eae9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c2c231e8-26b5-4aa4-98a1-e373a9f04e4b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f364006d-018b-4255-b368-9ce0e6df06c0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f64a131e-e091-4f89-b273-65323100edc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("626b6473-f14c-4910-9428-4ecf54d02eef"));

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
    }
}
