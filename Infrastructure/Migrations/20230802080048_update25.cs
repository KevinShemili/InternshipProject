using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1d8a3990-65e2-41a1-a945-27c33538c2d0"), null, "Limited Partnership" },
                    { new Guid("2ac68895-b708-440f-9263-ed45d1d7e811"), null, "Cooperative Society" },
                    { new Guid("2cb846a7-efc2-4284-a45d-80e1eaeaaeed"), null, "Other" },
                    { new Guid("8d7b51cf-68d3-446d-a876-bb152bb42418"), null, "Partnership Limited by Shares" },
                    { new Guid("8f295d84-4dbf-46e1-9da4-8ba0942e8bfc"), null, "Sole Proprietorship" },
                    { new Guid("a50c1ba3-fba7-4b40-832c-1c4890b20207"), null, "General Partnership" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("05866ec1-50ea-4131-83aa-5eeccd1ba5f4"), null, "CanAddBorrower" },
                    { new Guid("16aa1bb6-a4ca-4e19-b3b7-0df413575d0b"), null, "CanReadLenders" },
                    { new Guid("251eb681-bcdf-4fed-8367-756784648abc"), null, "CanDeleteBorrower" },
                    { new Guid("2ba21d63-fb81-4a58-ad04-8d4e12889a9e"), null, "CanDeleteLender" },
                    { new Guid("312d331a-1369-43d4-98a7-a1708810d2cf"), null, "CanUpdateApplication" },
                    { new Guid("38008a26-b6d4-4f02-906d-32c28474bcf1"), null, "CanAddUser" },
                    { new Guid("3cdb1929-13c0-4d5f-ae98-7b75133d6b6a"), null, "CanReadBorrowers" },
                    { new Guid("84fb7159-99a0-4149-b033-86b7a9ba225b"), null, "CanUpdateUser" },
                    { new Guid("8e61be6e-9b1d-488c-8e39-dc2fd5a41136"), null, "IsRegistered" },
                    { new Guid("8fe1796a-e4a2-40c8-b361-43643cdadf37"), null, "CanAddApplication" },
                    { new Guid("9b005453-9788-4491-9f8d-7c1ddf1eb28b"), null, "CanUpdateBorrower" },
                    { new Guid("add42ab6-2d16-454e-a2a5-4ad93e362808"), null, "CanUpdateLender" },
                    { new Guid("b1b21e07-91be-47bc-89d2-0ebb0f5aa7a4"), null, "CanReadUsers" },
                    { new Guid("b92de386-76b5-4017-8747-e93cb07a73b8"), null, "CanAddLender" },
                    { new Guid("c22b32f5-c92b-4769-9e0b-898fb59f41e1"), null, "CanDeleteApplication" },
                    { new Guid("da2cfd7f-8cf1-47ff-a0c9-2aff1e65edb3"), null, "CanReadApplications" },
                    { new Guid("f08083c7-a707-44bb-a02f-c1179d6eb880"), null, "CanDeleteUser" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3c982587-3d6b-475d-85a4-f7e7026bc6e3"), "RegisteredUser" },
                    { new Guid("a13ffd79-74c9-4cb4-a933-018c8c775f2a"), "Borrower" },
                    { new Guid("bddf71fc-7493-4f0a-8c1f-2995875cbf9b"), "LoanOfficerFrontOffice" },
                    { new Guid("dedea1d1-7a43-41d8-932a-2404a3c62fc2"), "LoanOfficerBackOffice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("1d8a3990-65e2-41a1-a945-27c33538c2d0"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("2ac68895-b708-440f-9263-ed45d1d7e811"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("2cb846a7-efc2-4284-a45d-80e1eaeaaeed"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8d7b51cf-68d3-446d-a876-bb152bb42418"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8f295d84-4dbf-46e1-9da4-8ba0942e8bfc"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a50c1ba3-fba7-4b40-832c-1c4890b20207"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("05866ec1-50ea-4131-83aa-5eeccd1ba5f4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("16aa1bb6-a4ca-4e19-b3b7-0df413575d0b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("251eb681-bcdf-4fed-8367-756784648abc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2ba21d63-fb81-4a58-ad04-8d4e12889a9e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("312d331a-1369-43d4-98a7-a1708810d2cf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("38008a26-b6d4-4f02-906d-32c28474bcf1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3cdb1929-13c0-4d5f-ae98-7b75133d6b6a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("84fb7159-99a0-4149-b033-86b7a9ba225b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8e61be6e-9b1d-488c-8e39-dc2fd5a41136"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8fe1796a-e4a2-40c8-b361-43643cdadf37"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9b005453-9788-4491-9f8d-7c1ddf1eb28b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("add42ab6-2d16-454e-a2a5-4ad93e362808"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b1b21e07-91be-47bc-89d2-0ebb0f5aa7a4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b92de386-76b5-4017-8747-e93cb07a73b8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c22b32f5-c92b-4769-9e0b-898fb59f41e1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("da2cfd7f-8cf1-47ff-a0c9-2aff1e65edb3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f08083c7-a707-44bb-a02f-c1179d6eb880"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3c982587-3d6b-475d-85a4-f7e7026bc6e3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a13ffd79-74c9-4cb4-a933-018c8c775f2a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bddf71fc-7493-4f0a-8c1f-2995875cbf9b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dedea1d1-7a43-41d8-932a-2404a3c62fc2"));

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
    }
}
