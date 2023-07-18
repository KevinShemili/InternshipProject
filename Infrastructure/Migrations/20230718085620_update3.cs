using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("24ca7b16-afe6-4b04-bff7-b4b2559652ce"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3589e121-b290-497e-89d7-10662154fe16"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4a7b282c-b77f-4d86-a868-6239f9370143"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4ef7ff48-45ef-482a-bfe6-0953085409eb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5a20d3d6-f98c-4285-ae93-e2bd4aa857d7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5bd4b010-1390-470f-9c86-26ef8d763956"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6211c6f8-8d41-4704-ac64-70c45dc59e24"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("69c24030-c725-4c35-a6ee-ee5bc74b9054"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("13bd869f-500c-40e2-9301-065e44026f00"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3e684060-2393-4fdd-8ffe-d6b43b091391"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6faa8c96-496b-47fa-9e07-c55d4c6cc3df"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8265a5a5-7019-4b33-967b-21d48ba12dfb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e6546504-09bf-4a0b-bb2f-7c73e0e32188"));

            migrationBuilder.AddColumn<bool>(
                name: "IsEmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "UserVerificationAndReset",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailVerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailVerificationTokenExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordResetTokenExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVerificationAndReset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserVerificationAndReset_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserVerificationAndReset");

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
                name: "IsEmailConfirmed",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("24ca7b16-afe6-4b04-bff7-b4b2559652ce"), null, "CanReadUsers" },
                    { new Guid("3589e121-b290-497e-89d7-10662154fe16"), null, "CanDeleteBorrower" },
                    { new Guid("4a7b282c-b77f-4d86-a868-6239f9370143"), null, "CanUpdateBorrower" },
                    { new Guid("4ef7ff48-45ef-482a-bfe6-0953085409eb"), null, "CanReadBorrowers" },
                    { new Guid("5a20d3d6-f98c-4285-ae93-e2bd4aa857d7"), null, "CanDeleteUser" },
                    { new Guid("5bd4b010-1390-470f-9c86-26ef8d763956"), null, "CanUpdateUser" },
                    { new Guid("6211c6f8-8d41-4704-ac64-70c45dc59e24"), null, "CanAddBorrower" },
                    { new Guid("69c24030-c725-4c35-a6ee-ee5bc74b9054"), null, "CanAddUser" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("13bd869f-500c-40e2-9301-065e44026f00"), "Borrower" },
                    { new Guid("3e684060-2393-4fdd-8ffe-d6b43b091391"), "LoanOfficerFrontOffice" },
                    { new Guid("6faa8c96-496b-47fa-9e07-c55d4c6cc3df"), "LoanOfficerBackOffice" },
                    { new Guid("8265a5a5-7019-4b33-967b-21d48ba12dfb"), "SuperAdmin" },
                    { new Guid("e6546504-09bf-4a0b-bb2f-7c73e0e32188"), "RegisteredUser" }
                });
        }
    }
}
