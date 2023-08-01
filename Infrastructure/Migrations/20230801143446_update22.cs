using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Status",
                table: "Applications",
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
                    { new Guid("15135cfe-720b-4620-beef-d789ed24883b"), null, "Sole Proprietorship" },
                    { new Guid("1f2ca40e-31c4-4e2d-b259-c6dfe4fee7e0"), null, "Partnership Limited by Shares" },
                    { new Guid("3751947f-8714-4018-9974-414adf397ce7"), null, "Limited Partnership" },
                    { new Guid("53ddf09f-1354-4df9-b130-05edb313b09a"), null, "Other" },
                    { new Guid("a2405098-af50-4f9c-a105-7ea6f6998173"), null, "General Partnership" },
                    { new Guid("d97a6931-90a9-4b70-802f-190f8978b081"), null, "Cooperative Society" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0617e228-9c5e-44f5-97b2-c115f7b4a620"), null, "CanUpdateUser" },
                    { new Guid("16a36db0-2527-4408-a28c-e52e3d91e17f"), null, "IsRegistered" },
                    { new Guid("216a3373-f51a-4be3-86b1-e7ff12c966d8"), null, "CanUpdateApplication" },
                    { new Guid("5c402131-cd25-40db-b57d-9cf600b36a87"), null, "CanAddBorrower" },
                    { new Guid("631297bf-d798-4891-b728-723bc5dfc8d3"), null, "CanReadUsers" },
                    { new Guid("69a8424a-0e38-4011-ae57-4fda389a6d79"), null, "CanReadApplications" },
                    { new Guid("7ec66ada-3352-49a1-b6ae-6d04d70b9836"), null, "CanReadLenders" },
                    { new Guid("8be3a41c-3290-44e5-acd8-1cc51e60205c"), null, "CanAddApplication" },
                    { new Guid("8de77e5f-3ca9-4e3e-aea4-ef2f03c02a54"), null, "CanDeleteLender" },
                    { new Guid("9c527787-f06a-4107-afa5-b72bc8526d21"), null, "CanDeleteBorrower" },
                    { new Guid("b4b8511c-e985-4cfe-b397-5ae63e2f7f15"), null, "CanReadBorrowers" },
                    { new Guid("c1595c28-1244-4149-a242-2ce49fca854f"), null, "CanDeleteApplication" },
                    { new Guid("d8a1b354-922f-4476-9b95-1d4fd56374ec"), null, "CanDeleteUser" },
                    { new Guid("db3facfb-5dc5-427a-adb0-fc561459a80f"), null, "CanUpdateBorrower" },
                    { new Guid("e68065a1-4e9e-40cd-b6e3-dfd73723d374"), null, "CanAddUser" },
                    { new Guid("f29704d9-97c2-415f-898a-5ce6c662a3b8"), null, "CanUpdateLender" },
                    { new Guid("faf9218d-b5c7-4cff-b679-1319ad472652"), null, "CanAddLender" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("09aaf939-2678-4707-88b7-ec76b53393a6"), "Borrower" },
                    { new Guid("4604b7ef-d888-4e45-9383-2aefa82c8ad1"), "LoanOfficerFrontOffice" },
                    { new Guid("8ddab6b4-be14-4fe1-b491-a32051941753"), "RegisteredUser" },
                    { new Guid("c3f6395e-1180-4d98-b6bd-d0af0a1d0612"), "LoanOfficerBackOffice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("15135cfe-720b-4620-beef-d789ed24883b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("1f2ca40e-31c4-4e2d-b259-c6dfe4fee7e0"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("3751947f-8714-4018-9974-414adf397ce7"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("53ddf09f-1354-4df9-b130-05edb313b09a"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a2405098-af50-4f9c-a105-7ea6f6998173"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d97a6931-90a9-4b70-802f-190f8978b081"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0617e228-9c5e-44f5-97b2-c115f7b4a620"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("16a36db0-2527-4408-a28c-e52e3d91e17f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("216a3373-f51a-4be3-86b1-e7ff12c966d8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5c402131-cd25-40db-b57d-9cf600b36a87"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("631297bf-d798-4891-b728-723bc5dfc8d3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("69a8424a-0e38-4011-ae57-4fda389a6d79"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ec66ada-3352-49a1-b6ae-6d04d70b9836"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8be3a41c-3290-44e5-acd8-1cc51e60205c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8de77e5f-3ca9-4e3e-aea4-ef2f03c02a54"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9c527787-f06a-4107-afa5-b72bc8526d21"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b4b8511c-e985-4cfe-b397-5ae63e2f7f15"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c1595c28-1244-4149-a242-2ce49fca854f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d8a1b354-922f-4476-9b95-1d4fd56374ec"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db3facfb-5dc5-427a-adb0-fc561459a80f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e68065a1-4e9e-40cd-b6e3-dfd73723d374"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f29704d9-97c2-415f-898a-5ce6c662a3b8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("faf9218d-b5c7-4cff-b679-1319ad472652"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("09aaf939-2678-4707-88b7-ec76b53393a6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4604b7ef-d888-4e45-9383-2aefa82c8ad1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8ddab6b4-be14-4fe1-b491-a32051941753"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3f6395e-1180-4d98-b6bd-d0af0a1d0612"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Applications",
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
    }
}
