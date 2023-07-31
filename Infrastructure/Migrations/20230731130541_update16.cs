using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("14e471e7-36b8-426d-8576-c198c19b145e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("19bab869-3106-4fb1-8f0f-a819ceba678e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2643b58b-ebe4-417b-9ac9-01fa2ce90733"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("26c3ff7a-bcd0-4f52-aabe-f0ba0a033f26"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2970c327-7b3a-4d8b-b4c4-d9ab9f561206"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3be7689e-d5d1-4b36-b97b-3d5ebc88dfef"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("449b55fb-c896-4477-9cba-0499317e0890"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("454af93d-40bf-4fcb-b37b-9db409a3dfde"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("523c847a-a51d-42a8-b5be-01cdacce138a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("630bac93-0ed5-4673-b72a-8f1367aaa528"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("69f9f3ef-a5aa-4587-a29c-7f7b4089f6fb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6c4a3171-fbd7-406d-a6ab-0a15437f8a8d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("77a95df2-dc1d-4bf2-8a1d-4625d8b314cb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("99bfb5a2-ffe4-4971-bfcd-7b500279f6f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a46d610b-08eb-41e8-a05b-4d797da0a20e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b32546d9-685a-4b0f-ab32-4b0d547acac4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d1663d79-95fa-4cf0-97a1-fedfcaa83ece"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("03cfd74b-2409-486b-a5ca-8fe94cf90ec3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("15eb63da-bf84-45d1-855e-ae8d79c6acb5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c6ec8331-4417-4d95-b0bf-8ff6d3dcf02b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eba39481-33d6-4f00-8e31-62ced286dc4a"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CompanyTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "VATNumber",
                table: "Borrowers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_CompanyTypes_Type",
                table: "CompanyTypes",
                column: "Type");

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("075546d9-568b-4868-8020-962366a2ffb2"), null, "Other" },
                    { new Guid("318c7b04-63b0-41d3-a9dc-8b317e623fd6"), null, "Partnership Limited by Shares" },
                    { new Guid("3e6a8c08-5aee-42ce-abef-8ddf8750606d"), null, "Sole Proprietorship" },
                    { new Guid("9d219820-d5de-4f99-8c80-4571f4ca0d1b"), null, "Limited Partnership" },
                    { new Guid("e61543fb-89eb-4f03-b8a3-17c62fdf4421"), null, "General Partnership" },
                    { new Guid("fa7b3cc2-8657-4fd8-ab59-15335482a8d8"), null, "Cooperative Society" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("116183f9-b584-4b9f-9972-f912d32e9511"), null, "IsRegistered" },
                    { new Guid("3a1ab1af-718d-41ed-beab-208c4f556fdc"), null, "CanAddApplication" },
                    { new Guid("40ea2f82-f467-4ec5-b4b0-42b6091017b4"), null, "CanReadBorrowers" },
                    { new Guid("82373667-c6ac-4405-ac39-0ed1b7968410"), null, "CanReadLenders" },
                    { new Guid("84aff3e1-a115-4389-a8ea-428b0cab288f"), null, "CanDeleteLender" },
                    { new Guid("8f43ad05-2377-4362-a52b-3594eed399e4"), null, "CanAddUser" },
                    { new Guid("99e2abb5-c7e0-4342-87a3-5394a48dced6"), null, "CanAddLender" },
                    { new Guid("9ff1851e-3bb7-495b-879d-376d5327cefa"), null, "CanUpdateApplication" },
                    { new Guid("b5cd47b0-2bf9-460e-bddb-4f91d9ddece7"), null, "CanReadUsers" },
                    { new Guid("b71d86b8-ccd1-40ab-a8ff-22e088e9f2e8"), null, "CanUpdateBorrower" },
                    { new Guid("bad8a841-4be5-4d54-b37b-b4c1a7436283"), null, "CanReadApplications" },
                    { new Guid("bd08e19f-e5e6-4bfd-838d-d9165add8195"), null, "CanDeleteBorrower" },
                    { new Guid("d45627e4-340b-45d2-93f7-78f9761191db"), null, "CanUpdateUser" },
                    { new Guid("e20b1636-6c73-4a2c-8dc0-dbc9454a2512"), null, "CanUpdateLender" },
                    { new Guid("efc01d57-a50d-433e-9f50-3fc4b5aa82f8"), null, "CanDeleteApplication" },
                    { new Guid("f6275f8f-dbc5-4bc1-b815-cfd659d5cce0"), null, "CanAddBorrower" },
                    { new Guid("ff4f125c-a10d-4949-bc34-3a665d384f72"), null, "CanDeleteUser" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("31ccc2fd-4ad6-4eb9-b866-29affa5f6871"), "LoanOfficerFrontOffice" },
                    { new Guid("5aaf3a16-3598-44cb-ae16-4ba3193da1e6"), "RegisteredUser" },
                    { new Guid("73729c43-5579-41ba-9b8e-a0a7556c23a4"), "LoanOfficerBackOffice" },
                    { new Guid("d54387af-9647-4c1e-b6f1-d6643bfb5251"), "Borrower" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_CompanyTypes_Type",
                table: "CompanyTypes");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("075546d9-568b-4868-8020-962366a2ffb2"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("318c7b04-63b0-41d3-a9dc-8b317e623fd6"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e6a8c08-5aee-42ce-abef-8ddf8750606d"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("9d219820-d5de-4f99-8c80-4571f4ca0d1b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("e61543fb-89eb-4f03-b8a3-17c62fdf4421"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("fa7b3cc2-8657-4fd8-ab59-15335482a8d8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("116183f9-b584-4b9f-9972-f912d32e9511"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3a1ab1af-718d-41ed-beab-208c4f556fdc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("40ea2f82-f467-4ec5-b4b0-42b6091017b4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("82373667-c6ac-4405-ac39-0ed1b7968410"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("84aff3e1-a115-4389-a8ea-428b0cab288f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8f43ad05-2377-4362-a52b-3594eed399e4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("99e2abb5-c7e0-4342-87a3-5394a48dced6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9ff1851e-3bb7-495b-879d-376d5327cefa"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b5cd47b0-2bf9-460e-bddb-4f91d9ddece7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b71d86b8-ccd1-40ab-a8ff-22e088e9f2e8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bad8a841-4be5-4d54-b37b-b4c1a7436283"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bd08e19f-e5e6-4bfd-838d-d9165add8195"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d45627e4-340b-45d2-93f7-78f9761191db"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e20b1636-6c73-4a2c-8dc0-dbc9454a2512"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("efc01d57-a50d-433e-9f50-3fc4b5aa82f8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f6275f8f-dbc5-4bc1-b815-cfd659d5cce0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ff4f125c-a10d-4949-bc34-3a665d384f72"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("31ccc2fd-4ad6-4eb9-b866-29affa5f6871"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5aaf3a16-3598-44cb-ae16-4ba3193da1e6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("73729c43-5579-41ba-9b8e-a0a7556c23a4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d54387af-9647-4c1e-b6f1-d6643bfb5251"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CompanyTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VATNumber",
                table: "Borrowers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("14e471e7-36b8-426d-8576-c198c19b145e"), null, "CanReadApplications" },
                    { new Guid("19bab869-3106-4fb1-8f0f-a819ceba678e"), null, "IsRegistered" },
                    { new Guid("2643b58b-ebe4-417b-9ac9-01fa2ce90733"), null, "CanUpdateLender" },
                    { new Guid("26c3ff7a-bcd0-4f52-aabe-f0ba0a033f26"), null, "CanUpdateBorrower" },
                    { new Guid("2970c327-7b3a-4d8b-b4c4-d9ab9f561206"), null, "CanUpdateUser" },
                    { new Guid("3be7689e-d5d1-4b36-b97b-3d5ebc88dfef"), null, "CanDeleteBorrower" },
                    { new Guid("449b55fb-c896-4477-9cba-0499317e0890"), null, "CanAddBorrower" },
                    { new Guid("454af93d-40bf-4fcb-b37b-9db409a3dfde"), null, "CanDeleteApplication" },
                    { new Guid("523c847a-a51d-42a8-b5be-01cdacce138a"), null, "CanReadLenders" },
                    { new Guid("630bac93-0ed5-4673-b72a-8f1367aaa528"), null, "CanDeleteUser" },
                    { new Guid("69f9f3ef-a5aa-4587-a29c-7f7b4089f6fb"), null, "CanAddLender" },
                    { new Guid("6c4a3171-fbd7-406d-a6ab-0a15437f8a8d"), null, "CanAddApplication" },
                    { new Guid("77a95df2-dc1d-4bf2-8a1d-4625d8b314cb"), null, "CanAddUser" },
                    { new Guid("99bfb5a2-ffe4-4971-bfcd-7b500279f6f6"), null, "CanReadUsers" },
                    { new Guid("a46d610b-08eb-41e8-a05b-4d797da0a20e"), null, "CanDeleteLender" },
                    { new Guid("b32546d9-685a-4b0f-ab32-4b0d547acac4"), null, "CanReadBorrowers" },
                    { new Guid("d1663d79-95fa-4cf0-97a1-fedfcaa83ece"), null, "CanUpdateApplication" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03cfd74b-2409-486b-a5ca-8fe94cf90ec3"), "LoanOfficerBackOffice" },
                    { new Guid("15eb63da-bf84-45d1-855e-ae8d79c6acb5"), "RegisteredUser" },
                    { new Guid("c6ec8331-4417-4d95-b0bf-8ff6d3dcf02b"), "LoanOfficerFrontOffice" },
                    { new Guid("eba39481-33d6-4f00-8e31-62ced286dc4a"), "Borrower" }
                });
        }
    }
}
