using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0033c3b1-cd4c-4966-8c28-88b6e7dd0ddc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0aab7fa8-7769-44a1-a2f2-23e90e08c797"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0ac0e9d9-bb39-44ea-a938-d560e98b47b3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1bcc9659-8763-46b8-ac1c-93dcbcd1466c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3e1bacd1-8752-4d9a-adf9-096a1ac8e4cc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("75d1b929-b35d-44fe-ad65-db1b2b252a8f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7bb6b973-547e-4e55-95da-e63e488e6d44"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9bd8302e-1aa2-429d-a6b5-9faf528bc868"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a0ab4620-2f4f-4119-ba65-4c85f1020e23"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ac0368e8-34c4-43b8-8cc6-a449590d99ff"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b48d0cde-e0a0-46a9-9812-098133721a20"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bc0d5859-f559-4fff-8c97-8397be8200cd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c0487198-0710-4c23-af58-2293f8d9a0fe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db3db1a9-57c0-4c85-ba32-6afc524b9f43"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f7bbc230-1c4f-41ce-8d87-0d8849f79d6c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fb6b5344-f458-4ef1-8cf0-ec49cdff717b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fb794afe-fbc7-4aae-b9d5-7a62f3738e83"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("591685d2-2a2d-48b9-8ed1-563aba0856a1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7d884795-9bea-463f-a2b6-6c909e121411"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("81485210-2069-47aa-a550-ce903b4af42d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9118d69d-33e0-4c48-8fec-028573b8db84"));

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "UserVerificationAndReset",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "UserVerificationAndReset",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0033c3b1-cd4c-4966-8c28-88b6e7dd0ddc"), null, "CanDeleteUser" },
                    { new Guid("0aab7fa8-7769-44a1-a2f2-23e90e08c797"), null, "CanUpdateLender" },
                    { new Guid("0ac0e9d9-bb39-44ea-a938-d560e98b47b3"), null, "CanReadUsers" },
                    { new Guid("1bcc9659-8763-46b8-ac1c-93dcbcd1466c"), null, "CanAddApplication" },
                    { new Guid("3e1bacd1-8752-4d9a-adf9-096a1ac8e4cc"), null, "CanDeleteLender" },
                    { new Guid("75d1b929-b35d-44fe-ad65-db1b2b252a8f"), null, "CanAddLender" },
                    { new Guid("7bb6b973-547e-4e55-95da-e63e488e6d44"), null, "CanUpdateBorrower" },
                    { new Guid("9bd8302e-1aa2-429d-a6b5-9faf528bc868"), null, "CanDeleteBorrower" },
                    { new Guid("a0ab4620-2f4f-4119-ba65-4c85f1020e23"), null, "CanUpdateUser" },
                    { new Guid("ac0368e8-34c4-43b8-8cc6-a449590d99ff"), null, "IsRegistered" },
                    { new Guid("b48d0cde-e0a0-46a9-9812-098133721a20"), null, "CanDeleteApplication" },
                    { new Guid("bc0d5859-f559-4fff-8c97-8397be8200cd"), null, "CanAddBorrower" },
                    { new Guid("c0487198-0710-4c23-af58-2293f8d9a0fe"), null, "CanUpdateApplication" },
                    { new Guid("db3db1a9-57c0-4c85-ba32-6afc524b9f43"), null, "CanReadBorrowers" },
                    { new Guid("f7bbc230-1c4f-41ce-8d87-0d8849f79d6c"), null, "CanReadApplications" },
                    { new Guid("fb6b5344-f458-4ef1-8cf0-ec49cdff717b"), null, "CanReadLenders" },
                    { new Guid("fb794afe-fbc7-4aae-b9d5-7a62f3738e83"), null, "CanAddUser" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("591685d2-2a2d-48b9-8ed1-563aba0856a1"), "RegisteredUser" },
                    { new Guid("7d884795-9bea-463f-a2b6-6c909e121411"), "LoanOfficerBackOffice" },
                    { new Guid("81485210-2069-47aa-a550-ce903b4af42d"), "LoanOfficerFrontOffice" },
                    { new Guid("9118d69d-33e0-4c48-8fec-028573b8db84"), "Borrower" }
                });
        }
    }
}
