using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("12681a02-7e54-4c6e-b447-03d51fb05a61"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1b8aed2b-cd8e-4c1a-9963-548c075d72b2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1d0c1438-dd0c-4b05-bccd-dfccc5618ffd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3c956a6d-e675-45b1-8544-588761073fee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("436d1756-3c07-4c05-9f15-b13c7c365f45"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4c2c128e-179a-4ced-96ba-081bc7a02599"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5223aad9-aa30-420d-9697-d877c3ad38ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5f9b10db-a5a3-4910-9c3e-a1e33613ff23"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5fc35ff5-5795-4f95-a67a-25fd27f9eade"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5fc6d6da-2075-4d72-896c-1d69bc9c4a84"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("97398352-cb4d-44bc-b3c6-d63fc9a5f229"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b104a3d4-f7a4-4d8b-b710-a921af70cdc8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b6ddd3b7-91a6-45ef-a458-8c011a518f09"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ba7e6beb-f980-4ff1-8d4b-ab3a5bfd99cd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c0e2723d-3541-4ee6-a9fb-85df1f92fd6a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("eb049361-2a6b-4123-adb9-8a229196f29e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed06208c-ee3f-449c-9d40-742035fa952e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77f7c704-ea32-4a2e-9fd3-04c184d44d4c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8660b5e6-2ca1-4c3c-91c3-5f8c366b30bb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c66dbc6f-b1c9-477a-bf6d-a8766f33e44f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e3749037-e8b0-4208-87fd-f9d0edb25b21"));

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LoginTries",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f7195df-de82-429c-a430-dc0742edf721"),
                columns: new[] { "IsBlocked", "LoginTries" },
                values: new object[] { false, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LoginTries",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("12681a02-7e54-4c6e-b447-03d51fb05a61"), null, "CanReadBorrowers" },
                    { new Guid("1b8aed2b-cd8e-4c1a-9963-548c075d72b2"), null, "CanReadApplications" },
                    { new Guid("1d0c1438-dd0c-4b05-bccd-dfccc5618ffd"), null, "CanReadUsers" },
                    { new Guid("3c956a6d-e675-45b1-8544-588761073fee"), null, "CanDeleteApplication" },
                    { new Guid("436d1756-3c07-4c05-9f15-b13c7c365f45"), null, "CanUpdateUser" },
                    { new Guid("4c2c128e-179a-4ced-96ba-081bc7a02599"), null, "CanDeleteBorrower" },
                    { new Guid("5223aad9-aa30-420d-9697-d877c3ad38ee"), null, "IsRegistered" },
                    { new Guid("5f9b10db-a5a3-4910-9c3e-a1e33613ff23"), null, "CanReadLenders" },
                    { new Guid("5fc35ff5-5795-4f95-a67a-25fd27f9eade"), null, "CanDeleteLender" },
                    { new Guid("5fc6d6da-2075-4d72-896c-1d69bc9c4a84"), null, "CanUpdateApplication" },
                    { new Guid("97398352-cb4d-44bc-b3c6-d63fc9a5f229"), null, "CanAddUser" },
                    { new Guid("b104a3d4-f7a4-4d8b-b710-a921af70cdc8"), null, "CanUpdateBorrower" },
                    { new Guid("b6ddd3b7-91a6-45ef-a458-8c011a518f09"), null, "CanAddBorrower" },
                    { new Guid("ba7e6beb-f980-4ff1-8d4b-ab3a5bfd99cd"), null, "CanAddLender" },
                    { new Guid("c0e2723d-3541-4ee6-a9fb-85df1f92fd6a"), null, "CanDeleteUser" },
                    { new Guid("eb049361-2a6b-4123-adb9-8a229196f29e"), null, "CanAddApplication" },
                    { new Guid("ed06208c-ee3f-449c-9d40-742035fa952e"), null, "CanUpdateLender" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("77f7c704-ea32-4a2e-9fd3-04c184d44d4c"), "Borrower" },
                    { new Guid("8660b5e6-2ca1-4c3c-91c3-5f8c366b30bb"), "LoanOfficerFrontOffice" },
                    { new Guid("c66dbc6f-b1c9-477a-bf6d-a8766f33e44f"), "LoanOfficerBackOffice" },
                    { new Guid("e3749037-e8b0-4208-87fd-f9d0edb25b21"), "RegisteredUser" }
                });
        }
    }
}
