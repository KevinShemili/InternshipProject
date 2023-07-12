using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("7a7a0afb-d09e-42ae-9e6b-211dad68ec5a"), null, "Edit" },
                    { new Guid("8adf553d-91dd-45b3-9239-c7660f584b13"), null, "Read" },
                    { new Guid("a73eb1ab-23ba-48ef-80f0-1c633dbe4903"), null, "Delete" },
                    { new Guid("f6d80c94-df40-403b-a622-16b46576996e"), null, "Write" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: new Guid("7a7a0afb-d09e-42ae-9e6b-211dad68ec5a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: new Guid("8adf553d-91dd-45b3-9239-c7660f584b13"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: new Guid("a73eb1ab-23ba-48ef-80f0-1c633dbe4903"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: new Guid("f6d80c94-df40-403b-a622-16b46576996e"));
        }
    }
}
