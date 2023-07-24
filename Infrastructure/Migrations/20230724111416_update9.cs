using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0ab1318e-464c-43a2-817c-660352a05382"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1ce58dbd-3daa-4c10-bb62-64acd62a3672"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("22621e0b-39ce-45b7-b12d-0b633ad20a03"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4556c848-737f-4339-bcce-6f6802560128"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4c9e6c65-7869-4b18-b61a-e44656caf082"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("713a3112-7182-4cd8-ab5c-0ab5a6aed2f4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7be51535-3ea5-49fe-9976-cb4c5f5426d4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("81891c16-99e0-4da4-8768-a3cc88d8bd81"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8f0a528b-44cb-482c-8515-733bf85e4ab2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a9fa6abe-b106-4afa-a10b-8c03ae18e3db"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b9737497-cb87-4a16-a938-645942e65a98"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b9fa7644-c032-4136-8dda-b4a460451f9c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c8b83f53-7b2b-4d73-b86a-de3bca2f80a4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("caf56ce1-7918-49ea-a33f-05c4132bedfe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cd204f1f-2948-417f-9c19-64bf593e6c70"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db4edb32-9bce-4849-9f89-ce70efaaa64b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fecf7811-369f-456f-9c35-4ad319fe0c63"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("13160bae-98dd-40c7-bac8-cb6bdeaf91b5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("67758d21-af58-4dfd-834e-9b4c39549645"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("69eef54f-e725-4760-8871-69145500e2b6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a29b8891-bf57-415a-8bbf-30af6222a1a6"));

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "UserVerificationAndReset",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiry",
                table: "UserVerificationAndReset",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Roles_Name",
                table: "Roles",
                column: "Name");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Permissions_Name",
                table: "Permissions",
                column: "Name");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Roles_Name",
                table: "Roles");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Permissions_Name",
                table: "Permissions");

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

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "UserVerificationAndReset");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiry",
                table: "UserVerificationAndReset");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0ab1318e-464c-43a2-817c-660352a05382"), null, "CanUpdateLender" },
                    { new Guid("1ce58dbd-3daa-4c10-bb62-64acd62a3672"), null, "CanUpdateBorrower" },
                    { new Guid("22621e0b-39ce-45b7-b12d-0b633ad20a03"), null, "CanUpdateApplication" },
                    { new Guid("4556c848-737f-4339-bcce-6f6802560128"), null, "CanReadUsers" },
                    { new Guid("4c9e6c65-7869-4b18-b61a-e44656caf082"), null, "IsRegistered" },
                    { new Guid("713a3112-7182-4cd8-ab5c-0ab5a6aed2f4"), null, "CanDeleteUser" },
                    { new Guid("7be51535-3ea5-49fe-9976-cb4c5f5426d4"), null, "CanAddUser" },
                    { new Guid("81891c16-99e0-4da4-8768-a3cc88d8bd81"), null, "CanReadApplications" },
                    { new Guid("8f0a528b-44cb-482c-8515-733bf85e4ab2"), null, "CanReadBorrowers" },
                    { new Guid("a9fa6abe-b106-4afa-a10b-8c03ae18e3db"), null, "CanReadLenders" },
                    { new Guid("b9737497-cb87-4a16-a938-645942e65a98"), null, "CanAddBorrower" },
                    { new Guid("b9fa7644-c032-4136-8dda-b4a460451f9c"), null, "CanUpdateUser" },
                    { new Guid("c8b83f53-7b2b-4d73-b86a-de3bca2f80a4"), null, "CanDeleteApplication" },
                    { new Guid("caf56ce1-7918-49ea-a33f-05c4132bedfe"), null, "CanAddLender" },
                    { new Guid("cd204f1f-2948-417f-9c19-64bf593e6c70"), null, "CanDeleteLender" },
                    { new Guid("db4edb32-9bce-4849-9f89-ce70efaaa64b"), null, "CanAddApplication" },
                    { new Guid("fecf7811-369f-456f-9c35-4ad319fe0c63"), null, "CanDeleteBorrower" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("13160bae-98dd-40c7-bac8-cb6bdeaf91b5"), "Borrower" },
                    { new Guid("67758d21-af58-4dfd-834e-9b4c39549645"), "LoanOfficerFrontOffice" },
                    { new Guid("69eef54f-e725-4760-8871-69145500e2b6"), "RegisteredUser" },
                    { new Guid("a29b8891-bf57-415a-8bbf-30af6222a1a6"), "LoanOfficerBackOffice" }
                });
        }
    }
}
