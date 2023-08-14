using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Applications");

            migrationBuilder.AddColumn<Guid>(
                name: "LoanStatusId",
                table: "Loans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationStatusId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ApplicationStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoanStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanStatuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("23eadac2-3bbb-421b-9a5b-aff07eb74c41"), "Loan Guaranteed" },
                    { new Guid("25275da5-388e-46db-a169-99e1c58d0a7b"), "Loan Disbursed" },
                    { new Guid("287c9a29-9d88-48cb-9aa7-95b33b6fb197"), "Loan Defaulted" },
                    { new Guid("2c656d64-8bcd-4c96-bb96-cd04c231199d"), "Loan Repaid" },
                    { new Guid("2fbde7f8-a9f1-4857-ac10-f818db1dc8b0"), "Loan Rejected" },
                    { new Guid("58749e4c-3bd5-4bf4-b86f-e9b0303a015e"), "Loan Canceled" },
                    { new Guid("b1f0c15d-7c24-4277-991c-5a30a40abacc"), "In Charge" }
                });

            migrationBuilder.InsertData(
                table: "LoanStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2dc1c106-6c3d-4af4-98e3-3af497a097f1"), "Erased" },
                    { new Guid("45e0d7e5-0c30-4ee0-b0c6-23379a9bd138"), "Created" },
                    { new Guid("5318a2e8-6a76-49e6-8b2f-97a8e09e5c8c"), "Repaid" },
                    { new Guid("60724bc1-b7ce-4c2a-9663-a0b5b1bd252c"), "Guaranteed" },
                    { new Guid("95269826-ee81-4f28-9783-9bc0d9996300"), "Rejected" },
                    { new Guid("e8db4469-c42e-4cdc-9848-8ae2b7ecccce"), "Defaulted" },
                    { new Guid("f28af2b0-4535-49e7-bb11-00054166a910"), "Disbursed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanStatusId",
                table: "Loans",
                column: "LoanStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationStatusId",
                table: "Applications",
                column: "ApplicationStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_ApplicationStatuses_ApplicationStatusId",
                table: "Applications",
                column: "ApplicationStatusId",
                principalTable: "ApplicationStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_LoanStatuses_LoanStatusId",
                table: "Loans",
                column: "LoanStatusId",
                principalTable: "LoanStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ApplicationStatuses_ApplicationStatusId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_LoanStatuses_LoanStatusId",
                table: "Loans");

            migrationBuilder.DropTable(
                name: "ApplicationStatuses");

            migrationBuilder.DropTable(
                name: "LoanStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Loans_LoanStatusId",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ApplicationStatusId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "LoanStatusId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ApplicationStatusId",
                table: "Applications");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Loans",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Applications",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
