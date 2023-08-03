using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("5067c92d-6729-4707-b90e-39690c9cbe44"), null, "Sole Proprietorship" },
                    { new Guid("751bfa3d-94c6-4f34-aba8-a006bed1bfba"), null, "Limited Partnership" },
                    { new Guid("83dc601a-068c-4ef2-9e5b-5c2df5ea17a0"), null, "General Partnership" },
                    { new Guid("87effdd4-560d-4237-a302-28f37273543b"), null, "Partnership Limited by Shares" },
                    { new Guid("b5924faf-f9d0-49fc-b3a7-1e8b3fc1f439"), null, "Cooperative Society" },
                    { new Guid("fc9b8ba9-4558-4a22-8be7-812c2f1ed987"), null, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("03661361-9ff7-439b-8a2a-d8cae58b8e88"), null, "CanUpdateUser" },
                    { new Guid("054c7f51-b395-43c3-9031-f95e80bfe95b"), null, "CanAddUser" },
                    { new Guid("0cac374c-8bee-4ad6-894f-06a57415999c"), null, "CanUpdateLender" },
                    { new Guid("20c20a1e-b33c-4d2f-a8be-6a603d86236c"), null, "CanReadApplications" },
                    { new Guid("285ddf71-8d7c-4b69-9fdd-8474d078b296"), null, "IsRegistered" },
                    { new Guid("3eafb936-4f5f-4138-a416-4b97dc4e9b6c"), null, "CanAddApplication" },
                    { new Guid("513d15ae-88cb-41b9-8fc8-fe68a8f03bc1"), null, "CanDeleteBorrower" },
                    { new Guid("63cc976f-de7b-448c-ade3-79b0a13b9513"), null, "CanReadUsers" },
                    { new Guid("9149f3f4-b41f-45c3-a77e-179e89f2941e"), null, "CanUpdateApplication" },
                    { new Guid("9e384684-5f1d-4e00-9204-0b960e7548a5"), null, "CanReadLenders" },
                    { new Guid("c4228508-314c-4cb4-812d-64e9828479e6"), null, "CanAddLender" },
                    { new Guid("ccf61c44-61fb-46c6-8330-080518ff32c1"), null, "CanUpdateBorrower" },
                    { new Guid("d0d0c35f-ed2c-4000-9679-4e8cec465efb"), null, "CanReadBorrowers" },
                    { new Guid("dcafd8e7-585d-4282-b20c-3ad4c73b4db5"), null, "CanDeleteLender" },
                    { new Guid("e1acc3ad-abff-4229-b974-2f89f9cf18ba"), null, "CanAddBorrower" },
                    { new Guid("e9f39243-6e0b-4d26-a1cd-7a6671196690"), null, "CanDeleteApplication" },
                    { new Guid("eed71d9e-02d8-4725-80de-03f21e49c6f1"), null, "CanDeleteUser" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3acc817e-b4ab-46fb-b0e1-5adf819b208b"), "LoanOfficerFrontOffice" },
                    { new Guid("781b1e6a-46f9-48b7-aa72-b3b469be0ddd"), "LoanOfficerBackOffice" },
                    { new Guid("790c00f7-7054-4543-86b8-83d80d82b814"), "RegisteredUser" },
                    { new Guid("f36fc542-6ba4-4ad4-8583-ea5e3b56c12d"), "Borrower" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("5067c92d-6729-4707-b90e-39690c9cbe44"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("751bfa3d-94c6-4f34-aba8-a006bed1bfba"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("83dc601a-068c-4ef2-9e5b-5c2df5ea17a0"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("87effdd4-560d-4237-a302-28f37273543b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b5924faf-f9d0-49fc-b3a7-1e8b3fc1f439"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("fc9b8ba9-4558-4a22-8be7-812c2f1ed987"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("03661361-9ff7-439b-8a2a-d8cae58b8e88"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("054c7f51-b395-43c3-9031-f95e80bfe95b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0cac374c-8bee-4ad6-894f-06a57415999c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("20c20a1e-b33c-4d2f-a8be-6a603d86236c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("285ddf71-8d7c-4b69-9fdd-8474d078b296"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3eafb936-4f5f-4138-a416-4b97dc4e9b6c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("513d15ae-88cb-41b9-8fc8-fe68a8f03bc1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("63cc976f-de7b-448c-ade3-79b0a13b9513"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9149f3f4-b41f-45c3-a77e-179e89f2941e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9e384684-5f1d-4e00-9204-0b960e7548a5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c4228508-314c-4cb4-812d-64e9828479e6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ccf61c44-61fb-46c6-8330-080518ff32c1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d0d0c35f-ed2c-4000-9679-4e8cec465efb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dcafd8e7-585d-4282-b20c-3ad4c73b4db5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e1acc3ad-abff-4229-b974-2f89f9cf18ba"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e9f39243-6e0b-4d26-a1cd-7a6671196690"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("eed71d9e-02d8-4725-80de-03f21e49c6f1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3acc817e-b4ab-46fb-b0e1-5adf819b208b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("781b1e6a-46f9-48b7-aa72-b3b469be0ddd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("790c00f7-7054-4543-86b8-83d80d82b814"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f36fc542-6ba4-4ad4-8583-ea5e3b56c12d"));

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
    }
}
