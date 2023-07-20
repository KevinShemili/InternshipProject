using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0a35dece-9072-47c9-8cef-86b0f0be8398"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("36bb9a81-541b-4fbd-8bb8-e966ec4a6641"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("64d97dad-4fa2-4037-93eb-68a1f5308833"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8460f3c4-c525-47ae-90cc-e59ea99f63f8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("86334fe9-7d2b-4479-958c-ad0ca2204f83"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aca2d834-5dc3-4543-97c3-2fd96d99dc88"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b084aa7d-3cf1-4451-8558-a528f4e2a776"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c7864a00-7fdd-4daf-8e28-77942f0414ac"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f8ef35df-00f3-4502-8fca-66971d465bb4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1da1d357-0394-4f83-b3b4-16b29a713635"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("658b12d0-dfce-4c1e-9b8c-71ef2c3df992"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("71616869-c8cf-47a7-b846-764a71b063bf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d5b029cc-8d8e-4714-8b07-ef40a9818777"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2691ee93-9576-4ec8-9e8e-3c51f9876442"), null, "CanAddUser" },
                    { new Guid("2bd15eb1-2b4d-4812-a188-0a6f3881ba50"), null, "CanUpdateBorrower" },
                    { new Guid("5957ec30-1b4d-4c43-8c02-455b0e4b404a"), null, "CanReadBorrowers" },
                    { new Guid("6dd8b1ab-0be8-483f-8d1a-39d1c38ea1b6"), null, "CanDeleteBorrower" },
                    { new Guid("78b4b2d7-107c-48b3-9cdd-5e1205199013"), null, "CanUpdateUser" },
                    { new Guid("8ead3019-3e56-41a1-897d-653d2fb61f9d"), null, "CanDeleteUser" },
                    { new Guid("96da43d9-7f13-49fc-851e-93a9ec2bf5e5"), null, "CanAddBorrower" },
                    { new Guid("de1988e9-0b12-42cf-a380-ba68650f0190"), null, "IsRegistered" },
                    { new Guid("fc366061-b821-4b72-b3ea-3b35121bed57"), null, "CanReadUsers" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d887a2b-00a9-4f3d-9f13-4e1176ad841a"), "Borrower" },
                    { new Guid("7b937a94-6f4e-4625-8b23-f60de0ace3c5"), "LoanOfficerBackOffice" },
                    { new Guid("8f6c6ae8-4d3c-41f5-aaa5-bab43d4ef775"), "RegisteredUser" },
                    { new Guid("96f7332d-02b4-4fb0-9c3c-11fd64ea0596"), "LoanOfficerFrontOffice" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"), new Guid("0f7195df-de82-429c-a430-dc0742edf721") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2691ee93-9576-4ec8-9e8e-3c51f9876442"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2bd15eb1-2b4d-4812-a188-0a6f3881ba50"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5957ec30-1b4d-4c43-8c02-455b0e4b404a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6dd8b1ab-0be8-483f-8d1a-39d1c38ea1b6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("78b4b2d7-107c-48b3-9cdd-5e1205199013"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8ead3019-3e56-41a1-897d-653d2fb61f9d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("96da43d9-7f13-49fc-851e-93a9ec2bf5e5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("de1988e9-0b12-42cf-a380-ba68650f0190"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc366061-b821-4b72-b3ea-3b35121bed57"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d887a2b-00a9-4f3d-9f13-4e1176ad841a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7b937a94-6f4e-4625-8b23-f60de0ace3c5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f6c6ae8-4d3c-41f5-aaa5-bab43d4ef775"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("96f7332d-02b4-4fb0-9c3c-11fd64ea0596"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"), new Guid("0f7195df-de82-429c-a430-dc0742edf721") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0a35dece-9072-47c9-8cef-86b0f0be8398"), null, "CanAddBorrower" },
                    { new Guid("36bb9a81-541b-4fbd-8bb8-e966ec4a6641"), null, "CanAddUser" },
                    { new Guid("64d97dad-4fa2-4037-93eb-68a1f5308833"), null, "CanUpdateUser" },
                    { new Guid("8460f3c4-c525-47ae-90cc-e59ea99f63f8"), null, "CanReadBorrowers" },
                    { new Guid("86334fe9-7d2b-4479-958c-ad0ca2204f83"), null, "CanDeleteBorrower" },
                    { new Guid("aca2d834-5dc3-4543-97c3-2fd96d99dc88"), null, "IsRegistered" },
                    { new Guid("b084aa7d-3cf1-4451-8558-a528f4e2a776"), null, "CanReadUsers" },
                    { new Guid("c7864a00-7fdd-4daf-8e28-77942f0414ac"), null, "CanDeleteUser" },
                    { new Guid("f8ef35df-00f3-4502-8fca-66971d465bb4"), null, "CanUpdateBorrower" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1da1d357-0394-4f83-b3b4-16b29a713635"), "Borrower" },
                    { new Guid("658b12d0-dfce-4c1e-9b8c-71ef2c3df992"), "RegisteredUser" },
                    { new Guid("71616869-c8cf-47a7-b846-764a71b063bf"), "LoanOfficerBackOffice" },
                    { new Guid("d5b029cc-8d8e-4714-8b07-ef40a9818777"), "LoanOfficerFrontOffice" }
                });
        }
    }
}
