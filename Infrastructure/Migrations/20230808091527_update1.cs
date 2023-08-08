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
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMatrices_Applications_ApplicationId",
                table: "ProductMatrices");

            migrationBuilder.DropIndex(
                name: "IX_ProductMatrices_ApplicationId",
                table: "ProductMatrices");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("21fe46f1-c27e-4724-b6ca-3542420b8545"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("2d9b10e9-67f0-4c7d-8fd8-d6467437e478"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("30ae2255-dc30-41c6-8cc2-910c69b8b9e6"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("41a47e50-2399-4fb8-9d3d-22f7feb1bd9e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8f985cc7-128f-4be7-9988-904b40b8317f"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a581a59c-8836-42dc-85e4-27d878eaa29f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b13ef33-6fae-4e35-bce6-343be6cc8bd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab105905-f008-40fe-bc5a-ca13711a3c2a"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("0382e628-c695-4dbd-8aeb-2547708724fc"), new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("dd6d543c-bf19-4e9c-b928-af274cce0f74"), new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("df4edda6-1227-48fd-ac8d-eea9e96f370b"), new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("09ba0246-8a00-4feb-b64a-a1a207ee6bbd"), new Guid("947f29d9-1d93-4f14-aaf2-d7a8b6c712e8") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("0e079ddf-db6f-45bb-81c2-37c916cde117"), new Guid("b6803092-61f0-4aa7-9a77-c0e54154f451") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("519fbfeb-85ba-4d2d-8233-ba4c94a5c6f7"), new Guid("b6803092-61f0-4aa7-9a77-c0e54154f451") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("0656b88e-a20f-44f1-87e1-26eeecf11f0d"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("2447a86e-c937-4faf-bd42-f9b8fdcc14f6"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("519fbfeb-85ba-4d2d-8233-ba4c94a5c6f7"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("a9a16378-0bdc-429e-809f-6360ef88bb4d"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("dbb1b093-4f74-43ff-902f-9afe8f752952"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("e2f39824-c765-4971-869f-77fbb230b276"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("f47606a8-47e3-48fe-8e5f-ba904b4d1e3d"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("947f29d9-1d93-4f14-aaf2-d7a8b6c712e8"), new Guid("79bd95cd-4401-4fd8-92ec-1e1988fb440c") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0382e628-c695-4dbd-8aeb-2547708724fc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0656b88e-a20f-44f1-87e1-26eeecf11f0d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("09ba0246-8a00-4feb-b64a-a1a207ee6bbd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0e079ddf-db6f-45bb-81c2-37c916cde117"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2447a86e-c937-4faf-bd42-f9b8fdcc14f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("519fbfeb-85ba-4d2d-8233-ba4c94a5c6f7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a9a16378-0bdc-429e-809f-6360ef88bb4d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dbb1b093-4f74-43ff-902f-9afe8f752952"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd6d543c-bf19-4e9c-b928-af274cce0f74"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("df4edda6-1227-48fd-ac8d-eea9e96f370b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e2f39824-c765-4971-869f-77fbb230b276"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f47606a8-47e3-48fe-8e5f-ba904b4d1e3d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("947f29d9-1d93-4f14-aaf2-d7a8b6c712e8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b6803092-61f0-4aa7-9a77-c0e54154f451"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c7493473-195e-485f-9e11-22be3c4599de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79bd95cd-4401-4fd8-92ec-1e1988fb440c"));

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "ProductMatrices");

            migrationBuilder.RenameColumn(
                name: "Tenor",
                table: "Lenders",
                newName: "MinTenor");

            migrationBuilder.AddColumn<int>(
                name: "MaxTenor",
                table: "Lenders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductMatrixId",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ProductMatrices_ProductMatrixId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ProductMatrixId",
                table: "Applications");

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
                name: "MaxTenor",
                table: "Lenders");

            migrationBuilder.DropColumn(
                name: "ProductMatrixId",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "MinTenor",
                table: "Lenders",
                newName: "Tenor");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationId",
                table: "ProductMatrices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("21fe46f1-c27e-4724-b6ca-3542420b8545"), null, "General Partnership" },
                    { new Guid("2d9b10e9-67f0-4c7d-8fd8-d6467437e478"), null, "Sole Proprietorship" },
                    { new Guid("30ae2255-dc30-41c6-8cc2-910c69b8b9e6"), null, "Other" },
                    { new Guid("41a47e50-2399-4fb8-9d3d-22f7feb1bd9e"), null, "Limited Partnership" },
                    { new Guid("8f985cc7-128f-4be7-9988-904b40b8317f"), null, "Partnership Limited by Shares" },
                    { new Guid("a581a59c-8836-42dc-85e4-27d878eaa29f"), null, "Cooperative Society" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0382e628-c695-4dbd-8aeb-2547708724fc"), null, "CanUpdateApplication" },
                    { new Guid("0656b88e-a20f-44f1-87e1-26eeecf11f0d"), null, "CanDeleteBorrower" },
                    { new Guid("09ba0246-8a00-4feb-b64a-a1a207ee6bbd"), null, "IsSuperAdmin" },
                    { new Guid("0e079ddf-db6f-45bb-81c2-37c916cde117"), null, "IsRegistered" },
                    { new Guid("2447a86e-c937-4faf-bd42-f9b8fdcc14f6"), null, "CanReadOwnApplications" },
                    { new Guid("519fbfeb-85ba-4d2d-8233-ba4c94a5c6f7"), null, "CanAddBorrower" },
                    { new Guid("a9a16378-0bdc-429e-809f-6360ef88bb4d"), null, "CanReadOwnBorrowers" },
                    { new Guid("dbb1b093-4f74-43ff-902f-9afe8f752952"), null, "CanDeleteApplication" },
                    { new Guid("dd6d543c-bf19-4e9c-b928-af274cce0f74"), null, "CanReadBorrowers" },
                    { new Guid("df4edda6-1227-48fd-ac8d-eea9e96f370b"), null, "CanReadApplications" },
                    { new Guid("e2f39824-c765-4971-869f-77fbb230b276"), null, "CanAddApplication" },
                    { new Guid("f47606a8-47e3-48fe-8e5f-ba904b4d1e3d"), null, "CanUpdateBorrower" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("1b13ef33-6fae-4e35-bce6-343be6cc8bd2"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m },
                    { new Guid("ab105905-f008-40fe-bc5a-ca13711a3c2a"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb"), "LoanOfficer" },
                    { new Guid("947f29d9-1d93-4f14-aaf2-d7a8b6c712e8"), "SuperAdmin" },
                    { new Guid("b6803092-61f0-4aa7-9a77-c0e54154f451"), "RegisteredUser" },
                    { new Guid("c7493473-195e-485f-9e11-22be3c4599de"), "Borrower" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("79bd95cd-4401-4fd8-92ec-1e1988fb440c"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0382e628-c695-4dbd-8aeb-2547708724fc"), new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb") },
                    { new Guid("dd6d543c-bf19-4e9c-b928-af274cce0f74"), new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb") },
                    { new Guid("df4edda6-1227-48fd-ac8d-eea9e96f370b"), new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb") },
                    { new Guid("09ba0246-8a00-4feb-b64a-a1a207ee6bbd"), new Guid("947f29d9-1d93-4f14-aaf2-d7a8b6c712e8") },
                    { new Guid("0e079ddf-db6f-45bb-81c2-37c916cde117"), new Guid("b6803092-61f0-4aa7-9a77-c0e54154f451") },
                    { new Guid("519fbfeb-85ba-4d2d-8233-ba4c94a5c6f7"), new Guid("b6803092-61f0-4aa7-9a77-c0e54154f451") },
                    { new Guid("0656b88e-a20f-44f1-87e1-26eeecf11f0d"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("2447a86e-c937-4faf-bd42-f9b8fdcc14f6"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("519fbfeb-85ba-4d2d-8233-ba4c94a5c6f7"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("a9a16378-0bdc-429e-809f-6360ef88bb4d"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("dbb1b093-4f74-43ff-902f-9afe8f752952"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("e2f39824-c765-4971-869f-77fbb230b276"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("f47606a8-47e3-48fe-8e5f-ba904b4d1e3d"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("947f29d9-1d93-4f14-aaf2-d7a8b6c712e8"), new Guid("79bd95cd-4401-4fd8-92ec-1e1988fb440c") });

            migrationBuilder.CreateIndex(
                name: "IX_ProductMatrices_ApplicationId",
                table: "ProductMatrices",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMatrices_Applications_ApplicationId",
                table: "ProductMatrices",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
