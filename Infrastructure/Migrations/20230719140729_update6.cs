using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("149a207a-6f31-454d-90c7-c546b7f9efc4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("316d231a-2f6a-4be7-88ce-0acc4dcbcdca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("43597750-002b-4610-ba72-4e1cabf78201"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("45701c72-40de-4507-b979-024b469f2c10"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7d22805b-c08d-4c67-acb8-cf944487acf2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cf10473f-0a5e-4043-aed0-78a666ed3caa"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d95de12a-b2c5-4e7d-81cd-93c89eae0fe4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e3c94563-8fdf-407b-a6a7-fdeaade72d00"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f1408e82-6e08-4f58-9b29-704c0ba40594"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("28687efb-ba28-49ac-9330-d517e299f87d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("405450de-540f-431e-b527-6a61eb7401b4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f20386c8-e2f9-4923-8e89-dca0e314f304"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f79c9e97-568f-4594-b334-be5ded406273"));

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f7195df-de82-429c-a430-dc0742edf721"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("149a207a-6f31-454d-90c7-c546b7f9efc4"), null, "CanAddUser" },
                    { new Guid("316d231a-2f6a-4be7-88ce-0acc4dcbcdca"), null, "CanUpdateBorrower" },
                    { new Guid("43597750-002b-4610-ba72-4e1cabf78201"), null, "CanDeleteUser" },
                    { new Guid("45701c72-40de-4507-b979-024b469f2c10"), null, "CanReadBorrowers" },
                    { new Guid("7d22805b-c08d-4c67-acb8-cf944487acf2"), null, "CanDeleteBorrower" },
                    { new Guid("cf10473f-0a5e-4043-aed0-78a666ed3caa"), null, "CanReadUsers" },
                    { new Guid("d95de12a-b2c5-4e7d-81cd-93c89eae0fe4"), null, "IsRegistered" },
                    { new Guid("e3c94563-8fdf-407b-a6a7-fdeaade72d00"), null, "CanUpdateUser" },
                    { new Guid("f1408e82-6e08-4f58-9b29-704c0ba40594"), null, "CanAddBorrower" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("28687efb-ba28-49ac-9330-d517e299f87d"), "RegisteredUser" },
                    { new Guid("405450de-540f-431e-b527-6a61eb7401b4"), "Borrower" },
                    { new Guid("f20386c8-e2f9-4923-8e89-dca0e314f304"), "LoanOfficerBackOffice" },
                    { new Guid("f79c9e97-568f-4594-b334-be5ded406273"), "LoanOfficerFrontOffice" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f7195df-de82-429c-a430-dc0742edf721"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "1b7b53ff57d12e357a0c8e3a5f265ecc1867686f9bfa876d3e2cad587086fa45", "tU$wPFvTddcR" });
        }
    }
}
