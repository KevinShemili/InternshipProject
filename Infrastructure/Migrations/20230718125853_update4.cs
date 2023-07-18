using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserVerificationAndReset_Users_UserId",
                table: "UserVerificationAndReset");

            migrationBuilder.DropIndex(
                name: "IX_UserVerificationAndReset_UserId",
                table: "UserVerificationAndReset");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0019a84f-d8a0-4705-a7c2-a66b13df3dc8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("66c2a2ac-c8a2-496a-9f4d-f1e2a55be78a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7439513d-7628-4f94-a1a4-9aaadfde612b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8e88b833-3f18-4822-bed7-72a64001449b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("92ff6a67-4b50-4f29-b611-a4ccb0b1fa46"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("99fa1eee-e7a2-4ffd-88b8-dbe8bf8a48f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db23c16e-b315-42f9-8345-073212d89584"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd7acfa5-aace-47dd-96ac-1aa7f9ff68af"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0a691954-417f-43b8-9273-df428f713879"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("10389a0d-3600-4518-a2be-b2c1b98f21d2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6d9a0565-8ae8-4c46-b622-045c40e50ca2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ef7f2aeb-cad0-4d79-96f9-6eed56b13764"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f0ef6ee1-1f77-4b61-9a44-3665505d8781"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserVerificationAndReset");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "UserVerificationAndReset",
                type: "nvarchar(150)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserVerificationAndReset_UserEmail",
                table: "UserVerificationAndReset",
                column: "UserEmail",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserVerificationAndReset_Users_UserEmail",
                table: "UserVerificationAndReset",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserVerificationAndReset_Users_UserEmail",
                table: "UserVerificationAndReset");

            migrationBuilder.DropIndex(
                name: "IX_UserVerificationAndReset_UserEmail",
                table: "UserVerificationAndReset");

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

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "UserVerificationAndReset");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "UserVerificationAndReset",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0019a84f-d8a0-4705-a7c2-a66b13df3dc8"), null, "CanAddUser" },
                    { new Guid("66c2a2ac-c8a2-496a-9f4d-f1e2a55be78a"), null, "CanUpdateUser" },
                    { new Guid("7439513d-7628-4f94-a1a4-9aaadfde612b"), null, "CanReadBorrowers" },
                    { new Guid("8e88b833-3f18-4822-bed7-72a64001449b"), null, "CanDeleteBorrower" },
                    { new Guid("92ff6a67-4b50-4f29-b611-a4ccb0b1fa46"), null, "CanUpdateBorrower" },
                    { new Guid("99fa1eee-e7a2-4ffd-88b8-dbe8bf8a48f5"), null, "CanAddBorrower" },
                    { new Guid("db23c16e-b315-42f9-8345-073212d89584"), null, "CanReadUsers" },
                    { new Guid("dd7acfa5-aace-47dd-96ac-1aa7f9ff68af"), null, "CanDeleteUser" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0a691954-417f-43b8-9273-df428f713879"), "LoanOfficerBackOffice" },
                    { new Guid("10389a0d-3600-4518-a2be-b2c1b98f21d2"), "RegisteredUser" },
                    { new Guid("6d9a0565-8ae8-4c46-b622-045c40e50ca2"), "LoanOfficerFrontOffice" },
                    { new Guid("ef7f2aeb-cad0-4d79-96f9-6eed56b13764"), "SuperAdmin" },
                    { new Guid("f0ef6ee1-1f77-4b61-9a44-3665505d8781"), "Borrower" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserVerificationAndReset_UserId",
                table: "UserVerificationAndReset",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserVerificationAndReset_Users_UserId",
                table: "UserVerificationAndReset",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
