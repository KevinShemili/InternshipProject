using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyTypes_Borrowers_BorrowerId",
                table: "CompanyTypes");

            migrationBuilder.DropIndex(
                name: "IX_CompanyTypes_BorrowerId",
                table: "CompanyTypes");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("004f3487-9a7e-48de-85b7-53d82ed47c26"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0bd97344-0f53-4c91-ab0e-08b34c31ce56"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("10bd8161-1d72-466c-b8f0-813ed5725a35"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1646587e-3fae-4c09-8f4e-9461403af661"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("223d2e1d-4d96-4c1a-a550-6c2747ec1b7d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4827e2de-527f-4633-af09-4a71c19648ae"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("566efc55-27fc-4b5b-b878-bf9cfe802be5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5c46dc12-3530-492f-ab38-4619d09fd9b5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6cd2d781-7022-493c-b041-65da0e710036"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8eb65ae4-9ad2-4bf8-8d7a-9f483a7188a7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a0a4208e-494e-4e96-9373-048ff77a32af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d3a0d13d-e6b3-41fd-9c5a-8ad200f6cc8b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db9bc4ac-0a9f-49f8-85b0-93c76bba3a01"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e029f527-8acc-45b2-b948-5b3d1323b5cc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f3c52792-f03f-49af-9170-1b04637fc281"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fbb27224-f85a-404a-ab50-47e19b05d186"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ffe2234c-aba3-483b-b51a-f56d28eefe3b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4b960bf2-18d8-46b4-8e00-17b3a42da385"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ac878782-27cb-4885-8a2b-4fdf537b01a9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bfd0db81-1cc4-44bc-baa7-7178cb84100a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ef19a6c3-5efc-48de-be36-15a72da9ce74"));

            migrationBuilder.DropColumn(
                name: "BorrowerId",
                table: "CompanyTypes");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyTypeId",
                table: "Borrowers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("14e471e7-36b8-426d-8576-c198c19b145e"), null, "CanReadApplications" },
                    { new Guid("19bab869-3106-4fb1-8f0f-a819ceba678e"), null, "IsRegistered" },
                    { new Guid("2643b58b-ebe4-417b-9ac9-01fa2ce90733"), null, "CanUpdateLender" },
                    { new Guid("26c3ff7a-bcd0-4f52-aabe-f0ba0a033f26"), null, "CanUpdateBorrower" },
                    { new Guid("2970c327-7b3a-4d8b-b4c4-d9ab9f561206"), null, "CanUpdateUser" },
                    { new Guid("3be7689e-d5d1-4b36-b97b-3d5ebc88dfef"), null, "CanDeleteBorrower" },
                    { new Guid("449b55fb-c896-4477-9cba-0499317e0890"), null, "CanAddBorrower" },
                    { new Guid("454af93d-40bf-4fcb-b37b-9db409a3dfde"), null, "CanDeleteApplication" },
                    { new Guid("523c847a-a51d-42a8-b5be-01cdacce138a"), null, "CanReadLenders" },
                    { new Guid("630bac93-0ed5-4673-b72a-8f1367aaa528"), null, "CanDeleteUser" },
                    { new Guid("69f9f3ef-a5aa-4587-a29c-7f7b4089f6fb"), null, "CanAddLender" },
                    { new Guid("6c4a3171-fbd7-406d-a6ab-0a15437f8a8d"), null, "CanAddApplication" },
                    { new Guid("77a95df2-dc1d-4bf2-8a1d-4625d8b314cb"), null, "CanAddUser" },
                    { new Guid("99bfb5a2-ffe4-4971-bfcd-7b500279f6f6"), null, "CanReadUsers" },
                    { new Guid("a46d610b-08eb-41e8-a05b-4d797da0a20e"), null, "CanDeleteLender" },
                    { new Guid("b32546d9-685a-4b0f-ab32-4b0d547acac4"), null, "CanReadBorrowers" },
                    { new Guid("d1663d79-95fa-4cf0-97a1-fedfcaa83ece"), null, "CanUpdateApplication" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03cfd74b-2409-486b-a5ca-8fe94cf90ec3"), "LoanOfficerBackOffice" },
                    { new Guid("15eb63da-bf84-45d1-855e-ae8d79c6acb5"), "RegisteredUser" },
                    { new Guid("c6ec8331-4417-4d95-b0bf-8ff6d3dcf02b"), "LoanOfficerFrontOffice" },
                    { new Guid("eba39481-33d6-4f00-8e31-62ced286dc4a"), "Borrower" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_CompanyTypeId",
                table: "Borrowers",
                column: "CompanyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_CompanyTypes_CompanyTypeId",
                table: "Borrowers",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_CompanyTypes_CompanyTypeId",
                table: "Borrowers");

            migrationBuilder.DropIndex(
                name: "IX_Borrowers_CompanyTypeId",
                table: "Borrowers");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("14e471e7-36b8-426d-8576-c198c19b145e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("19bab869-3106-4fb1-8f0f-a819ceba678e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2643b58b-ebe4-417b-9ac9-01fa2ce90733"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("26c3ff7a-bcd0-4f52-aabe-f0ba0a033f26"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2970c327-7b3a-4d8b-b4c4-d9ab9f561206"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3be7689e-d5d1-4b36-b97b-3d5ebc88dfef"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("449b55fb-c896-4477-9cba-0499317e0890"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("454af93d-40bf-4fcb-b37b-9db409a3dfde"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("523c847a-a51d-42a8-b5be-01cdacce138a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("630bac93-0ed5-4673-b72a-8f1367aaa528"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("69f9f3ef-a5aa-4587-a29c-7f7b4089f6fb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6c4a3171-fbd7-406d-a6ab-0a15437f8a8d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("77a95df2-dc1d-4bf2-8a1d-4625d8b314cb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("99bfb5a2-ffe4-4971-bfcd-7b500279f6f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a46d610b-08eb-41e8-a05b-4d797da0a20e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b32546d9-685a-4b0f-ab32-4b0d547acac4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d1663d79-95fa-4cf0-97a1-fedfcaa83ece"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("03cfd74b-2409-486b-a5ca-8fe94cf90ec3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("15eb63da-bf84-45d1-855e-ae8d79c6acb5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c6ec8331-4417-4d95-b0bf-8ff6d3dcf02b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eba39481-33d6-4f00-8e31-62ced286dc4a"));

            migrationBuilder.DropColumn(
                name: "CompanyTypeId",
                table: "Borrowers");

            migrationBuilder.AddColumn<Guid>(
                name: "BorrowerId",
                table: "CompanyTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("004f3487-9a7e-48de-85b7-53d82ed47c26"), null, "CanDeleteBorrower" },
                    { new Guid("0bd97344-0f53-4c91-ab0e-08b34c31ce56"), null, "CanDeleteLender" },
                    { new Guid("10bd8161-1d72-466c-b8f0-813ed5725a35"), null, "CanDeleteUser" },
                    { new Guid("1646587e-3fae-4c09-8f4e-9461403af661"), null, "CanAddBorrower" },
                    { new Guid("223d2e1d-4d96-4c1a-a550-6c2747ec1b7d"), null, "CanDeleteApplication" },
                    { new Guid("4827e2de-527f-4633-af09-4a71c19648ae"), null, "CanAddApplication" },
                    { new Guid("566efc55-27fc-4b5b-b878-bf9cfe802be5"), null, "CanUpdateApplication" },
                    { new Guid("5c46dc12-3530-492f-ab38-4619d09fd9b5"), null, "CanUpdateUser" },
                    { new Guid("6cd2d781-7022-493c-b041-65da0e710036"), null, "CanAddUser" },
                    { new Guid("8eb65ae4-9ad2-4bf8-8d7a-9f483a7188a7"), null, "CanReadUsers" },
                    { new Guid("a0a4208e-494e-4e96-9373-048ff77a32af"), null, "IsRegistered" },
                    { new Guid("d3a0d13d-e6b3-41fd-9c5a-8ad200f6cc8b"), null, "CanReadApplications" },
                    { new Guid("db9bc4ac-0a9f-49f8-85b0-93c76bba3a01"), null, "CanUpdateBorrower" },
                    { new Guid("e029f527-8acc-45b2-b948-5b3d1323b5cc"), null, "CanUpdateLender" },
                    { new Guid("f3c52792-f03f-49af-9170-1b04637fc281"), null, "CanReadLenders" },
                    { new Guid("fbb27224-f85a-404a-ab50-47e19b05d186"), null, "CanAddLender" },
                    { new Guid("ffe2234c-aba3-483b-b51a-f56d28eefe3b"), null, "CanReadBorrowers" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4b960bf2-18d8-46b4-8e00-17b3a42da385"), "Borrower" },
                    { new Guid("ac878782-27cb-4885-8a2b-4fdf537b01a9"), "RegisteredUser" },
                    { new Guid("bfd0db81-1cc4-44bc-baa7-7178cb84100a"), "LoanOfficerBackOffice" },
                    { new Guid("ef19a6c3-5efc-48de-be36-15a72da9ce74"), "LoanOfficerFrontOffice" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTypes_BorrowerId",
                table: "CompanyTypes",
                column: "BorrowerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyTypes_Borrowers_BorrowerId",
                table: "CompanyTypes",
                column: "BorrowerId",
                principalTable: "Borrowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
