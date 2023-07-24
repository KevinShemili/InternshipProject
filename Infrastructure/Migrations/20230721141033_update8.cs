using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2691ee93-9576-4ec8-9e8e-3c51f9876442"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2bd15eb1-2b4d-4812-a188-0a6f3881ba50"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5957ec30-1b4d-4c43-8c02-455b0e4b404a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6dd8b1ab-0be8-483f-8d1a-39d1c38ea1b6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("78b4b2d7-107c-48b3-9cdd-5e1205199013"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8ead3019-3e56-41a1-897d-653d2fb61f9d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("96da43d9-7f13-49fc-851e-93a9ec2bf5e5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("de1988e9-0b12-42cf-a380-ba68650f0190"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc366061-b821-4b72-b3ea-3b35121bed57"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d887a2b-00a9-4f3d-9f13-4e1176ad841a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7b937a94-6f4e-4625-8b23-f60de0ace3c5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f6c6ae8-4d3c-41f5-aaa5-bab43d4ef775"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("96f7332d-02b4-4fb0-9c3c-11fd64ea0596"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0ab1318e-464c-43a2-817c-660352a05382"), null, "CanUpdateLender" },
                    { new Guid("1ce58dbd-3daa-4c10-bb62-64acd62a3672"), null, "CanUpdateBorrower" },
                    { new Guid("22621e0b-39ce-45b7-b12d-0b633ad20a03"), null, "CanUpdateApplication" },
                    { new Guid("4556c848-737f-4339-bcce-6f6802560128"), null, "CanReadUsers" },
                    { new Guid("4c9e6c65-7869-4b18-b61a-e44656caf082"), null, "IsRegistered" },
                    { new Guid("713a3112-7182-4cd8-ab5c-0ab5a6aed2f4"), null, "CanDeleteUser" },
                    { new Guid("7be51535-3ea5-49fe-9976-cb4c5f5426d4"), null, "CanAddUser" },
                    { new Guid("81891c16-99e0-4da4-8768-a3cc88d8bd81"), null, "CanReadApplications" },
                    { new Guid("8f0a528b-44cb-482c-8515-733bf85e4ab2"), null, "CanReadBorrowers" },
                    { new Guid("a9fa6abe-b106-4afa-a10b-8c03ae18e3db"), null, "CanReadLenders" },
                    { new Guid("b9737497-cb87-4a16-a938-645942e65a98"), null, "CanAddBorrower" },
                    { new Guid("b9fa7644-c032-4136-8dda-b4a460451f9c"), null, "CanUpdateUser" },
                    { new Guid("c8b83f53-7b2b-4d73-b86a-de3bca2f80a4"), null, "CanDeleteApplication" },
                    { new Guid("caf56ce1-7918-49ea-a33f-05c4132bedfe"), null, "CanAddLender" },
                    { new Guid("cd204f1f-2948-417f-9c19-64bf593e6c70"), null, "CanDeleteLender" },
                    { new Guid("db4edb32-9bce-4849-9f89-ce70efaaa64b"), null, "CanAddApplication" },
                    { new Guid("fecf7811-369f-456f-9c35-4ad319fe0c63"), null, "CanDeleteBorrower" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("13160bae-98dd-40c7-bac8-cb6bdeaf91b5"), "Borrower" },
                    { new Guid("67758d21-af58-4dfd-834e-9b4c39549645"), "LoanOfficerFrontOffice" },
                    { new Guid("69eef54f-e725-4760-8871-69145500e2b6"), "RegisteredUser" },
                    { new Guid("a29b8891-bf57-415a-8bbf-30af6222a1a6"), "LoanOfficerBackOffice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0ab1318e-464c-43a2-817c-660352a05382"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1ce58dbd-3daa-4c10-bb62-64acd62a3672"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("22621e0b-39ce-45b7-b12d-0b633ad20a03"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4556c848-737f-4339-bcce-6f6802560128"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4c9e6c65-7869-4b18-b61a-e44656caf082"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("713a3112-7182-4cd8-ab5c-0ab5a6aed2f4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7be51535-3ea5-49fe-9976-cb4c5f5426d4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("81891c16-99e0-4da4-8768-a3cc88d8bd81"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8f0a528b-44cb-482c-8515-733bf85e4ab2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a9fa6abe-b106-4afa-a10b-8c03ae18e3db"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b9737497-cb87-4a16-a938-645942e65a98"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b9fa7644-c032-4136-8dda-b4a460451f9c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c8b83f53-7b2b-4d73-b86a-de3bca2f80a4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("caf56ce1-7918-49ea-a33f-05c4132bedfe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cd204f1f-2948-417f-9c19-64bf593e6c70"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db4edb32-9bce-4849-9f89-ce70efaaa64b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fecf7811-369f-456f-9c35-4ad319fe0c63"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("13160bae-98dd-40c7-bac8-cb6bdeaf91b5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("67758d21-af58-4dfd-834e-9b4c39549645"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("69eef54f-e725-4760-8871-69145500e2b6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a29b8891-bf57-415a-8bbf-30af6222a1a6"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2691ee93-9576-4ec8-9e8e-3c51f9876442"), null, "CanAddUser" },
                    { new Guid("2bd15eb1-2b4d-4812-a188-0a6f3881ba50"), null, "CanUpdateBorrower" },
                    { new Guid("5957ec30-1b4d-4c43-8c02-455b0e4b404a"), null, "CanReadBorrowers" },
                    { new Guid("6dd8b1ab-0be8-483f-8d1a-39d1c38ea1b6"), null, "CanDeleteBorrower" },
                    { new Guid("78b4b2d7-107c-48b3-9cdd-5e1205199013"), null, "CanUpdateUser" },
                    { new Guid("8ead3019-3e56-41a1-897d-653d2fb61f9d"), null, "CanDeleteUser" },
                    { new Guid("96da43d9-7f13-49fc-851e-93a9ec2bf5e5"), null, "CanAddBorrower" },
                    { new Guid("de1988e9-0b12-42cf-a380-ba68650f0190"), null, "IsRegistered" },
                    { new Guid("fc366061-b821-4b72-b3ea-3b35121bed57"), null, "CanReadUsers" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d887a2b-00a9-4f3d-9f13-4e1176ad841a"), "Borrower" },
                    { new Guid("7b937a94-6f4e-4625-8b23-f60de0ace3c5"), "LoanOfficerBackOffice" },
                    { new Guid("8f6c6ae8-4d3c-41f5-aaa5-bab43d4ef775"), "RegisteredUser" },
                    { new Guid("96f7332d-02b4-4fb0-9c3c-11fd64ea0596"), "LoanOfficerFrontOffice" }
                });
        }
    }
}
