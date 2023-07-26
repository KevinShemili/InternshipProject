using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("09a9bad4-09af-4f79-868d-399372bce957"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("23067061-c25c-4274-8f08-1bc4dfc41a66"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4eee49a1-78e0-49c1-bf7b-dd28a8030250"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("569cb42d-5e23-4637-b18e-c50aa6f278d3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5d29937d-b6a8-4e77-953b-25dce13681ae"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("63ec58c3-9fec-432c-bc12-53d312506968"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("64aa8499-4d40-42dc-a958-7eae64598a35"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7510abe2-31fb-4e54-af8a-22450b80284b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("781d185e-7bb1-4c52-8353-f7b3c1b8d886"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7f69557e-8de8-4588-ad25-ad41da56617d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8113298f-7f4d-4f45-93a2-c4466adf59ba"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8833404a-d32a-48f0-8b42-81987e90bc32"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c4d09b8a-e67e-40eb-a142-376c3ad6602a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cbf8a920-2ae3-4c26-9bd0-d4a325a25cb3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d649c2fe-a286-4858-bf9e-a8ffadd76ccc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d9f453a2-ef19-4c7c-8eac-b496a4f7b41c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f13379d7-a19b-4895-bfd5-fd2da3077f83"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("275bb2d0-0b4a-4036-aba9-4103d281a338"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2b8befb0-b466-4362-bb0b-272c8bdda417"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bca3d5dc-c4df-4544-a30d-a656eb1916dc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3683837-987d-4be9-a0a6-ea5a6776f21c"));

            migrationBuilder.DropColumn(
                name: "Test",
                table: "Users");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Test",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("09a9bad4-09af-4f79-868d-399372bce957"), null, "CanAddBorrower" },
                    { new Guid("23067061-c25c-4274-8f08-1bc4dfc41a66"), null, "CanAddUser" },
                    { new Guid("4eee49a1-78e0-49c1-bf7b-dd28a8030250"), null, "CanDeleteApplication" },
                    { new Guid("569cb42d-5e23-4637-b18e-c50aa6f278d3"), null, "CanAddApplication" },
                    { new Guid("5d29937d-b6a8-4e77-953b-25dce13681ae"), null, "CanDeleteBorrower" },
                    { new Guid("63ec58c3-9fec-432c-bc12-53d312506968"), null, "CanReadBorrowers" },
                    { new Guid("64aa8499-4d40-42dc-a958-7eae64598a35"), null, "CanUpdateApplication" },
                    { new Guid("7510abe2-31fb-4e54-af8a-22450b80284b"), null, "CanUpdateLender" },
                    { new Guid("781d185e-7bb1-4c52-8353-f7b3c1b8d886"), null, "CanDeleteUser" },
                    { new Guid("7f69557e-8de8-4588-ad25-ad41da56617d"), null, "CanUpdateBorrower" },
                    { new Guid("8113298f-7f4d-4f45-93a2-c4466adf59ba"), null, "CanReadApplications" },
                    { new Guid("8833404a-d32a-48f0-8b42-81987e90bc32"), null, "CanUpdateUser" },
                    { new Guid("c4d09b8a-e67e-40eb-a142-376c3ad6602a"), null, "CanReadUsers" },
                    { new Guid("cbf8a920-2ae3-4c26-9bd0-d4a325a25cb3"), null, "IsRegistered" },
                    { new Guid("d649c2fe-a286-4858-bf9e-a8ffadd76ccc"), null, "CanDeleteLender" },
                    { new Guid("d9f453a2-ef19-4c7c-8eac-b496a4f7b41c"), null, "CanReadLenders" },
                    { new Guid("f13379d7-a19b-4895-bfd5-fd2da3077f83"), null, "CanAddLender" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("275bb2d0-0b4a-4036-aba9-4103d281a338"), "RegisteredUser" },
                    { new Guid("2b8befb0-b466-4362-bb0b-272c8bdda417"), "LoanOfficerBackOffice" },
                    { new Guid("bca3d5dc-c4df-4544-a30d-a656eb1916dc"), "Borrower" },
                    { new Guid("c3683837-987d-4be9-a0a6-ea5a6776f21c"), "LoanOfficerFrontOffice" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f7195df-de82-429c-a430-dc0742edf721"),
                column: "Test",
                value: false);
        }
    }
}
