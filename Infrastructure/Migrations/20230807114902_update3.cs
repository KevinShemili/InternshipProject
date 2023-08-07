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
                keyValue: new Guid("002375ea-4371-47d6-b684-ed6a3cc5eeb3"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("1736a273-84c5-450e-a24d-567f97333e6c"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("17a0f328-55c5-41cf-abf8-1278512ed13e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("2c09851f-4e7a-4634-8d45-5e25b06d6173"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("ba6d9303-19ee-4cc4-a4ea-a9c2338f2752"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("e08bac91-8ed0-4d2a-aaa7-bd48ac5e2301"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fe4eda8-4eb7-4f4c-820b-74eb6848b2c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f96a4cd6-b0ae-4a86-9114-c4d290e6f191"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("2fdaf943-11be-46cd-b189-23125a817af9"), new Guid("3623111c-4153-4a01-b427-7b4e7ff50155") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("4557da07-e9ed-44be-b14e-5e6a20fecbb6"), new Guid("3f094fc8-be30-4ca4-9c19-df35e52af323") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("0aa40cd4-539e-4b7a-ba84-965857c880d3"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("2c6d3b43-69ff-4bff-a43f-4335d9744122"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3972c743-f23f-48fd-89ad-0806fb4b814b"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("4771ab0a-a33a-4d9c-86ac-5922b31c1c43"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("5e7d6531-f1c6-4297-8cd3-6da8a6ff1f79"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("76db2afb-deab-4fab-94db-1f80806b1f63"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("b326523c-9a2b-4be3-ada9-09b8e3e0643a"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("f7af8e6d-d6f5-4795-abf2-2cb8df2513e5"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3972c743-f23f-48fd-89ad-0806fb4b814b"), new Guid("68c31797-67c5-407d-9a24-ee7362745348") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3623111c-4153-4a01-b427-7b4e7ff50155"), new Guid("8e42f67c-f673-40e3-b2db-fc57dbb40df3") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0aa40cd4-539e-4b7a-ba84-965857c880d3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2c6d3b43-69ff-4bff-a43f-4335d9744122"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2fdaf943-11be-46cd-b189-23125a817af9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3972c743-f23f-48fd-89ad-0806fb4b814b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4557da07-e9ed-44be-b14e-5e6a20fecbb6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4771ab0a-a33a-4d9c-86ac-5922b31c1c43"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5e7d6531-f1c6-4297-8cd3-6da8a6ff1f79"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("76db2afb-deab-4fab-94db-1f80806b1f63"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b326523c-9a2b-4be3-ada9-09b8e3e0643a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f7af8e6d-d6f5-4795-abf2-2cb8df2513e5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3623111c-4153-4a01-b427-7b4e7ff50155"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3f094fc8-be30-4ca4-9c19-df35e52af323"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68c31797-67c5-407d-9a24-ee7362745348"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e42f67c-f673-40e3-b2db-fc57dbb40df3"));

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("0c1b9a57-cd3f-4233-b5bd-e10f2a1defb3"), null, "Limited Partnership" },
                    { new Guid("7fabf91b-a8cf-49ab-8072-186d3336afd5"), null, "Sole Proprietorship" },
                    { new Guid("9e94378e-22db-4f19-834e-c1fee97c3052"), null, "General Partnership" },
                    { new Guid("b09ca5bc-e49c-475e-b27d-a120eed53c0d"), null, "Partnership Limited by Shares" },
                    { new Guid("b92db8a7-262d-4fa5-b890-562005530d7c"), null, "Cooperative Society" },
                    { new Guid("b9e5228b-0822-4039-8cfc-840a84d488b0"), null, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1198a730-a795-4b31-9fcc-d64d2e299423"), null, "CanReadBorrowers" },
                    { new Guid("1b8f3ac8-e31d-4f13-9257-2286da658656"), null, "CanAddApplication" },
                    { new Guid("22838362-3687-4899-b98e-7239896f992e"), null, "IsSuperAdmin" },
                    { new Guid("2f0825c1-5011-40c4-a00c-60e9085fd581"), null, "CanDeleteApplication" },
                    { new Guid("436570c7-9bc9-414f-873c-3a5a52387292"), null, "CanDeleteBorrower" },
                    { new Guid("555d76d3-a3f5-4e6d-9cf9-020411bad8b3"), null, "CanReadApplications" },
                    { new Guid("5583e785-4739-42f7-b95d-c0682f505194"), null, "CanUpdateApplication" },
                    { new Guid("9799b4f7-ee33-407a-bb07-3f56a5bd009d"), null, "CanAddBorrower" },
                    { new Guid("9ab1d4c6-21d1-4791-b597-531dabcbf91d"), null, "CanUpdateBorrower" },
                    { new Guid("f943166d-ad08-4ec8-ae20-f3cada690326"), null, "IsRegistered" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("52a9a588-5972-4749-8a93-078197238820"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m },
                    { new Guid("d82fbb0c-406a-4264-8355-6ad086f1b33d"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8"), "Borrower" },
                    { new Guid("6f9bb5c1-a25c-4800-86cf-6688f85b4acf"), "SuperAdmin" },
                    { new Guid("714e9b54-061f-4136-a909-84a166ad48b8"), "RegisteredUser" },
                    { new Guid("96c9560c-c296-47c2-b0b3-3e34707fa8b1"), "LoanOfficer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("d8352de1-1bb0-4476-879f-640480134880"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("1198a730-a795-4b31-9fcc-d64d2e299423"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") },
                    { new Guid("1b8f3ac8-e31d-4f13-9257-2286da658656"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") },
                    { new Guid("2f0825c1-5011-40c4-a00c-60e9085fd581"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") },
                    { new Guid("436570c7-9bc9-414f-873c-3a5a52387292"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") },
                    { new Guid("555d76d3-a3f5-4e6d-9cf9-020411bad8b3"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") },
                    { new Guid("5583e785-4739-42f7-b95d-c0682f505194"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") },
                    { new Guid("9799b4f7-ee33-407a-bb07-3f56a5bd009d"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") },
                    { new Guid("9ab1d4c6-21d1-4791-b597-531dabcbf91d"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") },
                    { new Guid("22838362-3687-4899-b98e-7239896f992e"), new Guid("6f9bb5c1-a25c-4800-86cf-6688f85b4acf") },
                    { new Guid("9799b4f7-ee33-407a-bb07-3f56a5bd009d"), new Guid("714e9b54-061f-4136-a909-84a166ad48b8") },
                    { new Guid("f943166d-ad08-4ec8-ae20-f3cada690326"), new Guid("714e9b54-061f-4136-a909-84a166ad48b8") },
                    { new Guid("5583e785-4739-42f7-b95d-c0682f505194"), new Guid("96c9560c-c296-47c2-b0b3-3e34707fa8b1") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6f9bb5c1-a25c-4800-86cf-6688f85b4acf"), new Guid("d8352de1-1bb0-4476-879f-640480134880") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("0c1b9a57-cd3f-4233-b5bd-e10f2a1defb3"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7fabf91b-a8cf-49ab-8072-186d3336afd5"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("9e94378e-22db-4f19-834e-c1fee97c3052"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b09ca5bc-e49c-475e-b27d-a120eed53c0d"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b92db8a7-262d-4fa5-b890-562005530d7c"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b9e5228b-0822-4039-8cfc-840a84d488b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52a9a588-5972-4749-8a93-078197238820"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d82fbb0c-406a-4264-8355-6ad086f1b33d"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("1198a730-a795-4b31-9fcc-d64d2e299423"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("1b8f3ac8-e31d-4f13-9257-2286da658656"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("2f0825c1-5011-40c4-a00c-60e9085fd581"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("436570c7-9bc9-414f-873c-3a5a52387292"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("555d76d3-a3f5-4e6d-9cf9-020411bad8b3"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("5583e785-4739-42f7-b95d-c0682f505194"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("9799b4f7-ee33-407a-bb07-3f56a5bd009d"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("9ab1d4c6-21d1-4791-b597-531dabcbf91d"), new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("22838362-3687-4899-b98e-7239896f992e"), new Guid("6f9bb5c1-a25c-4800-86cf-6688f85b4acf") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("9799b4f7-ee33-407a-bb07-3f56a5bd009d"), new Guid("714e9b54-061f-4136-a909-84a166ad48b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("f943166d-ad08-4ec8-ae20-f3cada690326"), new Guid("714e9b54-061f-4136-a909-84a166ad48b8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("5583e785-4739-42f7-b95d-c0682f505194"), new Guid("96c9560c-c296-47c2-b0b3-3e34707fa8b1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6f9bb5c1-a25c-4800-86cf-6688f85b4acf"), new Guid("d8352de1-1bb0-4476-879f-640480134880") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1198a730-a795-4b31-9fcc-d64d2e299423"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1b8f3ac8-e31d-4f13-9257-2286da658656"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("22838362-3687-4899-b98e-7239896f992e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2f0825c1-5011-40c4-a00c-60e9085fd581"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("436570c7-9bc9-414f-873c-3a5a52387292"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("555d76d3-a3f5-4e6d-9cf9-020411bad8b3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5583e785-4739-42f7-b95d-c0682f505194"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9799b4f7-ee33-407a-bb07-3f56a5bd009d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9ab1d4c6-21d1-4791-b597-531dabcbf91d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f943166d-ad08-4ec8-ae20-f3cada690326"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("40ef4d2e-b7af-4fda-a3a3-42aaaa96e1b8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6f9bb5c1-a25c-4800-86cf-6688f85b4acf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("714e9b54-061f-4136-a909-84a166ad48b8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("96c9560c-c296-47c2-b0b3-3e34707fa8b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8352de1-1bb0-4476-879f-640480134880"));

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("002375ea-4371-47d6-b684-ed6a3cc5eeb3"), null, "Partnership Limited by Shares" },
                    { new Guid("1736a273-84c5-450e-a24d-567f97333e6c"), null, "Sole Proprietorship" },
                    { new Guid("17a0f328-55c5-41cf-abf8-1278512ed13e"), null, "Other" },
                    { new Guid("2c09851f-4e7a-4634-8d45-5e25b06d6173"), null, "General Partnership" },
                    { new Guid("ba6d9303-19ee-4cc4-a4ea-a9c2338f2752"), null, "Cooperative Society" },
                    { new Guid("e08bac91-8ed0-4d2a-aaa7-bd48ac5e2301"), null, "Limited Partnership" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0aa40cd4-539e-4b7a-ba84-965857c880d3"), null, "CanDeleteBorrower" },
                    { new Guid("2c6d3b43-69ff-4bff-a43f-4335d9744122"), null, "CanAddBorrower" },
                    { new Guid("2fdaf943-11be-46cd-b189-23125a817af9"), null, "IsSuperAdmin" },
                    { new Guid("3972c743-f23f-48fd-89ad-0806fb4b814b"), null, "CanUpdateApplication" },
                    { new Guid("4557da07-e9ed-44be-b14e-5e6a20fecbb6"), null, "IsRegistered" },
                    { new Guid("4771ab0a-a33a-4d9c-86ac-5922b31c1c43"), null, "CanUpdateBorrower" },
                    { new Guid("5e7d6531-f1c6-4297-8cd3-6da8a6ff1f79"), null, "CanDeleteApplication" },
                    { new Guid("76db2afb-deab-4fab-94db-1f80806b1f63"), null, "CanReadBorrowers" },
                    { new Guid("b326523c-9a2b-4be3-ada9-09b8e3e0643a"), null, "CanReadApplications" },
                    { new Guid("f7af8e6d-d6f5-4795-abf2-2cb8df2513e5"), null, "CanAddApplication" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("8fe4eda8-4eb7-4f4c-820b-74eb6848b2c3"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m },
                    { new Guid("f96a4cd6-b0ae-4a86-9114-c4d290e6f191"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3623111c-4153-4a01-b427-7b4e7ff50155"), "SuperAdmin" },
                    { new Guid("3f094fc8-be30-4ca4-9c19-df35e52af323"), "RegisteredUser" },
                    { new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5"), "Borrower" },
                    { new Guid("68c31797-67c5-407d-9a24-ee7362745348"), "LoanOfficer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("8e42f67c-f673-40e3-b2db-fc57dbb40df3"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("2fdaf943-11be-46cd-b189-23125a817af9"), new Guid("3623111c-4153-4a01-b427-7b4e7ff50155") },
                    { new Guid("4557da07-e9ed-44be-b14e-5e6a20fecbb6"), new Guid("3f094fc8-be30-4ca4-9c19-df35e52af323") },
                    { new Guid("0aa40cd4-539e-4b7a-ba84-965857c880d3"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") },
                    { new Guid("2c6d3b43-69ff-4bff-a43f-4335d9744122"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") },
                    { new Guid("3972c743-f23f-48fd-89ad-0806fb4b814b"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") },
                    { new Guid("4771ab0a-a33a-4d9c-86ac-5922b31c1c43"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") },
                    { new Guid("5e7d6531-f1c6-4297-8cd3-6da8a6ff1f79"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") },
                    { new Guid("76db2afb-deab-4fab-94db-1f80806b1f63"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") },
                    { new Guid("b326523c-9a2b-4be3-ada9-09b8e3e0643a"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") },
                    { new Guid("f7af8e6d-d6f5-4795-abf2-2cb8df2513e5"), new Guid("5324ea2c-4591-4769-8a74-0812b42d3cc5") },
                    { new Guid("3972c743-f23f-48fd-89ad-0806fb4b814b"), new Guid("68c31797-67c5-407d-9a24-ee7362745348") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3623111c-4153-4a01-b427-7b4e7ff50155"), new Guid("8e42f67c-f673-40e3-b2db-fc57dbb40df3") });
        }
    }
}
