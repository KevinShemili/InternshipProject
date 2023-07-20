using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("33d6d7f5-b2a5-445a-9c57-cf9120929cd4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("436be2b2-dc66-4389-833d-bfa1870f55bd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4caa0372-d559-4d7d-b2bb-003e5e0206f7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("674b7e26-fa24-4af5-a047-bac007308e94"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7776ea42-dd9c-473d-b1fc-1642b67a4d16"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8b09cf3a-1aec-497c-a1db-c1e2f052e1e4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("97179470-f845-4edb-901c-1d483b51be73"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a6a29a8c-dc7d-45d1-aa12-e03bb12a4c42"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("19cd39ad-b292-4077-baee-5731e11e2614"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3944b07c-1359-4a26-b15a-f7b6c0ed8a62"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5da96922-62c3-4991-91c4-acdf07d55947"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6bcc5099-d44a-449d-95ce-077fb9ead991"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8b5ca9de-5487-464c-b021-ec3be029f8cf"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("149a207a-6f31-454d-90c7-c546b7f9efc4"), null, "CanAddUser" },
                    { new Guid("316d231a-2f6a-4be7-88ce-0acc4dcbcdca"), null, "CanUpdateBorrower" },
                    { new Guid("43597750-002b-4610-ba72-4e1cabf78201"), null, "CanDeleteUser" },
                    { new Guid("445248ae-bc8b-4a7e-90ce-1636f8206fa5"), null, "IsSuperAdmin" },
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
                    { new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"), "SuperAdmin" },
                    { new Guid("f20386c8-e2f9-4923-8e89-dca0e314f304"), "LoanOfficerBackOffice" },
                    { new Guid("f79c9e97-568f-4594-b334-be5ded406273"), "LoanOfficerFrontOffice" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsEmailConfirmed", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("0f7195df-de82-429c-a430-dc0742edf721"), "kevin.shemili@cardoai.com", "Kevin", true, "Shemili", "1b7b53ff57d12e357a0c8e3a5f265ecc1867686f9bfa876d3e2cad587086fa45", "tU$wPFvTddcR", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[] { new Guid("445248ae-bc8b-4a7e-90ce-1636f8206fa5"), new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("445248ae-bc8b-4a7e-90ce-1636f8206fa5"), new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf") });

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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f7195df-de82-429c-a430-dc0742edf721"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("445248ae-bc8b-4a7e-90ce-1636f8206fa5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("33d6d7f5-b2a5-445a-9c57-cf9120929cd4"), null, "CanUpdateBorrower" },
                    { new Guid("436be2b2-dc66-4389-833d-bfa1870f55bd"), null, "CanAddUser" },
                    { new Guid("4caa0372-d559-4d7d-b2bb-003e5e0206f7"), null, "CanDeleteUser" },
                    { new Guid("674b7e26-fa24-4af5-a047-bac007308e94"), null, "CanUpdateUser" },
                    { new Guid("7776ea42-dd9c-473d-b1fc-1642b67a4d16"), null, "CanReadUsers" },
                    { new Guid("8b09cf3a-1aec-497c-a1db-c1e2f052e1e4"), null, "CanReadBorrowers" },
                    { new Guid("97179470-f845-4edb-901c-1d483b51be73"), null, "CanDeleteBorrower" },
                    { new Guid("a6a29a8c-dc7d-45d1-aa12-e03bb12a4c42"), null, "CanAddBorrower" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("19cd39ad-b292-4077-baee-5731e11e2614"), "LoanOfficerFrontOffice" },
                    { new Guid("3944b07c-1359-4a26-b15a-f7b6c0ed8a62"), "RegisteredUser" },
                    { new Guid("5da96922-62c3-4991-91c4-acdf07d55947"), "LoanOfficerBackOffice" },
                    { new Guid("6bcc5099-d44a-449d-95ce-077fb9ead991"), "SuperAdmin" },
                    { new Guid("8b5ca9de-5487-464c-b021-ec3be029f8cf"), "Borrower" }
                });
        }
    }
}
