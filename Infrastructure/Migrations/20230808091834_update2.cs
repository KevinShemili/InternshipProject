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
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ProductMatrices_ProductMatrixId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ProductMatrixId",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMatrices",
                table: "ProductMatrices");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("04aa56ad-f172-4d2a-8cbf-0d4d5c5f094a"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("2b40e4ec-1447-4c4b-a5fc-75d3952d7929"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("40c976c2-db8f-4aa5-90df-97c01372f2b0"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("867dfba2-01f7-45c7-8072-5353b2a65de7"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b49e6400-f740-4d42-bf96-dff30937e79a"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("f51c57fd-7e6c-436a-ad50-f28e41fe53ca"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("89134181-5289-417a-bc73-b83095569368"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("ad981a0c-86c9-4ae3-9a89-2102a5c9e850"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("e0b40194-d4d5-4f4e-91bd-01d43926399d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6727daa-e20c-429b-bd6d-d3ab89a29484"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df4e0010-1a04-4cc0-926d-7e6c2d5a39d7"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("076fd221-24a4-49d3-84ae-010446253b44"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("08e9525b-37d5-46d6-877e-104675d1c14b"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3a5a8ef3-cef3-4a58-9d11-40a160925fd6"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3e5bed87-925b-42c3-b9a8-f07b6990a410"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("497890a5-8b1b-46d3-a941-92afee79c271"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("a4c76dc8-e376-429e-be0d-4a1c3b98b639"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("b12f238e-4aff-43ea-8dde-a5a03db886e4"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("3e5bed87-925b-42c3-b9a8-f07b6990a410"), new Guid("8668b4c8-f48b-475c-9535-5ec6c7fc1b27") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("b8606038-84c7-4661-ac73-22344c22033a"), new Guid("8668b4c8-f48b-475c-9535-5ec6c7fc1b27") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("0d748f52-561e-4704-8a29-acb963c9c0ab"), new Guid("aafe37e4-8ee6-4e83-91af-1289fe4a067d") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("6dc8c3f5-51ef-4fc5-9991-e004bfa28cc2"), new Guid("ad493941-b7c7-4e31-8b13-de8d0ca34b62") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("98f1d261-e838-4186-8c0d-c0d96d0d3bf4"), new Guid("ad493941-b7c7-4e31-8b13-de8d0ca34b62") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("d36c92ce-ce45-4799-95c2-00928794fd7f"), new Guid("ad493941-b7c7-4e31-8b13-de8d0ca34b62") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("aafe37e4-8ee6-4e83-91af-1289fe4a067d"), new Guid("b3f6a1c8-41ad-4b4a-8a0b-f95c6a912257") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("076fd221-24a4-49d3-84ae-010446253b44"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("08e9525b-37d5-46d6-877e-104675d1c14b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0d748f52-561e-4704-8a29-acb963c9c0ab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3a5a8ef3-cef3-4a58-9d11-40a160925fd6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3e5bed87-925b-42c3-b9a8-f07b6990a410"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("497890a5-8b1b-46d3-a941-92afee79c271"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6dc8c3f5-51ef-4fc5-9991-e004bfa28cc2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("98f1d261-e838-4186-8c0d-c0d96d0d3bf4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a4c76dc8-e376-429e-be0d-4a1c3b98b639"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b12f238e-4aff-43ea-8dde-a5a03db886e4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b8606038-84c7-4661-ac73-22344c22033a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d36c92ce-ce45-4799-95c2-00928794fd7f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8668b4c8-f48b-475c-9535-5ec6c7fc1b27"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("aafe37e4-8ee6-4e83-91af-1289fe4a067d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ad493941-b7c7-4e31-8b13-de8d0ca34b62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3f6a1c8-41ad-4b4a-8a0b-f95c6a912257"));

            migrationBuilder.DropColumn(
                name: "ProductMatrixId",
                table: "Applications");

            migrationBuilder.RenameTable(
                name: "ProductMatrices",
                newName: "LenderMatrices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LenderMatrices",
                table: "LenderMatrices",
                column: "Id");

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("0b00f1d6-56df-45f6-a575-c693df004d03"), null, "Partnership Limited by Shares" },
                    { new Guid("17d747b8-7695-4fd9-8eaf-38c1930f10bd"), null, "Cooperative Society" },
                    { new Guid("282ccac5-ffb4-4d85-bd7c-bbae48b753bd"), null, "Limited Partnership" },
                    { new Guid("69421fa1-3116-49b0-80fa-5c7bdbe77e59"), null, "General Partnership" },
                    { new Guid("7d291cfe-7319-428f-b30f-58e880021e9f"), null, "Other" },
                    { new Guid("8386f64a-8757-458a-bd73-1af1e641b1a6"), null, "Sole Proprietorship" }
                });

            migrationBuilder.InsertData(
                table: "Lenders",
                columns: new[] { "Id", "BorrowerCompanyType", "MaxTenor", "MinTenor", "Name", "RequestedAmount" },
                values: new object[,]
                {
                    { new Guid("190f3ceb-46e4-4953-84df-4bb7589fd822"), "Partnership Limited by Shares", 60, 40, "AZIF", 400000 },
                    { new Guid("ee142133-dc54-49b7-b1fe-07108226344b"), "Cooperative Society", 0, 30, "PMI BTECH", 100000 },
                    { new Guid("ff663709-cdf4-43dd-84d9-522a7e19635a"), "Sole Proprietorship", 60, 30, "PMI BTECH", 100000 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("09f0f634-7361-4d7c-9ca2-0dc8ae4fedea"), null, "CanReadOwnBorrowers" },
                    { new Guid("1dc3cd7e-3e02-4d0c-9b49-7c5e831c6718"), null, "CanDeleteApplication" },
                    { new Guid("346b8cc8-5c89-4695-b22c-a7ab457e5c90"), null, "CanDeleteBorrower" },
                    { new Guid("58b90d78-677d-4404-bf67-a632499a43ee"), null, "IsRegistered" },
                    { new Guid("58de110a-650b-47bd-9605-f74e539f16ab"), null, "CanUpdateApplication" },
                    { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), null, "CanAddBorrower" },
                    { new Guid("8a042266-b542-45c4-af4e-304049986643"), null, "CanReadOwnApplications" },
                    { new Guid("c947dc46-bc7c-407c-9ad8-e2050d24b9c7"), null, "IsSuperAdmin" },
                    { new Guid("d1f8563a-8afe-4539-a887-77b356c38141"), null, "CanReadBorrowers" },
                    { new Guid("e1771e48-ea3b-4a56-93ca-02f62c5e9cbb"), null, "CanUpdateBorrower" },
                    { new Guid("ed0a6095-d8ab-4b15-815d-cf0b14a5ab0a"), null, "CanReadApplications" },
                    { new Guid("f4134d5e-1def-46f1-8615-c318141e0aaf"), null, "CanAddApplication" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("2a446505-7a64-4865-a4e8-b70342f2ec95"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m },
                    { new Guid("50f23242-e5b0-4819-9c87-1aabcd9e4fcf"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf"), "RegisteredUser" },
                    { new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d"), "LoanOfficer" },
                    { new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd"), "Borrower" },
                    { new Guid("f6146789-7d87-470b-bd72-45d88209f05d"), "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("5a9dbbd4-8ae9-4be6-b785-f215eed29e2d"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("58b90d78-677d-4404-bf67-a632499a43ee"), new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf") },
                    { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf") },
                    { new Guid("58de110a-650b-47bd-9605-f74e539f16ab"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") },
                    { new Guid("d1f8563a-8afe-4539-a887-77b356c38141"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") },
                    { new Guid("ed0a6095-d8ab-4b15-815d-cf0b14a5ab0a"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") },
                    { new Guid("09f0f634-7361-4d7c-9ca2-0dc8ae4fedea"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("1dc3cd7e-3e02-4d0c-9b49-7c5e831c6718"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("346b8cc8-5c89-4695-b22c-a7ab457e5c90"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("8a042266-b542-45c4-af4e-304049986643"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("e1771e48-ea3b-4a56-93ca-02f62c5e9cbb"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("f4134d5e-1def-46f1-8615-c318141e0aaf"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") },
                    { new Guid("c947dc46-bc7c-407c-9ad8-e2050d24b9c7"), new Guid("f6146789-7d87-470b-bd72-45d88209f05d") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f6146789-7d87-470b-bd72-45d88209f05d"), new Guid("5a9dbbd4-8ae9-4be6-b785-f215eed29e2d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LenderMatrices",
                table: "LenderMatrices");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("0b00f1d6-56df-45f6-a575-c693df004d03"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("17d747b8-7695-4fd9-8eaf-38c1930f10bd"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("282ccac5-ffb4-4d85-bd7c-bbae48b753bd"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("69421fa1-3116-49b0-80fa-5c7bdbe77e59"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7d291cfe-7319-428f-b30f-58e880021e9f"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8386f64a-8757-458a-bd73-1af1e641b1a6"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("190f3ceb-46e4-4953-84df-4bb7589fd822"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("ee142133-dc54-49b7-b1fe-07108226344b"));

            migrationBuilder.DeleteData(
                table: "Lenders",
                keyColumn: "Id",
                keyValue: new Guid("ff663709-cdf4-43dd-84d9-522a7e19635a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a446505-7a64-4865-a4e8-b70342f2ec95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50f23242-e5b0-4819-9c87-1aabcd9e4fcf"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("58b90d78-677d-4404-bf67-a632499a43ee"), new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("58de110a-650b-47bd-9605-f74e539f16ab"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("d1f8563a-8afe-4539-a887-77b356c38141"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("ed0a6095-d8ab-4b15-815d-cf0b14a5ab0a"), new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("09f0f634-7361-4d7c-9ca2-0dc8ae4fedea"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("1dc3cd7e-3e02-4d0c-9b49-7c5e831c6718"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("346b8cc8-5c89-4695-b22c-a7ab457e5c90"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("8a042266-b542-45c4-af4e-304049986643"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("e1771e48-ea3b-4a56-93ca-02f62c5e9cbb"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("f4134d5e-1def-46f1-8615-c318141e0aaf"), new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("c947dc46-bc7c-407c-9ad8-e2050d24b9c7"), new Guid("f6146789-7d87-470b-bd72-45d88209f05d") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f6146789-7d87-470b-bd72-45d88209f05d"), new Guid("5a9dbbd4-8ae9-4be6-b785-f215eed29e2d") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("09f0f634-7361-4d7c-9ca2-0dc8ae4fedea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1dc3cd7e-3e02-4d0c-9b49-7c5e831c6718"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("346b8cc8-5c89-4695-b22c-a7ab457e5c90"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("58b90d78-677d-4404-bf67-a632499a43ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("58de110a-650b-47bd-9605-f74e539f16ab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7c0676fd-0a38-4da1-a5df-25687283711f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8a042266-b542-45c4-af4e-304049986643"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c947dc46-bc7c-407c-9ad8-e2050d24b9c7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d1f8563a-8afe-4539-a887-77b356c38141"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e1771e48-ea3b-4a56-93ca-02f62c5e9cbb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed0a6095-d8ab-4b15-815d-cf0b14a5ab0a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f4134d5e-1def-46f1-8615-c318141e0aaf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("49f9e70c-0b3e-46e9-9960-81110e0e36bf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54fbbba4-1e37-4172-a749-aa6b475a798d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c6d84795-9e42-4d8d-9148-15e864f0aafd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f6146789-7d87-470b-bd72-45d88209f05d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a9dbbd4-8ae9-4be6-b785-f215eed29e2d"));

            migrationBuilder.RenameTable(
                name: "LenderMatrices",
                newName: "ProductMatrices");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductMatrixId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMatrices",
                table: "ProductMatrices",
                column: "Id");

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("04aa56ad-f172-4d2a-8cbf-0d4d5c5f094a"), null, "Cooperative Society" },
                    { new Guid("2b40e4ec-1447-4c4b-a5fc-75d3952d7929"), null, "Other" },
                    { new Guid("40c976c2-db8f-4aa5-90df-97c01372f2b0"), null, "General Partnership" },
                    { new Guid("867dfba2-01f7-45c7-8072-5353b2a65de7"), null, "Partnership Limited by Shares" },
                    { new Guid("b49e6400-f740-4d42-bf96-dff30937e79a"), null, "Sole Proprietorship" },
                    { new Guid("f51c57fd-7e6c-436a-ad50-f28e41fe53ca"), null, "Limited Partnership" }
                });

            migrationBuilder.InsertData(
                table: "Lenders",
                columns: new[] { "Id", "BorrowerCompanyType", "MaxTenor", "MinTenor", "Name", "RequestedAmount" },
                values: new object[,]
                {
                    { new Guid("89134181-5289-417a-bc73-b83095569368"), "Cooperative Society", 0, 30, "PMI BTECH", 100000 },
                    { new Guid("ad981a0c-86c9-4ae3-9a89-2102a5c9e850"), "Sole Proprietorship", 60, 30, "PMI BTECH", 100000 },
                    { new Guid("e0b40194-d4d5-4f4e-91bd-01d43926399d"), "Partnership Limited by Shares", 60, 40, "AZIF", 400000 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("076fd221-24a4-49d3-84ae-010446253b44"), null, "CanDeleteApplication" },
                    { new Guid("08e9525b-37d5-46d6-877e-104675d1c14b"), null, "CanDeleteBorrower" },
                    { new Guid("0d748f52-561e-4704-8a29-acb963c9c0ab"), null, "IsSuperAdmin" },
                    { new Guid("3a5a8ef3-cef3-4a58-9d11-40a160925fd6"), null, "CanReadOwnBorrowers" },
                    { new Guid("3e5bed87-925b-42c3-b9a8-f07b6990a410"), null, "CanAddBorrower" },
                    { new Guid("497890a5-8b1b-46d3-a941-92afee79c271"), null, "CanAddApplication" },
                    { new Guid("6dc8c3f5-51ef-4fc5-9991-e004bfa28cc2"), null, "CanReadApplications" },
                    { new Guid("98f1d261-e838-4186-8c0d-c0d96d0d3bf4"), null, "CanReadBorrowers" },
                    { new Guid("a4c76dc8-e376-429e-be0d-4a1c3b98b639"), null, "CanReadOwnApplications" },
                    { new Guid("b12f238e-4aff-43ea-8dde-a5a03db886e4"), null, "CanUpdateBorrower" },
                    { new Guid("b8606038-84c7-4661-ac73-22344c22033a"), null, "IsRegistered" },
                    { new Guid("d36c92ce-ce45-4799-95c2-00928794fd7f"), null, "CanUpdateApplication" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("d6727daa-e20c-429b-bd6d-d3ab89a29484"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m },
                    { new Guid("df4e0010-1a04-4cc0-926d-7e6c2d5a39d7"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3"), "Borrower" },
                    { new Guid("8668b4c8-f48b-475c-9535-5ec6c7fc1b27"), "RegisteredUser" },
                    { new Guid("aafe37e4-8ee6-4e83-91af-1289fe4a067d"), "SuperAdmin" },
                    { new Guid("ad493941-b7c7-4e31-8b13-de8d0ca34b62"), "LoanOfficer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("b3f6a1c8-41ad-4b4a-8a0b-f95c6a912257"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("076fd221-24a4-49d3-84ae-010446253b44"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") },
                    { new Guid("08e9525b-37d5-46d6-877e-104675d1c14b"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") },
                    { new Guid("3a5a8ef3-cef3-4a58-9d11-40a160925fd6"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") },
                    { new Guid("3e5bed87-925b-42c3-b9a8-f07b6990a410"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") },
                    { new Guid("497890a5-8b1b-46d3-a941-92afee79c271"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") },
                    { new Guid("a4c76dc8-e376-429e-be0d-4a1c3b98b639"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") },
                    { new Guid("b12f238e-4aff-43ea-8dde-a5a03db886e4"), new Guid("2da9c28e-e557-44c5-bbd9-8978f5c1c9f3") },
                    { new Guid("3e5bed87-925b-42c3-b9a8-f07b6990a410"), new Guid("8668b4c8-f48b-475c-9535-5ec6c7fc1b27") },
                    { new Guid("b8606038-84c7-4661-ac73-22344c22033a"), new Guid("8668b4c8-f48b-475c-9535-5ec6c7fc1b27") },
                    { new Guid("0d748f52-561e-4704-8a29-acb963c9c0ab"), new Guid("aafe37e4-8ee6-4e83-91af-1289fe4a067d") },
                    { new Guid("6dc8c3f5-51ef-4fc5-9991-e004bfa28cc2"), new Guid("ad493941-b7c7-4e31-8b13-de8d0ca34b62") },
                    { new Guid("98f1d261-e838-4186-8c0d-c0d96d0d3bf4"), new Guid("ad493941-b7c7-4e31-8b13-de8d0ca34b62") },
                    { new Guid("d36c92ce-ce45-4799-95c2-00928794fd7f"), new Guid("ad493941-b7c7-4e31-8b13-de8d0ca34b62") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("aafe37e4-8ee6-4e83-91af-1289fe4a067d"), new Guid("b3f6a1c8-41ad-4b4a-8a0b-f95c6a912257") });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProductMatrixId",
                table: "Applications",
                column: "ProductMatrixId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_ProductMatrices_ProductMatrixId",
                table: "Applications",
                column: "ProductMatrixId",
                principalTable: "ProductMatrices",
                principalColumn: "Id");
        }
    }
}
