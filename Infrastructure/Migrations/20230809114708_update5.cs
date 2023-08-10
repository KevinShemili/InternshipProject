using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("67d5fd0e-f3a4-4aa7-bef8-8a587bcb475e"), null, "Partnership Limited by Shares" },
                    { new Guid("7db974f8-6321-4b35-8ef4-65edda9fe1d6"), null, "Sole Proprietorship" },
                    { new Guid("a7eea608-196c-4a52-a5c7-9694e0eb190b"), null, "Other" },
                    { new Guid("afbb07dd-70ad-471d-8448-67539b17b872"), null, "General Partnership" },
                    { new Guid("b2b5ce14-79b1-402e-92f5-2536bce91dda"), null, "Limited Partnership" },
                    { new Guid("be9a7220-0773-4d4d-8ef7-b5fbf480e952"), null, "Cooperative Society" }
                });

            migrationBuilder.InsertData(
                table: "Lenders",
                columns: new[] { "Id", "BorrowerCompanyType", "MaxTenor", "MinTenor", "Name", "RequestedAmount" },
                values: new object[,]
                {
                    { new Guid("0f3c377f-89ad-4fd6-af55-62f783b0ea52"), "Sole Proprietorship", 60, 30, "LOGITECH", 100000 },
                    { new Guid("7f83c404-efee-4900-98ee-38d3c95daf56"), "Partnership Limited by Shares", 60, 40, "AZIF", 400000 },
                    { new Guid("8d1ac5ed-0e1e-4de1-a7fc-a7df9e095653"), "Cooperative Society", 0, 30, "PMI BTECH", 100000 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2c9dad73-3625-4ecb-9522-c0f59a003e17"), null, "CanReadOwnBorrowers" },
                    { new Guid("3b12b41c-cdd3-45c8-8466-31750b8d3e3c"), null, "CanUpdateApplication" },
                    { new Guid("4d74ce4f-b8d9-4c87-8f48-365c00dc612c"), null, "CanReadApplications" },
                    { new Guid("537b42bd-db04-4db1-b4d8-c945a63116f6"), null, "CanDeleteBorrower" },
                    { new Guid("6fc1cbaf-b307-4efa-8ca9-2cced12a6028"), null, "IsRegistered" },
                    { new Guid("6fe53fc9-8fde-45f2-b3eb-f988e7abd00d"), null, "CanAddApplication" },
                    { new Guid("96c36a8c-be53-442d-a2f6-b2bcd71b3524"), null, "CanUpdateBorrower" },
                    { new Guid("a333628c-0918-47dd-9c84-30342e0e95e3"), null, "CanReadOwnApplications" },
                    { new Guid("d3e011d6-53d4-46c7-8866-840593334476"), null, "CanAddBorrower" },
                    { new Guid("e12c2b57-de8b-4191-a325-ab74c712e7dd"), null, "CanDeleteApplication" },
                    { new Guid("f2a1fba5-a23e-4686-9c0f-3e636b1ac3e4"), null, "CanReadBorrowers" },
                    { new Guid("ff9f62de-ab2a-4ba2-a15d-11a1f214ac66"), null, "IsSuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("5ff6a3be-482e-4826-b027-b7aea05de030"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m },
                    { new Guid("b2c0e6ae-2a83-4fd3-acce-dd1c647b1b1c"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1afac8e2-d840-40aa-a97f-c3f2bc5931b0"), "SuperAdmin" },
                    { new Guid("846d0436-ffce-49a2-a8ff-bf22aedf0a83"), "RegisteredUser" },
                    { new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0"), "Borrower" },
                    { new Guid("d6013a21-70d7-4c08-9de9-482f339147a8"), "LoanOfficer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("1b2031ff-df77-4ce4-a2f0-00e60546f243"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("ff9f62de-ab2a-4ba2-a15d-11a1f214ac66"), new Guid("1afac8e2-d840-40aa-a97f-c3f2bc5931b0") },
                    { new Guid("6fc1cbaf-b307-4efa-8ca9-2cced12a6028"), new Guid("846d0436-ffce-49a2-a8ff-bf22aedf0a83") },
                    { new Guid("d3e011d6-53d4-46c7-8866-840593334476"), new Guid("846d0436-ffce-49a2-a8ff-bf22aedf0a83") },
                    { new Guid("2c9dad73-3625-4ecb-9522-c0f59a003e17"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") },
                    { new Guid("537b42bd-db04-4db1-b4d8-c945a63116f6"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") },
                    { new Guid("6fe53fc9-8fde-45f2-b3eb-f988e7abd00d"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") },
                    { new Guid("96c36a8c-be53-442d-a2f6-b2bcd71b3524"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") },
                    { new Guid("a333628c-0918-47dd-9c84-30342e0e95e3"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") },
                    { new Guid("d3e011d6-53d4-46c7-8866-840593334476"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") },
                    { new Guid("e12c2b57-de8b-4191-a325-ab74c712e7dd"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") },
                    { new Guid("3b12b41c-cdd3-45c8-8466-31750b8d3e3c"), new Guid("d6013a21-70d7-4c08-9de9-482f339147a8") },
                    { new Guid("4d74ce4f-b8d9-4c87-8f48-365c00dc612c"), new Guid("d6013a21-70d7-4c08-9de9-482f339147a8") },
                    { new Guid("f2a1fba5-a23e-4686-9c0f-3e636b1ac3e4"), new Guid("d6013a21-70d7-4c08-9de9-482f339147a8") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("1afac8e2-d840-40aa-a97f-c3f2bc5931b0"), new Guid("1b2031ff-df77-4ce4-a2f0-00e60546f243") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("67d5fd0e-f3a4-4aa7-bef8-8a587bcb475e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7db974f8-6321-4b35-8ef4-65edda9fe1d6"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a7eea608-196c-4a52-a5c7-9694e0eb190b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("afbb07dd-70ad-471d-8448-67539b17b872"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b2b5ce14-79b1-402e-92f5-2536bce91dda"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("be9a7220-0773-4d4d-8ef7-b5fbf480e952"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("0f3c377f-89ad-4fd6-af55-62f783b0ea52"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("7f83c404-efee-4900-98ee-38d3c95daf56"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("8d1ac5ed-0e1e-4de1-a7fc-a7df9e095653"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ff6a3be-482e-4826-b027-b7aea05de030"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2c0e6ae-2a83-4fd3-acce-dd1c647b1b1c"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("ff9f62de-ab2a-4ba2-a15d-11a1f214ac66"), new Guid("1afac8e2-d840-40aa-a97f-c3f2bc5931b0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("6fc1cbaf-b307-4efa-8ca9-2cced12a6028"), new Guid("846d0436-ffce-49a2-a8ff-bf22aedf0a83") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("d3e011d6-53d4-46c7-8866-840593334476"), new Guid("846d0436-ffce-49a2-a8ff-bf22aedf0a83") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("2c9dad73-3625-4ecb-9522-c0f59a003e17"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("537b42bd-db04-4db1-b4d8-c945a63116f6"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("6fe53fc9-8fde-45f2-b3eb-f988e7abd00d"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("96c36a8c-be53-442d-a2f6-b2bcd71b3524"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("a333628c-0918-47dd-9c84-30342e0e95e3"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("d3e011d6-53d4-46c7-8866-840593334476"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("e12c2b57-de8b-4191-a325-ab74c712e7dd"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3b12b41c-cdd3-45c8-8466-31750b8d3e3c"), new Guid("d6013a21-70d7-4c08-9de9-482f339147a8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("4d74ce4f-b8d9-4c87-8f48-365c00dc612c"), new Guid("d6013a21-70d7-4c08-9de9-482f339147a8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("f2a1fba5-a23e-4686-9c0f-3e636b1ac3e4"), new Guid("d6013a21-70d7-4c08-9de9-482f339147a8") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1afac8e2-d840-40aa-a97f-c3f2bc5931b0"), new Guid("1b2031ff-df77-4ce4-a2f0-00e60546f243") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2c9dad73-3625-4ecb-9522-c0f59a003e17"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3b12b41c-cdd3-45c8-8466-31750b8d3e3c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4d74ce4f-b8d9-4c87-8f48-365c00dc612c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("537b42bd-db04-4db1-b4d8-c945a63116f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6fc1cbaf-b307-4efa-8ca9-2cced12a6028"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6fe53fc9-8fde-45f2-b3eb-f988e7abd00d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("96c36a8c-be53-442d-a2f6-b2bcd71b3524"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a333628c-0918-47dd-9c84-30342e0e95e3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d3e011d6-53d4-46c7-8866-840593334476"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e12c2b57-de8b-4191-a325-ab74c712e7dd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f2a1fba5-a23e-4686-9c0f-3e636b1ac3e4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ff9f62de-ab2a-4ba2-a15d-11a1f214ac66"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1afac8e2-d840-40aa-a97f-c3f2bc5931b0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("846d0436-ffce-49a2-a8ff-bf22aedf0a83"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d6013a21-70d7-4c08-9de9-482f339147a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b2031ff-df77-4ce4-a2f0-00e60546f243"));

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
    }
}
