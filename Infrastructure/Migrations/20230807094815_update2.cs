using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("37256c72-426c-44ec-94e8-abf97ccec7a2"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("3b205c4b-ebe1-4ed3-a504-cad3a874fe5f"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("520f3e9f-4034-4f60-955d-01e3dbb4b8ba"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("771d643e-0d7a-415e-aa36-6c4a8e435cc7"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a87fd052-78db-4f82-b9ce-92797752f403"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d6ccf8bc-97dd-45e6-a6c7-1bfd489f5f1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f9a4399-3d14-4dfb-bcf3-6f31e481698a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7b56cc9-8c18-44f7-aaed-bb11b0dda7de"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("a6a8f029-bb1d-4ec7-990b-761da944c664"), new Guid("59d5a12f-0edc-4fdc-986f-5707724321ec") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("89e1965f-fa8a-4e69-a3c0-94658941cebd"), new Guid("8fc5288a-c410-4d76-9c7b-e9958985c10a") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("01d7b852-93bf-440d-8f75-1e00fdb3417a"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("1e2d760f-f2d8-419b-8d8f-466f11f3174e"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("59a01631-a367-4ad8-8ccd-2634dbb4715b"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("89e1965f-fa8a-4e69-a3c0-94658941cebd"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("94154520-7805-4ab0-91b7-31bb6098ad23"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("ae6f1921-f024-4f1b-b5d1-5b6a9771b851"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("cb535087-b7bb-46dc-80a2-1a64d497afa5"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("ddaed5e1-20ff-49b9-b68e-5151c049d503"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("c4333c6a-daeb-431b-9920-0162d65a44ad"), new Guid("ec3a4fdf-cf28-4756-91ba-f7899754daff") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("59d5a12f-0edc-4fdc-986f-5707724321ec"), new Guid("d7f8c9bf-0a9e-471d-a59d-fbd3f8ad1c52") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("01d7b852-93bf-440d-8f75-1e00fdb3417a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1e2d760f-f2d8-419b-8d8f-466f11f3174e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("59a01631-a367-4ad8-8ccd-2634dbb4715b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("89e1965f-fa8a-4e69-a3c0-94658941cebd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("94154520-7805-4ab0-91b7-31bb6098ad23"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a6a8f029-bb1d-4ec7-990b-761da944c664"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ae6f1921-f024-4f1b-b5d1-5b6a9771b851"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c4333c6a-daeb-431b-9920-0162d65a44ad"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cb535087-b7bb-46dc-80a2-1a64d497afa5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ddaed5e1-20ff-49b9-b68e-5151c049d503"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("59d5a12f-0edc-4fdc-986f-5707724321ec"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8fc5288a-c410-4d76-9c7b-e9958985c10a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ec3a4fdf-cf28-4756-91ba-f7899754daff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7f8c9bf-0a9e-471d-a59d-fbd3f8ad1c52"));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Products_Name",
                table: "Products",
                column: "Name");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Products_Name",
                table: "Products");

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
                    { new Guid("37256c72-426c-44ec-94e8-abf97ccec7a2"), null, "Cooperative Society" },
                    { new Guid("3b205c4b-ebe1-4ed3-a504-cad3a874fe5f"), null, "Partnership Limited by Shares" },
                    { new Guid("520f3e9f-4034-4f60-955d-01e3dbb4b8ba"), null, "Sole Proprietorship" },
                    { new Guid("771d643e-0d7a-415e-aa36-6c4a8e435cc7"), null, "General Partnership" },
                    { new Guid("a87fd052-78db-4f82-b9ce-92797752f403"), null, "Other" },
                    { new Guid("d6ccf8bc-97dd-45e6-a6c7-1bfd489f5f1d"), null, "Limited Partnership" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("01d7b852-93bf-440d-8f75-1e00fdb3417a"), null, "CanReadApplications" },
                    { new Guid("1e2d760f-f2d8-419b-8d8f-466f11f3174e"), null, "CanAddBorrower" },
                    { new Guid("59a01631-a367-4ad8-8ccd-2634dbb4715b"), null, "CanUpdateBorrower" },
                    { new Guid("89e1965f-fa8a-4e69-a3c0-94658941cebd"), null, "CanUpdateApplication" },
                    { new Guid("94154520-7805-4ab0-91b7-31bb6098ad23"), null, "CanDeleteBorrower" },
                    { new Guid("a6a8f029-bb1d-4ec7-990b-761da944c664"), null, "IsSuperAdmin" },
                    { new Guid("ae6f1921-f024-4f1b-b5d1-5b6a9771b851"), null, "CanAddApplication" },
                    { new Guid("c4333c6a-daeb-431b-9920-0162d65a44ad"), null, "IsRegistered" },
                    { new Guid("cb535087-b7bb-46dc-80a2-1a64d497afa5"), null, "CanDeleteApplication" },
                    { new Guid("ddaed5e1-20ff-49b9-b68e-5151c049d503"), null, "CanReadBorrowers" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("7f9a4399-3d14-4dfb-bcf3-6f31e481698a"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m },
                    { new Guid("a7b56cc9-8c18-44f7-aaed-bb11b0dda7de"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("59d5a12f-0edc-4fdc-986f-5707724321ec"), "SuperAdmin" },
                    { new Guid("8fc5288a-c410-4d76-9c7b-e9958985c10a"), "LoanOfficer" },
                    { new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966"), "Borrower" },
                    { new Guid("ec3a4fdf-cf28-4756-91ba-f7899754daff"), "RegisteredUser" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("d7f8c9bf-0a9e-471d-a59d-fbd3f8ad1c52"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("a6a8f029-bb1d-4ec7-990b-761da944c664"), new Guid("59d5a12f-0edc-4fdc-986f-5707724321ec") },
                    { new Guid("89e1965f-fa8a-4e69-a3c0-94658941cebd"), new Guid("8fc5288a-c410-4d76-9c7b-e9958985c10a") },
                    { new Guid("01d7b852-93bf-440d-8f75-1e00fdb3417a"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") },
                    { new Guid("1e2d760f-f2d8-419b-8d8f-466f11f3174e"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") },
                    { new Guid("59a01631-a367-4ad8-8ccd-2634dbb4715b"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") },
                    { new Guid("89e1965f-fa8a-4e69-a3c0-94658941cebd"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") },
                    { new Guid("94154520-7805-4ab0-91b7-31bb6098ad23"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") },
                    { new Guid("ae6f1921-f024-4f1b-b5d1-5b6a9771b851"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") },
                    { new Guid("cb535087-b7bb-46dc-80a2-1a64d497afa5"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") },
                    { new Guid("ddaed5e1-20ff-49b9-b68e-5151c049d503"), new Guid("e3139ea2-ea2e-4081-bacf-9cb4a6710966") },
                    { new Guid("c4333c6a-daeb-431b-9920-0162d65a44ad"), new Guid("ec3a4fdf-cf28-4756-91ba-f7899754daff") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("59d5a12f-0edc-4fdc-986f-5707724321ec"), new Guid("d7f8c9bf-0a9e-471d-a59d-fbd3f8ad1c52") });
        }
    }
}
