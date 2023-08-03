using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("020898fd-ac4b-4644-83b2-b39f7a1ba7e7"), null, "Other" },
                    { new Guid("26b71195-de3e-41e0-a683-feb947f5b9b4"), null, "General Partnership" },
                    { new Guid("44487212-44cc-4975-b7cc-9a3a1af60cbb"), null, "Partnership Limited by Shares" },
                    { new Guid("456203fa-2a88-44cf-bcc9-6f625bd454a9"), null, "Cooperative Society" },
                    { new Guid("d85a5a0a-9d82-4a34-a6c8-895b37a58812"), null, "Limited Partnership" },
                    { new Guid("fb28906e-3e71-4201-af4f-cd7812437fff"), null, "Sole Proprietorship" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0c40456a-2557-4dd7-a81f-3c2685db57a4"), null, "CanAddLender" },
                    { new Guid("1a9cb76d-fef4-480e-bb4e-1dab079b0e26"), null, "CanReadLenders" },
                    { new Guid("27baa042-3f77-46eb-bc83-a6800e270c1b"), null, "CanDeleteUser" },
                    { new Guid("2b36eb23-1205-4616-8c6f-381739ecf3bd"), null, "CanReadApplications" },
                    { new Guid("3353fc0d-4900-4700-9e03-624f854e4b14"), null, "CanUpdateBorrower" },
                    { new Guid("3612ae13-ebda-4a5f-9cf5-c9742c02e62e"), null, "CanAddBorrower" },
                    { new Guid("42e9e221-30b6-4546-ad6f-5d954ddca565"), null, "CanUpdateLender" },
                    { new Guid("50912b58-0813-4522-8765-5cad29f8e831"), null, "CanDeleteLender" },
                    { new Guid("57d8aeac-bc73-42dd-bfe6-437f033b32a2"), null, "CanAddUser" },
                    { new Guid("5825645b-cf50-4a07-a3c7-383a324da53e"), null, "IsRegistered" },
                    { new Guid("64f37142-87d0-45fa-a872-a05be3b3462d"), null, "CanDeleteBorrower" },
                    { new Guid("7ac12b8d-9e8a-482a-81e5-8ef644356454"), null, "CanUpdateApplication" },
                    { new Guid("7c5e0273-8ad3-4b22-b71f-cf04ee1cd806"), null, "CanDeleteApplication" },
                    { new Guid("827cebab-ae5c-4829-8ea5-56c42dd17954"), null, "CanReadUsers" },
                    { new Guid("d1a8f550-e3c2-42b7-8580-e1e1c3ca78bb"), null, "CanAddApplication" },
                    { new Guid("da1c70d2-d004-4d37-8c6b-722b51b9a5b3"), null, "CanReadBorrowers" },
                    { new Guid("f96632a5-45f9-47f7-b14a-fc33f5cdd8a8"), null, "CanUpdateUser" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bd04e29-b22d-428a-aa15-6599c3914f65"), "LoanOfficerBackOffice" },
                    { new Guid("6ea8e24c-e1f5-495a-b4a6-2514d5b8e580"), "Borrower" },
                    { new Guid("90242cfe-7cda-45cc-982f-372ca699f185"), "RegisteredUser" },
                    { new Guid("d0ead8f2-27a7-4536-bf96-ca9f1c55edbe"), "LoanOfficerFrontOffice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("020898fd-ac4b-4644-83b2-b39f7a1ba7e7"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("26b71195-de3e-41e0-a683-feb947f5b9b4"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("44487212-44cc-4975-b7cc-9a3a1af60cbb"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("456203fa-2a88-44cf-bcc9-6f625bd454a9"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d85a5a0a-9d82-4a34-a6c8-895b37a58812"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("fb28906e-3e71-4201-af4f-cd7812437fff"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0c40456a-2557-4dd7-a81f-3c2685db57a4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1a9cb76d-fef4-480e-bb4e-1dab079b0e26"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("27baa042-3f77-46eb-bc83-a6800e270c1b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2b36eb23-1205-4616-8c6f-381739ecf3bd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3353fc0d-4900-4700-9e03-624f854e4b14"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3612ae13-ebda-4a5f-9cf5-c9742c02e62e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("42e9e221-30b6-4546-ad6f-5d954ddca565"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("50912b58-0813-4522-8765-5cad29f8e831"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("57d8aeac-bc73-42dd-bfe6-437f033b32a2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5825645b-cf50-4a07-a3c7-383a324da53e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("64f37142-87d0-45fa-a872-a05be3b3462d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ac12b8d-9e8a-482a-81e5-8ef644356454"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7c5e0273-8ad3-4b22-b71f-cf04ee1cd806"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("827cebab-ae5c-4829-8ea5-56c42dd17954"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d1a8f550-e3c2-42b7-8580-e1e1c3ca78bb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("da1c70d2-d004-4d37-8c6b-722b51b9a5b3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f96632a5-45f9-47f7-b14a-fc33f5cdd8a8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0bd04e29-b22d-428a-aa15-6599c3914f65"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ea8e24c-e1f5-495a-b4a6-2514d5b8e580"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("90242cfe-7cda-45cc-982f-372ca699f185"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d0ead8f2-27a7-4536-bf96-ca9f1c55edbe"));

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
    }
}
