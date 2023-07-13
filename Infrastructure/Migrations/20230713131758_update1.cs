using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Borrowers_Id",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "Borrowers");

            migrationBuilder.AddColumn<Guid>(
                name: "BorrowerId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Applications_BorrowerId",
                table: "Applications",
                column: "BorrowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Borrowers_BorrowerId",
                table: "Applications",
                column: "BorrowerId",
                principalTable: "Borrowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Borrowers_BorrowerId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_BorrowerId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "BorrowerId",
                table: "Applications");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationId",
                table: "Borrowers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Borrowers_Id",
                table: "Applications",
                column: "Id",
                principalTable: "Borrowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
