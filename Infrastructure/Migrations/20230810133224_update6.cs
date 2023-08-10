using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("8d1ac5ed-0e1e-4de1-a7fc-a7df9e095653"),
                column: "MaxTenor",
                value: 65);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("8d1ac5ed-0e1e-4de1-a7fc-a7df9e095653"),
                column: "MaxTenor",
                value: 0);
        }
    }
}
