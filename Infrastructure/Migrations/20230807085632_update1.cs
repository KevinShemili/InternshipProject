using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Loans_LoanId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_LoanId",
                table: "Applications");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("0e87d7d3-8655-44a1-9380-25d1d0003c3f"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("2c1ee122-3f64-479e-a52f-8dec4a88ae73"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("6660e3d5-b531-489f-846c-482529d14ede"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("74073147-3f68-4e7e-982d-c2ac33f2dad1"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("847e208e-5070-4964-9802-d4f0305ffebb"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("906c6654-13a4-49c7-85ba-f3410cde92e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c412d401-fe5b-4a69-abc8-10e6d0dc9c51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd96d926-c3e8-4082-8512-420b9fc8542d"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("1d4bee4a-0175-4782-b0cf-b37357e0756a"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("332c456b-efe5-4224-a536-e99fcae1669e"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3daba4d1-11c8-4ad3-8468-e9768933da6c"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("48d40758-8b72-4f97-b601-79544076ac1b"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("5c6a2297-7b07-42a4-8f9b-f3752e6e8596"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("65388018-92a2-4540-9717-96c83c4bf7d0"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("7ce7e977-429e-4e9f-9913-effa7a4d1e3b"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("8bc5136c-59d4-4a91-8239-42ed68a20fd5"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("308fb287-c6ec-4be9-a118-ba30e81d8e30"), new Guid("aadec4b9-faa0-48c9-8353-18becca56829") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("f9b9ecd7-b13d-4286-b4cd-2e20042a6a4c"), new Guid("c270692e-51fb-4a46-84bf-3d39da9d8070") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("5c6a2297-7b07-42a4-8f9b-f3752e6e8596"), new Guid("dc0fd0f0-d72a-40c8-b10b-9161c3f6fe89") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("aadec4b9-faa0-48c9-8353-18becca56829"), new Guid("c5d521ed-331e-430b-9505-36a1c040c4ff") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1d4bee4a-0175-4782-b0cf-b37357e0756a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("308fb287-c6ec-4be9-a118-ba30e81d8e30"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("332c456b-efe5-4224-a536-e99fcae1669e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3daba4d1-11c8-4ad3-8468-e9768933da6c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("48d40758-8b72-4f97-b601-79544076ac1b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5c6a2297-7b07-42a4-8f9b-f3752e6e8596"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("65388018-92a2-4540-9717-96c83c4bf7d0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ce7e977-429e-4e9f-9913-effa7a4d1e3b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8bc5136c-59d4-4a91-8239-42ed68a20fd5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f9b9ecd7-b13d-4286-b4cd-2e20042a6a4c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("aadec4b9-faa0-48c9-8353-18becca56829"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c270692e-51fb-4a46-84bf-3d39da9d8070"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc0fd0f0-d72a-40c8-b10b-9161c3f6fe89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5d521ed-331e-430b-9505-36a1c040c4ff"));

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "Applications");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationId",
                table: "Loans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ApplicationId",
                table: "Loans",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Applications_ApplicationId",
                table: "Loans",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Applications_ApplicationId",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_ApplicationId",
                table: "Loans");

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

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "Loans");

            migrationBuilder.AddColumn<Guid>(
                name: "LoanId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("0e87d7d3-8655-44a1-9380-25d1d0003c3f"), null, "Cooperative Society" },
                    { new Guid("2c1ee122-3f64-479e-a52f-8dec4a88ae73"), null, "Partnership Limited by Shares" },
                    { new Guid("6660e3d5-b531-489f-846c-482529d14ede"), null, "General Partnership" },
                    { new Guid("74073147-3f68-4e7e-982d-c2ac33f2dad1"), null, "Sole Proprietorship" },
                    { new Guid("847e208e-5070-4964-9802-d4f0305ffebb"), null, "Other" },
                    { new Guid("906c6654-13a4-49c7-85ba-f3410cde92e5"), null, "Limited Partnership" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1d4bee4a-0175-4782-b0cf-b37357e0756a"), null, "CanDeleteApplication" },
                    { new Guid("308fb287-c6ec-4be9-a118-ba30e81d8e30"), null, "IsSuperAdmin" },
                    { new Guid("332c456b-efe5-4224-a536-e99fcae1669e"), null, "CanAddApplication" },
                    { new Guid("3daba4d1-11c8-4ad3-8468-e9768933da6c"), null, "CanAddBorrower" },
                    { new Guid("48d40758-8b72-4f97-b601-79544076ac1b"), null, "CanReadBorrowers" },
                    { new Guid("5c6a2297-7b07-42a4-8f9b-f3752e6e8596"), null, "CanUpdateApplication" },
                    { new Guid("65388018-92a2-4540-9717-96c83c4bf7d0"), null, "CanReadApplications" },
                    { new Guid("7ce7e977-429e-4e9f-9913-effa7a4d1e3b"), null, "CanDeleteBorrower" },
                    { new Guid("8bc5136c-59d4-4a91-8239-42ed68a20fd5"), null, "CanUpdateBorrower" },
                    { new Guid("f9b9ecd7-b13d-4286-b4cd-2e20042a6a4c"), null, "IsRegistered" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("c412d401-fe5b-4a69-abc8-10e6d0dc9c51"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m },
                    { new Guid("dd96d926-c3e8-4082-8512-420b9fc8542d"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a"), "Borrower" },
                    { new Guid("aadec4b9-faa0-48c9-8353-18becca56829"), "SuperAdmin" },
                    { new Guid("c270692e-51fb-4a46-84bf-3d39da9d8070"), "RegisteredUser" },
                    { new Guid("dc0fd0f0-d72a-40c8-b10b-9161c3f6fe89"), "LoanOfficer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("c5d521ed-331e-430b-9505-36a1c040c4ff"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("1d4bee4a-0175-4782-b0cf-b37357e0756a"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") },
                    { new Guid("332c456b-efe5-4224-a536-e99fcae1669e"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") },
                    { new Guid("3daba4d1-11c8-4ad3-8468-e9768933da6c"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") },
                    { new Guid("48d40758-8b72-4f97-b601-79544076ac1b"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") },
                    { new Guid("5c6a2297-7b07-42a4-8f9b-f3752e6e8596"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") },
                    { new Guid("65388018-92a2-4540-9717-96c83c4bf7d0"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") },
                    { new Guid("7ce7e977-429e-4e9f-9913-effa7a4d1e3b"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") },
                    { new Guid("8bc5136c-59d4-4a91-8239-42ed68a20fd5"), new Guid("3eda611f-415f-4f67-bd43-025eecff8e0a") },
                    { new Guid("308fb287-c6ec-4be9-a118-ba30e81d8e30"), new Guid("aadec4b9-faa0-48c9-8353-18becca56829") },
                    { new Guid("f9b9ecd7-b13d-4286-b4cd-2e20042a6a4c"), new Guid("c270692e-51fb-4a46-84bf-3d39da9d8070") },
                    { new Guid("5c6a2297-7b07-42a4-8f9b-f3752e6e8596"), new Guid("dc0fd0f0-d72a-40c8-b10b-9161c3f6fe89") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("aadec4b9-faa0-48c9-8353-18becca56829"), new Guid("c5d521ed-331e-430b-9505-36a1c040c4ff") });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_LoanId",
                table: "Applications",
                column: "LoanId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Loans_LoanId",
                table: "Applications",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
