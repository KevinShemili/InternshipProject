using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0a198486-3e24-41db-8319-6c581f7252dc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0a3e7349-26dd-4072-8e19-9aa77a96de42"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("106545ea-d74f-42f2-81c5-fa184dc57544"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("117d666a-9653-4f42-8784-426921425681"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4ee6b082-8b19-4793-b23c-64947f52da01"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4f8d2bfa-35e3-403e-a9d3-2ffcdc9978cd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("61b0e420-bd7c-4d27-81e4-a7cc2c8a9113"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6871be23-dac0-4cb0-b4f3-7d0dae69643c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("77a3ca7e-5709-4f1f-abfa-a24b74a1aba0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7f37165d-5028-47ee-a117-c1e210585390"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("888eb890-8b89-4649-8b0a-019cbd43e4e4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8a8a92b5-062e-4047-8825-ba63ed7202a3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8aad3709-19ee-49c2-9d1e-c0034b1c3ebf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9579de3d-403f-4e19-a5e2-5d58b36f60f3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b37a5022-9d0f-4fc8-ba37-e657be9b8ffc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d4030a9b-b4d0-49cb-9809-6a350242a555"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd5c19f8-6abd-4d27-9df3-d36144803ebe"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0f53edd5-0b41-4ea6-9f17-959d5b6d0450"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("946fc7c4-c63d-415c-867e-66dabaaf195f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c86303ca-e93e-442a-bebb-deed81b38429"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fe629a9b-6a58-41d0-ae74-8730c9716146"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0a198486-3e24-41db-8319-6c581f7252dc"), null, "CanAddApplication" },
                    { new Guid("0a3e7349-26dd-4072-8e19-9aa77a96de42"), null, "IsRegistered" },
                    { new Guid("106545ea-d74f-42f2-81c5-fa184dc57544"), null, "CanUpdateUser" },
                    { new Guid("117d666a-9653-4f42-8784-426921425681"), null, "CanDeleteUser" },
                    { new Guid("4ee6b082-8b19-4793-b23c-64947f52da01"), null, "CanReadBorrowers" },
                    { new Guid("4f8d2bfa-35e3-403e-a9d3-2ffcdc9978cd"), null, "CanAddLender" },
                    { new Guid("61b0e420-bd7c-4d27-81e4-a7cc2c8a9113"), null, "CanUpdateApplication" },
                    { new Guid("6871be23-dac0-4cb0-b4f3-7d0dae69643c"), null, "CanReadApplications" },
                    { new Guid("77a3ca7e-5709-4f1f-abfa-a24b74a1aba0"), null, "CanAddUser" },
                    { new Guid("7f37165d-5028-47ee-a117-c1e210585390"), null, "CanDeleteLender" },
                    { new Guid("888eb890-8b89-4649-8b0a-019cbd43e4e4"), null, "CanAddBorrower" },
                    { new Guid("8a8a92b5-062e-4047-8825-ba63ed7202a3"), null, "CanReadUsers" },
                    { new Guid("8aad3709-19ee-49c2-9d1e-c0034b1c3ebf"), null, "CanReadLenders" },
                    { new Guid("9579de3d-403f-4e19-a5e2-5d58b36f60f3"), null, "CanUpdateBorrower" },
                    { new Guid("b37a5022-9d0f-4fc8-ba37-e657be9b8ffc"), null, "CanUpdateLender" },
                    { new Guid("d4030a9b-b4d0-49cb-9809-6a350242a555"), null, "CanDeleteBorrower" },
                    { new Guid("dd5c19f8-6abd-4d27-9df3-d36144803ebe"), null, "CanDeleteApplication" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0f53edd5-0b41-4ea6-9f17-959d5b6d0450"), "RegisteredUser" },
                    { new Guid("946fc7c4-c63d-415c-867e-66dabaaf195f"), "Borrower" },
                    { new Guid("c86303ca-e93e-442a-bebb-deed81b38429"), "LoanOfficerBackOffice" },
                    { new Guid("fe629a9b-6a58-41d0-ae74-8730c9716146"), "LoanOfficerFrontOffice" }
                });
        }
    }
}
