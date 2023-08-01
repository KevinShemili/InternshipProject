using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<decimal>(
                name: "MarketCapitalization",
                table: "CompanyProfiles",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FiscalCode",
                table: "Borrowers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("0519db19-2f01-4a08-b79d-51587a1df85b"), null, "Partnership Limited by Shares" },
                    { new Guid("33670418-23c9-4f84-b2d7-2234c56df10f"), null, "Limited Partnership" },
                    { new Guid("5bb6e172-8f7b-40fc-a4c8-645e2b597c06"), null, "Cooperative Society" },
                    { new Guid("7b34a628-187f-4022-8f64-37477d9c3f0b"), null, "General Partnership" },
                    { new Guid("8492c3a0-e7f7-4e64-9eeb-af741a88fd46"), null, "Sole Proprietorship" },
                    { new Guid("a1d4a24b-a184-4941-a92b-92e4a20a29e1"), null, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("04a5e8b9-8ea6-4b0c-875c-03e9d1d43cde"), null, "CanUpdateBorrower" },
                    { new Guid("099c802b-ce75-4de8-b805-9c9ef5db85bc"), null, "CanDeleteLender" },
                    { new Guid("2636aa3c-51c6-4a96-8561-ea32ef1dee54"), null, "CanReadApplications" },
                    { new Guid("42e17f61-d5d0-426f-948a-f49336d74e96"), null, "IsRegistered" },
                    { new Guid("524f335f-54bc-438b-bc96-f358081d349f"), null, "CanAddUser" },
                    { new Guid("8456786d-024f-47cf-97f4-2fbcdc2d5ed5"), null, "CanUpdateUser" },
                    { new Guid("984ff73a-ec9b-4866-839e-976c4275aaf9"), null, "CanUpdateApplication" },
                    { new Guid("a2234257-1484-4e51-bb70-27bf3b680444"), null, "CanReadUsers" },
                    { new Guid("a29a14ad-6e4a-492c-8110-28341fe15ee1"), null, "CanAddLender" },
                    { new Guid("a892e66d-999a-422c-92b7-f66fa33a863e"), null, "CanDeleteApplication" },
                    { new Guid("a9267294-8f97-40ea-a55e-2f7668fd6276"), null, "CanUpdateLender" },
                    { new Guid("c5636fb9-a0ed-401d-adfa-159af803a2ee"), null, "CanReadLenders" },
                    { new Guid("cf7bdf1c-5caf-4bc3-8790-094c4c88602b"), null, "CanAddBorrower" },
                    { new Guid("f3669ec6-ccfa-4d31-89f8-1a8c2342d760"), null, "CanDeleteBorrower" },
                    { new Guid("f6f2151d-3e9f-45ba-bf21-c21ac7381cc9"), null, "CanAddApplication" },
                    { new Guid("f7271adb-eb9f-4827-a2d4-dc79f291322a"), null, "CanReadBorrowers" },
                    { new Guid("fa73643f-e034-4103-a039-fcf36192bd2a"), null, "CanDeleteUser" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02e8b84b-c52e-462c-b4d7-7df205e22016"), "LoanOfficerBackOffice" },
                    { new Guid("3e6b5283-ad22-41e3-801a-13dd39168cd9"), "Borrower" },
                    { new Guid("7354dcf5-8921-46a2-88fd-23e032ce3a03"), "LoanOfficerFrontOffice" },
                    { new Guid("bf7a3da5-4d26-4e15-9c38-da5ddedd6c48"), "RegisteredUser" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("0519db19-2f01-4a08-b79d-51587a1df85b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("33670418-23c9-4f84-b2d7-2234c56df10f"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("5bb6e172-8f7b-40fc-a4c8-645e2b597c06"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7b34a628-187f-4022-8f64-37477d9c3f0b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8492c3a0-e7f7-4e64-9eeb-af741a88fd46"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a1d4a24b-a184-4941-a92b-92e4a20a29e1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("04a5e8b9-8ea6-4b0c-875c-03e9d1d43cde"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("099c802b-ce75-4de8-b805-9c9ef5db85bc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2636aa3c-51c6-4a96-8561-ea32ef1dee54"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("42e17f61-d5d0-426f-948a-f49336d74e96"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("524f335f-54bc-438b-bc96-f358081d349f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8456786d-024f-47cf-97f4-2fbcdc2d5ed5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("984ff73a-ec9b-4866-839e-976c4275aaf9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a2234257-1484-4e51-bb70-27bf3b680444"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a29a14ad-6e4a-492c-8110-28341fe15ee1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a892e66d-999a-422c-92b7-f66fa33a863e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a9267294-8f97-40ea-a55e-2f7668fd6276"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c5636fb9-a0ed-401d-adfa-159af803a2ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cf7bdf1c-5caf-4bc3-8790-094c4c88602b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f3669ec6-ccfa-4d31-89f8-1a8c2342d760"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f6f2151d-3e9f-45ba-bf21-c21ac7381cc9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f7271adb-eb9f-4827-a2d4-dc79f291322a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fa73643f-e034-4103-a039-fcf36192bd2a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("02e8b84b-c52e-462c-b4d7-7df205e22016"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3e6b5283-ad22-41e3-801a-13dd39168cd9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7354dcf5-8921-46a2-88fd-23e032ce3a03"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf7a3da5-4d26-4e15-9c38-da5ddedd6c48"));

            migrationBuilder.AlterColumn<int>(
                name: "MarketCapitalization",
                table: "CompanyProfiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "FiscalCode",
                table: "Borrowers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
