using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("058b7e53-4440-4bd1-9285-6ac744509981"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("20f8161e-01cf-452b-a89e-7cea4702cad0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("22dd2335-6004-4c24-b574-f7df389655a6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("24c2719e-da95-44cc-9408-99202f7a3ecd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("478cc517-a9c7-490a-8e54-b70e7b56ba83"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6c790f15-bf5a-475b-92e3-2812a61ca176"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7d6f81f9-e16c-4844-a4b2-302b2801475a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8002375d-5477-4b8e-aa37-ca846073a0ed"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8f5e4281-8f9e-4de5-a6c7-f8e08ce92f29"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("94c8723c-76d6-4e11-a2b1-3e145a6373ca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9935308b-0ba5-491e-82d0-4b76b498831c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("997e7036-519c-4bb3-b901-058c953f7384"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b1b34adc-c279-4db7-a199-95b673d89a9e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c291950b-abae-48ef-98a2-d90c3c0fc242"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d35f05ed-c82f-4ae9-913a-79357930d960"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f293a0fb-a924-4299-93a2-7ceb8ef88f14"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f6d1423f-5155-4aca-aded-64303a78fb80"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d75cb81-7177-40fe-81db-113b9f965cd3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("24acbea6-a2d3-489a-bf05-464a7b8c4550"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6a688599-bd18-4f5d-84c4-c8af6cd6adf8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eb5549c5-e4cf-4bee-8844-3cca8b865614"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpiry",
                table: "UserVerificationAndReset",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpiry",
                table: "UserVerificationAndReset",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("058b7e53-4440-4bd1-9285-6ac744509981"), null, "CanUpdateLender" },
                    { new Guid("20f8161e-01cf-452b-a89e-7cea4702cad0"), null, "CanReadBorrowers" },
                    { new Guid("22dd2335-6004-4c24-b574-f7df389655a6"), null, "CanUpdateApplication" },
                    { new Guid("24c2719e-da95-44cc-9408-99202f7a3ecd"), null, "CanDeleteLender" },
                    { new Guid("478cc517-a9c7-490a-8e54-b70e7b56ba83"), null, "CanAddApplication" },
                    { new Guid("6c790f15-bf5a-475b-92e3-2812a61ca176"), null, "CanUpdateUser" },
                    { new Guid("7d6f81f9-e16c-4844-a4b2-302b2801475a"), null, "CanReadLenders" },
                    { new Guid("8002375d-5477-4b8e-aa37-ca846073a0ed"), null, "CanDeleteUser" },
                    { new Guid("8f5e4281-8f9e-4de5-a6c7-f8e08ce92f29"), null, "CanAddUser" },
                    { new Guid("94c8723c-76d6-4e11-a2b1-3e145a6373ca"), null, "CanReadUsers" },
                    { new Guid("9935308b-0ba5-491e-82d0-4b76b498831c"), null, "CanDeleteBorrower" },
                    { new Guid("997e7036-519c-4bb3-b901-058c953f7384"), null, "CanUpdateBorrower" },
                    { new Guid("b1b34adc-c279-4db7-a199-95b673d89a9e"), null, "CanDeleteApplication" },
                    { new Guid("c291950b-abae-48ef-98a2-d90c3c0fc242"), null, "CanAddLender" },
                    { new Guid("d35f05ed-c82f-4ae9-913a-79357930d960"), null, "CanAddBorrower" },
                    { new Guid("f293a0fb-a924-4299-93a2-7ceb8ef88f14"), null, "CanReadApplications" },
                    { new Guid("f6d1423f-5155-4aca-aded-64303a78fb80"), null, "IsRegistered" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d75cb81-7177-40fe-81db-113b9f965cd3"), "Borrower" },
                    { new Guid("24acbea6-a2d3-489a-bf05-464a7b8c4550"), "LoanOfficerBackOffice" },
                    { new Guid("6a688599-bd18-4f5d-84c4-c8af6cd6adf8"), "RegisteredUser" },
                    { new Guid("eb5549c5-e4cf-4bee-8844-3cca8b865614"), "LoanOfficerFrontOffice" }
                });
        }
    }
}
