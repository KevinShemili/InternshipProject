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
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("082692da-3b38-400a-a98f-b9ee67c19433"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("66e2fafa-ae81-4f1c-a24e-39f6e4033e4b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8f96605e-ee07-45f1-83c3-fa4c91263393"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b6956a5b-67b6-45a5-b431-f5ee303c4739"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("db3c566d-26a4-483b-b23f-dd606e0424f9"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("dd2c5f94-7be2-4cba-a48a-9fc540375ac9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("08e59584-1f81-4569-87cd-80d1489a39f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1ada15a4-ed51-40da-b4e4-c25e4c270866"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("31f69544-7656-404d-b5ea-11492078ca2c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("467dd1e7-dfb9-40e0-a8a8-a298cd93a230"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("58e8e4bd-c677-4f3a-b597-ed56b431efa4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("681c10d0-3dd3-4575-9240-1811ba33a4e5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("72d11591-ee3c-4efd-a6b0-60949f0db094"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("74544db4-1b55-4d8d-8a71-ddd045f7e612"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("806ec9e1-41bb-4520-ab87-9a19956713d0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("829d5b02-07e3-4ce4-bb12-1db04ecf7b2c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("86de7c1a-381f-473a-9ae7-cd2c57d891d7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9891aaaf-302d-4f5d-8885-7db67c60eb52"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9cd86dab-b4df-4120-bad1-aa448d877f93"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a1bd9f5e-f62a-46e9-a437-827279617732"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e7d606c5-bfc8-44eb-a4c0-b2d7545f32f4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f96392e4-cac7-4e4c-a21b-c41b1e443318"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fe22425b-6672-4b33-9332-00f4532f6395"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("16511fe5-73b9-49a8-8902-097757c4993a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("283a02ba-4751-476e-a4f9-6bf9b436fc25"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf653a8f-c325-4c17-bed2-646feb8ac9ea"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d0101d00-8144-4664-82a5-0d7ef4ec95fb"));

            migrationBuilder.AlterColumn<decimal>(
                name: "FinanceMinAmount",
                table: "Products",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinanceMaxAmount",
                table: "Products",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("05fb65ea-281a-4c91-8162-88654f5881fb"), null, "Partnership Limited by Shares" },
                    { new Guid("1e23d46d-83b3-4e43-a163-3a1707564b2e"), null, "Limited Partnership" },
                    { new Guid("68653ad2-e3a7-4123-986c-a4f49dc32dfd"), null, "Other" },
                    { new Guid("b988c35a-d433-4f94-a2e7-ade9a005df50"), null, "Sole Proprietorship" },
                    { new Guid("dd0398f9-90f8-4fed-8264-2b42b764455b"), null, "General Partnership" },
                    { new Guid("ede296ba-8575-4858-8860-538de0c51e8a"), null, "Cooperative Society" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("01ccad0b-ab2c-406c-a020-51c42ed98786"), null, "CanAddLender" },
                    { new Guid("0bdf307b-9fb9-46e5-ae8c-822c88cb4fb2"), null, "CanReadApplications" },
                    { new Guid("0e1093da-958c-4f55-98b9-ac5809f99ee0"), null, "CanDeleteBorrower" },
                    { new Guid("1e5a55a1-c911-4db1-9d27-1a5d998e94d2"), null, "CanUpdateLender" },
                    { new Guid("3565640c-32ca-4b5a-b2af-3e6faf7fae02"), null, "CanAddBorrower" },
                    { new Guid("4f7d8d15-9aa0-4501-b5f9-6e840ae71774"), null, "CanAddUser" },
                    { new Guid("625d2117-768f-4448-9bb1-994cc2fd7144"), null, "CanAddApplication" },
                    { new Guid("89e76aac-6e94-4a05-8d0c-3959d355a9cf"), null, "IsRegistered" },
                    { new Guid("8beda1c3-e436-4f6b-b484-4ec58cbdb95b"), null, "CanReadUsers" },
                    { new Guid("8fffec10-5ab2-42a0-ad81-7a90f3507aea"), null, "CanDeleteLender" },
                    { new Guid("b6c6907e-53bf-4715-a09e-1e6f2494b118"), null, "CanUpdateApplication" },
                    { new Guid("baa2e1ba-6358-4fb2-a69b-f00c80fc0ad6"), null, "CanReadLenders" },
                    { new Guid("bf170b0a-bc17-433c-ba45-af950f9c0b4d"), null, "CanUpdateBorrower" },
                    { new Guid("c082f992-04d7-4e23-b5a8-69ba0b59513d"), null, "CanDeleteApplication" },
                    { new Guid("cfda68d2-5cc4-4449-940f-11e3cefd30ee"), null, "CanUpdateUser" },
                    { new Guid("d8b74476-a8fe-4b25-93cf-bca159c7e94f"), null, "CanDeleteUser" },
                    { new Guid("fc73b3f0-aab0-4872-8261-5a2f48fa4ecb"), null, "CanReadBorrowers" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("0576d224-9c40-4f83-94fe-9dbc5a4785ba"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m },
                    { new Guid("5ceb91ae-e37d-45ee-975a-30d7b9ae70ab"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4bedc02d-0b8e-4184-abdf-8b03138a2a56"), "RegisteredUser" },
                    { new Guid("95a4589b-d509-41a4-95a9-e9f03e2df695"), "LoanOfficerFrontOffice" },
                    { new Guid("be5fadbe-b78c-4042-a8f2-1b2bb8e698ec"), "LoanOfficerBackOffice" },
                    { new Guid("f7c70d85-3162-446f-a28a-a820d6446309"), "Borrower" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("05fb65ea-281a-4c91-8162-88654f5881fb"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("1e23d46d-83b3-4e43-a163-3a1707564b2e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("68653ad2-e3a7-4123-986c-a4f49dc32dfd"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b988c35a-d433-4f94-a2e7-ade9a005df50"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("dd0398f9-90f8-4fed-8264-2b42b764455b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("ede296ba-8575-4858-8860-538de0c51e8a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("01ccad0b-ab2c-406c-a020-51c42ed98786"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0bdf307b-9fb9-46e5-ae8c-822c88cb4fb2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0e1093da-958c-4f55-98b9-ac5809f99ee0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1e5a55a1-c911-4db1-9d27-1a5d998e94d2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3565640c-32ca-4b5a-b2af-3e6faf7fae02"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4f7d8d15-9aa0-4501-b5f9-6e840ae71774"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("625d2117-768f-4448-9bb1-994cc2fd7144"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("89e76aac-6e94-4a05-8d0c-3959d355a9cf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8beda1c3-e436-4f6b-b484-4ec58cbdb95b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8fffec10-5ab2-42a0-ad81-7a90f3507aea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b6c6907e-53bf-4715-a09e-1e6f2494b118"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("baa2e1ba-6358-4fb2-a69b-f00c80fc0ad6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bf170b0a-bc17-433c-ba45-af950f9c0b4d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c082f992-04d7-4e23-b5a8-69ba0b59513d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cfda68d2-5cc4-4449-940f-11e3cefd30ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d8b74476-a8fe-4b25-93cf-bca159c7e94f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc73b3f0-aab0-4872-8261-5a2f48fa4ecb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0576d224-9c40-4f83-94fe-9dbc5a4785ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ceb91ae-e37d-45ee-975a-30d7b9ae70ab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4bedc02d-0b8e-4184-abdf-8b03138a2a56"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("95a4589b-d509-41a4-95a9-e9f03e2df695"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("be5fadbe-b78c-4042-a8f2-1b2bb8e698ec"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f7c70d85-3162-446f-a28a-a820d6446309"));

            migrationBuilder.AlterColumn<int>(
                name: "FinanceMinAmount",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<int>(
                name: "FinanceMaxAmount",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("082692da-3b38-400a-a98f-b9ee67c19433"), null, "Sole Proprietorship" },
                    { new Guid("66e2fafa-ae81-4f1c-a24e-39f6e4033e4b"), null, "General Partnership" },
                    { new Guid("8f96605e-ee07-45f1-83c3-fa4c91263393"), null, "Limited Partnership" },
                    { new Guid("b6956a5b-67b6-45a5-b431-f5ee303c4739"), null, "Cooperative Society" },
                    { new Guid("db3c566d-26a4-483b-b23f-dd606e0424f9"), null, "Other" },
                    { new Guid("dd2c5f94-7be2-4cba-a48a-9fc540375ac9"), null, "Partnership Limited by Shares" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("08e59584-1f81-4569-87cd-80d1489a39f5"), null, "CanAddUser" },
                    { new Guid("1ada15a4-ed51-40da-b4e4-c25e4c270866"), null, "CanUpdateLender" },
                    { new Guid("31f69544-7656-404d-b5ea-11492078ca2c"), null, "CanUpdateUser" },
                    { new Guid("467dd1e7-dfb9-40e0-a8a8-a298cd93a230"), null, "CanUpdateBorrower" },
                    { new Guid("58e8e4bd-c677-4f3a-b597-ed56b431efa4"), null, "CanReadApplications" },
                    { new Guid("681c10d0-3dd3-4575-9240-1811ba33a4e5"), null, "CanDeleteBorrower" },
                    { new Guid("72d11591-ee3c-4efd-a6b0-60949f0db094"), null, "CanAddBorrower" },
                    { new Guid("74544db4-1b55-4d8d-8a71-ddd045f7e612"), null, "CanReadUsers" },
                    { new Guid("806ec9e1-41bb-4520-ab87-9a19956713d0"), null, "CanDeleteLender" },
                    { new Guid("829d5b02-07e3-4ce4-bb12-1db04ecf7b2c"), null, "CanDeleteUser" },
                    { new Guid("86de7c1a-381f-473a-9ae7-cd2c57d891d7"), null, "CanReadLenders" },
                    { new Guid("9891aaaf-302d-4f5d-8885-7db67c60eb52"), null, "CanAddLender" },
                    { new Guid("9cd86dab-b4df-4120-bad1-aa448d877f93"), null, "CanDeleteApplication" },
                    { new Guid("a1bd9f5e-f62a-46e9-a437-827279617732"), null, "CanAddApplication" },
                    { new Guid("e7d606c5-bfc8-44eb-a4c0-b2d7545f32f4"), null, "CanUpdateApplication" },
                    { new Guid("f96392e4-cac7-4e4c-a21b-c41b1e443318"), null, "CanReadBorrowers" },
                    { new Guid("fe22425b-6672-4b33-9332-00f4532f6395"), null, "IsRegistered" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("16511fe5-73b9-49a8-8902-097757c4993a"), "LoanOfficerBackOffice" },
                    { new Guid("283a02ba-4751-476e-a4f9-6bf9b436fc25"), "RegisteredUser" },
                    { new Guid("bf653a8f-c325-4c17-bed2-646feb8ac9ea"), "LoanOfficerFrontOffice" },
                    { new Guid("d0101d00-8144-4664-82a5-0d7ef4ec95fb"), "Borrower" }
                });
        }
    }
}
