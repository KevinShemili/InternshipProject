using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
