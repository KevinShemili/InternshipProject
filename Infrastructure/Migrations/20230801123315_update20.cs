using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("16767bcf-2863-417c-83a4-17b3643fcf57"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("1a543299-f17a-4742-9445-8fae708cb33e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("433e578c-753d-4c92-9ea4-cf5620752621"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("64dbdd16-4815-43b4-815d-3aaba12463b2"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("bbc47828-02e1-411c-b067-25049932eeef"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("e534b119-112f-4230-9084-379fb223d142"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("07094a99-5c87-4e18-8110-027d2a267e4b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1853e96e-b179-41eb-971b-e66b1d11ce84"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("59a7a61a-3120-4f61-92b3-bef5d04f6eee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5f4912b0-8663-4a1a-afba-a96540d74d52"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6212f466-287f-49d7-b780-82ea337bee03"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6a647b57-d319-4fa2-8b74-8bc30c1d28f2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("965063b7-98e1-465d-a077-856c77b1f9c1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ab938b70-46e7-4f60-9850-38278b15b3e1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("abfc3f99-2306-48d6-b884-7904bb2eb37a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b6c00c33-ab47-4160-a291-4b9cfaf55b7f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bae2cb3d-e8d7-4f21-bd7a-75d46710ba6b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c1ca255d-3dde-4bae-b65e-909e96fc0aa3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ca2867a7-77e8-4a9d-9cb8-d87b6fd532f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e10d1eb9-3ec0-4d57-ab2d-306117053384"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e8c8acd7-a77a-49c5-b384-52d12390fd40"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f91a68d9-6669-42e8-89ec-f75388b5a472"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fec6fc00-57b2-48a4-9d67-2c3b59e3efdd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("690cafed-add4-4c9f-a27a-d271b02b1a1d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("81187090-4e3a-4a00-917d-1f66152be68e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8db5c484-945a-45fd-8c0d-89bde8772ab6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e86d493b-ff04-4b14-b4ae-dffe0c7a0e9d"));

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "CompanyProfiles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Logo",
                table: "CompanyProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("16767bcf-2863-417c-83a4-17b3643fcf57"), null, "Other" },
                    { new Guid("1a543299-f17a-4742-9445-8fae708cb33e"), null, "Sole Proprietorship" },
                    { new Guid("433e578c-753d-4c92-9ea4-cf5620752621"), null, "Cooperative Society" },
                    { new Guid("64dbdd16-4815-43b4-815d-3aaba12463b2"), null, "Limited Partnership" },
                    { new Guid("bbc47828-02e1-411c-b067-25049932eeef"), null, "Partnership Limited by Shares" },
                    { new Guid("e534b119-112f-4230-9084-379fb223d142"), null, "General Partnership" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("07094a99-5c87-4e18-8110-027d2a267e4b"), null, "CanAddApplication" },
                    { new Guid("1853e96e-b179-41eb-971b-e66b1d11ce84"), null, "CanReadUsers" },
                    { new Guid("59a7a61a-3120-4f61-92b3-bef5d04f6eee"), null, "CanDeleteApplication" },
                    { new Guid("5f4912b0-8663-4a1a-afba-a96540d74d52"), null, "CanUpdateApplication" },
                    { new Guid("6212f466-287f-49d7-b780-82ea337bee03"), null, "CanReadApplications" },
                    { new Guid("6a647b57-d319-4fa2-8b74-8bc30c1d28f2"), null, "CanUpdateUser" },
                    { new Guid("965063b7-98e1-465d-a077-856c77b1f9c1"), null, "IsRegistered" },
                    { new Guid("ab938b70-46e7-4f60-9850-38278b15b3e1"), null, "CanReadBorrowers" },
                    { new Guid("abfc3f99-2306-48d6-b884-7904bb2eb37a"), null, "CanDeleteLender" },
                    { new Guid("b6c00c33-ab47-4160-a291-4b9cfaf55b7f"), null, "CanAddUser" },
                    { new Guid("bae2cb3d-e8d7-4f21-bd7a-75d46710ba6b"), null, "CanDeleteBorrower" },
                    { new Guid("c1ca255d-3dde-4bae-b65e-909e96fc0aa3"), null, "CanAddBorrower" },
                    { new Guid("ca2867a7-77e8-4a9d-9cb8-d87b6fd532f5"), null, "CanAddLender" },
                    { new Guid("e10d1eb9-3ec0-4d57-ab2d-306117053384"), null, "CanUpdateBorrower" },
                    { new Guid("e8c8acd7-a77a-49c5-b384-52d12390fd40"), null, "CanUpdateLender" },
                    { new Guid("f91a68d9-6669-42e8-89ec-f75388b5a472"), null, "CanReadLenders" },
                    { new Guid("fec6fc00-57b2-48a4-9d67-2c3b59e3efdd"), null, "CanDeleteUser" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("690cafed-add4-4c9f-a27a-d271b02b1a1d"), "Borrower" },
                    { new Guid("81187090-4e3a-4a00-917d-1f66152be68e"), "LoanOfficerBackOffice" },
                    { new Guid("8db5c484-945a-45fd-8c0d-89bde8772ab6"), "LoanOfficerFrontOffice" },
                    { new Guid("e86d493b-ff04-4b14-b4ae-dffe0c7a0e9d"), "RegisteredUser" }
                });
        }
    }
}
