using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("04ca6a13-79d2-442c-841a-f07935220037"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("446117eb-b7aa-47cb-9f45-14fc5ac71723"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("6db3e788-10b6-4c76-a5a0-ef7bf725dd4e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b4aaf87b-acca-44e0-891e-0f1b2ddb948e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc83123d-9c70-4ad9-be70-4665e104c3d5"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("bfca339b-48fa-4e44-917a-7152a961918d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("06e227ad-631e-4e93-9735-386b02509b38"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4a31068c-9c7d-479f-80ec-f56ffdf72b15"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("558fe18c-6e22-4eac-9dd7-0211e481d473"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7dd12ce9-662f-4f6b-abd5-0a80cba1fdf2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8dba8a2d-2c41-4f58-88d6-c4196d75c903"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("986975d6-9fa8-4743-855b-8e9b63ca29d0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a486da36-fd52-495b-b103-9eb1efe292eb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa08d8b7-83eb-4f42-91ed-7b84413f71a4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa4dbbe7-1799-4d43-ac2b-05d58cce83e3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b73730d4-5628-4efb-87cd-d537f8f6e5a9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c15f3237-4bad-4e2f-8572-cb37d336c858"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c29c95f7-2c16-4b80-a0e6-f4f55a9de323"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c8981d7f-3181-4bf2-86c5-b78c9ce550a8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d8975e26-d563-407f-841c-20c177d5ddb9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d94211c0-8402-4eb2-bba1-cb875ade5f60"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db770db4-49d5-453c-ba16-93575748c3be"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e35ad258-8fd5-498a-b402-200c2b7f9a7e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("126ade39-b6d5-43f0-aa3c-ecb853dbc0c2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6c572bc9-6272-453b-8d94-9f813c77ecb8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7d0828bb-48af-44c0-ad46-7835117a549a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8211b94e-3c70-4a9b-92ea-d3584044ee84"));

            migrationBuilder.AlterColumn<string>(
                name: "WebUrl",
                table: "CompanyProfiles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Ticker",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "ShareOutstanding",
                table: "CompanyProfiles",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "MarketCapitalization",
                table: "CompanyProfiles",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "CompanyProfiles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IPO",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FinnhubIndustry",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Exchange",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("1c2bf65f-a512-4d14-a32f-5b6921626d81"), null, "Other" },
                    { new Guid("1f9cfe0d-015f-4eb2-a6f0-3d49b3dc8252"), null, "Cooperative Society" },
                    { new Guid("22ff9916-3734-4299-b952-c84f677fd16e"), null, "Limited Partnership" },
                    { new Guid("628e9a41-7238-41e7-9669-7fca7786f420"), null, "Sole Proprietorship" },
                    { new Guid("9b0908b0-70a0-4313-ba95-d218d729bb54"), null, "General Partnership" },
                    { new Guid("c8648ceb-d939-48e2-8ad5-0bf4baa545eb"), null, "Partnership Limited by Shares" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0e174d5b-c4b4-4902-baed-85527c83940f"), null, "CanUpdateApplication" },
                    { new Guid("1483e018-8638-472a-9ac0-4df5ba4cff83"), null, "CanDeleteUser" },
                    { new Guid("17190565-2be1-4da0-8da8-a45d7a69cf27"), null, "CanAddLender" },
                    { new Guid("6f15e5dd-7936-453e-aced-07472c2a4967"), null, "CanUpdateUser" },
                    { new Guid("76d64118-52c6-45b5-b306-a4794611652e"), null, "IsRegistered" },
                    { new Guid("9489fa0c-40d9-4a72-9002-f7eded7c3b32"), null, "CanReadApplications" },
                    { new Guid("97c67f92-bd79-4884-b181-84a6231bb0e9"), null, "CanDeleteBorrower" },
                    { new Guid("a706f3e8-b0ab-42b7-8fa4-1a159661478a"), null, "CanAddUser" },
                    { new Guid("b6500e4b-33c2-4291-a134-8893000fa00a"), null, "CanReadLenders" },
                    { new Guid("b8c3716c-b3ac-474e-b34b-5655a2ae974c"), null, "CanReadBorrowers" },
                    { new Guid("cdba45e9-9be3-4eb8-9a66-a4316cbdd930"), null, "CanUpdateBorrower" },
                    { new Guid("cef35855-4af4-4e35-96dd-d17c64ca6f61"), null, "CanDeleteLender" },
                    { new Guid("cf6c67ea-0609-4566-a537-553b0e5aea91"), null, "CanAddBorrower" },
                    { new Guid("d13c66ac-ce94-40aa-91fd-49ba569cc8f0"), null, "CanAddApplication" },
                    { new Guid("db455ead-6372-45b1-a05d-ab3f0d37bb4c"), null, "CanReadUsers" },
                    { new Guid("ddae2ff4-00af-491a-a772-ff29f19d842e"), null, "CanDeleteApplication" },
                    { new Guid("e330345e-6091-418c-a43b-500c2263ca33"), null, "CanUpdateLender" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06be0a7e-d2a7-4305-8de2-797aeb9e4969"), "LoanOfficerBackOffice" },
                    { new Guid("08472e6a-f296-4946-98c3-12b017f0fc5d"), "Borrower" },
                    { new Guid("1dc76fd1-c3d7-4650-ae7a-9ed651340bdd"), "RegisteredUser" },
                    { new Guid("9a6f9e69-7da6-4c68-b820-e289c322acde"), "LoanOfficerFrontOffice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("1c2bf65f-a512-4d14-a32f-5b6921626d81"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("1f9cfe0d-015f-4eb2-a6f0-3d49b3dc8252"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("22ff9916-3734-4299-b952-c84f677fd16e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("628e9a41-7238-41e7-9669-7fca7786f420"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("9b0908b0-70a0-4313-ba95-d218d729bb54"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("c8648ceb-d939-48e2-8ad5-0bf4baa545eb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0e174d5b-c4b4-4902-baed-85527c83940f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1483e018-8638-472a-9ac0-4df5ba4cff83"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("17190565-2be1-4da0-8da8-a45d7a69cf27"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6f15e5dd-7936-453e-aced-07472c2a4967"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("76d64118-52c6-45b5-b306-a4794611652e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9489fa0c-40d9-4a72-9002-f7eded7c3b32"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("97c67f92-bd79-4884-b181-84a6231bb0e9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a706f3e8-b0ab-42b7-8fa4-1a159661478a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b6500e4b-33c2-4291-a134-8893000fa00a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b8c3716c-b3ac-474e-b34b-5655a2ae974c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cdba45e9-9be3-4eb8-9a66-a4316cbdd930"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cef35855-4af4-4e35-96dd-d17c64ca6f61"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cf6c67ea-0609-4566-a537-553b0e5aea91"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d13c66ac-ce94-40aa-91fd-49ba569cc8f0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db455ead-6372-45b1-a05d-ab3f0d37bb4c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ddae2ff4-00af-491a-a772-ff29f19d842e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e330345e-6091-418c-a43b-500c2263ca33"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("06be0a7e-d2a7-4305-8de2-797aeb9e4969"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("08472e6a-f296-4946-98c3-12b017f0fc5d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1dc76fd1-c3d7-4650-ae7a-9ed651340bdd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9a6f9e69-7da6-4c68-b820-e289c322acde"));

            migrationBuilder.AlterColumn<string>(
                name: "WebUrl",
                table: "CompanyProfiles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ticker",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ShareOutstanding",
                table: "CompanyProfiles",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MarketCapitalization",
                table: "CompanyProfiles",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "CompanyProfiles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IPO",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FinnhubIndustry",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Exchange",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("04ca6a13-79d2-442c-841a-f07935220037"), null, "Limited Partnership" },
                    { new Guid("446117eb-b7aa-47cb-9f45-14fc5ac71723"), null, "General Partnership" },
                    { new Guid("6db3e788-10b6-4c76-a5a0-ef7bf725dd4e"), null, "Partnership Limited by Shares" },
                    { new Guid("b4aaf87b-acca-44e0-891e-0f1b2ddb948e"), null, "Sole Proprietorship" },
                    { new Guid("bc83123d-9c70-4ad9-be70-4665e104c3d5"), null, "Other" },
                    { new Guid("bfca339b-48fa-4e44-917a-7152a961918d"), null, "Cooperative Society" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("06e227ad-631e-4e93-9735-386b02509b38"), null, "CanDeleteBorrower" },
                    { new Guid("4a31068c-9c7d-479f-80ec-f56ffdf72b15"), null, "CanAddLender" },
                    { new Guid("558fe18c-6e22-4eac-9dd7-0211e481d473"), null, "CanReadApplications" },
                    { new Guid("7dd12ce9-662f-4f6b-abd5-0a80cba1fdf2"), null, "CanReadLenders" },
                    { new Guid("8dba8a2d-2c41-4f58-88d6-c4196d75c903"), null, "CanUpdateBorrower" },
                    { new Guid("986975d6-9fa8-4743-855b-8e9b63ca29d0"), null, "CanReadUsers" },
                    { new Guid("a486da36-fd52-495b-b103-9eb1efe292eb"), null, "CanReadBorrowers" },
                    { new Guid("aa08d8b7-83eb-4f42-91ed-7b84413f71a4"), null, "CanAddBorrower" },
                    { new Guid("aa4dbbe7-1799-4d43-ac2b-05d58cce83e3"), null, "CanAddApplication" },
                    { new Guid("b73730d4-5628-4efb-87cd-d537f8f6e5a9"), null, "CanDeleteLender" },
                    { new Guid("c15f3237-4bad-4e2f-8572-cb37d336c858"), null, "IsRegistered" },
                    { new Guid("c29c95f7-2c16-4b80-a0e6-f4f55a9de323"), null, "CanDeleteUser" },
                    { new Guid("c8981d7f-3181-4bf2-86c5-b78c9ce550a8"), null, "CanDeleteApplication" },
                    { new Guid("d8975e26-d563-407f-841c-20c177d5ddb9"), null, "CanUpdateUser" },
                    { new Guid("d94211c0-8402-4eb2-bba1-cb875ade5f60"), null, "CanUpdateLender" },
                    { new Guid("db770db4-49d5-453c-ba16-93575748c3be"), null, "CanAddUser" },
                    { new Guid("e35ad258-8fd5-498a-b402-200c2b7f9a7e"), null, "CanUpdateApplication" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("126ade39-b6d5-43f0-aa3c-ecb853dbc0c2"), "RegisteredUser" },
                    { new Guid("6c572bc9-6272-453b-8d94-9f813c77ecb8"), "LoanOfficerFrontOffice" },
                    { new Guid("7d0828bb-48af-44c0-ad46-7835117a549a"), "Borrower" },
                    { new Guid("8211b94e-3c70-4a9b-92ea-d3584044ee84"), "LoanOfficerBackOffice" }
                });
        }
    }
}
