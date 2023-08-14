using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("537b42bd-db04-4db1-b4d8-c945a63116f6"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("e12c2b57-de8b-4191-a325-ab74c712e7dd"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("537b42bd-db04-4db1-b4d8-c945a63116f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e12c2b57-de8b-4191-a325-ab74c712e7dd"));

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("67d5fd0e-f3a4-4aa7-bef8-8a587bcb475e"),
                column: "Description",
                value: "Description");

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7db974f8-6321-4b35-8ef4-65edda9fe1d6"),
                column: "Description",
                value: "Description");

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a7eea608-196c-4a52-a5c7-9694e0eb190b"),
                column: "Description",
                value: "Description");

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("afbb07dd-70ad-471d-8448-67539b17b872"),
                column: "Description",
                value: "Description");

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b2b5ce14-79b1-402e-92f5-2536bce91dda"),
                column: "Description",
                value: "Description");

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("be9a7220-0773-4d4d-8ef7-b5fbf480e952"),
                column: "Description",
                value: "Description");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ff6a3be-482e-4826-b027-b7aea05de030"),
                column: "Description",
                value: "Description");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2c0e6ae-2a83-4fd3-acce-dd1c647b1b1c"),
                columns: new[] { "Description", "ReferenceRate" },
                values: new object[] { "Description", 0.0025m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("67d5fd0e-f3a4-4aa7-bef8-8a587bcb475e"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7db974f8-6321-4b35-8ef4-65edda9fe1d6"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a7eea608-196c-4a52-a5c7-9694e0eb190b"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("afbb07dd-70ad-471d-8448-67539b17b872"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b2b5ce14-79b1-402e-92f5-2536bce91dda"),
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("be9a7220-0773-4d4d-8ef7-b5fbf480e952"),
                column: "Description",
                value: null);

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("537b42bd-db04-4db1-b4d8-c945a63116f6"), null, "CanDeleteBorrower" },
                    { new Guid("e12c2b57-de8b-4191-a325-ab74c712e7dd"), null, "CanDeleteApplication" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ff6a3be-482e-4826-b027-b7aea05de030"),
                column: "Description",
                value: "Installments with pre-amortization at a fixed rate");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2c0e6ae-2a83-4fd3-acce-dd1c647b1b1c"),
                columns: new[] { "Description", "ReferenceRate" },
                values: new object[] { "Installment with variable rate pre-amortization", 0.03m });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("537b42bd-db04-4db1-b4d8-c945a63116f6"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") },
                    { new Guid("e12c2b57-de8b-4191-a325-ab74c712e7dd"), new Guid("b05d025a-62ee-4d6c-aef4-9433cc52dcd0") }
                });
        }
    }
}
