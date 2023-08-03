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
            migrationBuilder.DropIndex(
                name: "IX_Applications_ProductId",
                table: "Applications");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("48bfe958-5974-4b62-bc94-9c9c2bb8fc4f"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("4dfb49a0-bb51-41cc-a27f-6dcf82a3c7e5"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("6f4343be-a680-49c7-8b9b-7b4973662462"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b72d0829-70bc-45f3-8b57-24d425c7a76e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d55758e9-6651-47b4-bb8f-891ca93f1219"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("f74dd062-1153-4c9f-bcc7-e3e11be87719"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1afc7496-ff0d-47fb-806e-490927d66ff1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("23208424-6825-47a4-ab2f-9bd9c0f8d38a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2674f494-c084-463f-9eb3-fc329f24c02b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("352c61eb-fb66-440d-9c5a-3dc9fecd8b52"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("384db5b7-6e91-42be-ab76-17826ce893fd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3fc0be3a-6242-4019-8b35-ad32038a11f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4f26760f-a6ce-40ba-9aba-ac14954021a9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("76f372cf-c7cb-47c0-beae-a771ca1e1907"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9e4c4e7e-ad66-4241-89fb-aa42d10e2903"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a60b2663-f958-425f-b33a-55c24ce949d5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b13958e5-a8c0-4ce1-a02a-a54a480e11f0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d090e47d-ba66-47de-aeee-24d28b4ceeb3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e34cb6ab-903e-4f42-b314-a0026f3fbbeb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e6db6d1d-51e1-457a-9093-e4e53e3017e8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e83738b5-8c11-4d7b-a75f-6cf9285ac4b9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e9084d94-e6c0-4f93-8a17-8e6abe55b7b3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ef3fdaa6-ce5b-4109-81ba-74f456b8ec67"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7127149d-ec7a-4dc6-bdc4-23bd6a1add6a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92cdbe31-2e94-4c05-95f5-ef884e9039a5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b99af9dc-4f86-4c83-8006-038ab353f4f5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d228ffe6-354c-4ee8-bcf6-4ae040dc26b7"));

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("082692da-3b38-400a-a98f-b9ee67c19433"), null, "Sole Proprietorship" },
                    { new Guid("66e2fafa-ae81-4f1c-a24e-39f6e4033e4b"), null, "General Partnership" },
                    { new Guid("8f96605e-ee07-45f1-83c3-fa4c91263393"), null, "Limited Partnership" },
                    { new Guid("b6956a5b-67b6-45a5-b431-f5ee303c4739"), null, "Cooperative Society" },
                    { new Guid("db3c566d-26a4-483b-b23f-dd606e0424f9"), null, "Other" },
                    { new Guid("dd2c5f94-7be2-4cba-a48a-9fc540375ac9"), null, "Partnership Limited by Shares" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("08e59584-1f81-4569-87cd-80d1489a39f5"), null, "CanAddUser" },
                    { new Guid("1ada15a4-ed51-40da-b4e4-c25e4c270866"), null, "CanUpdateLender" },
                    { new Guid("31f69544-7656-404d-b5ea-11492078ca2c"), null, "CanUpdateUser" },
                    { new Guid("467dd1e7-dfb9-40e0-a8a8-a298cd93a230"), null, "CanUpdateBorrower" },
                    { new Guid("58e8e4bd-c677-4f3a-b597-ed56b431efa4"), null, "CanReadApplications" },
                    { new Guid("681c10d0-3dd3-4575-9240-1811ba33a4e5"), null, "CanDeleteBorrower" },
                    { new Guid("72d11591-ee3c-4efd-a6b0-60949f0db094"), null, "CanAddBorrower" },
                    { new Guid("74544db4-1b55-4d8d-8a71-ddd045f7e612"), null, "CanReadUsers" },
                    { new Guid("806ec9e1-41bb-4520-ab87-9a19956713d0"), null, "CanDeleteLender" },
                    { new Guid("829d5b02-07e3-4ce4-bb12-1db04ecf7b2c"), null, "CanDeleteUser" },
                    { new Guid("86de7c1a-381f-473a-9ae7-cd2c57d891d7"), null, "CanReadLenders" },
                    { new Guid("9891aaaf-302d-4f5d-8885-7db67c60eb52"), null, "CanAddLender" },
                    { new Guid("9cd86dab-b4df-4120-bad1-aa448d877f93"), null, "CanDeleteApplication" },
                    { new Guid("a1bd9f5e-f62a-46e9-a437-827279617732"), null, "CanAddApplication" },
                    { new Guid("e7d606c5-bfc8-44eb-a4c0-b2d7545f32f4"), null, "CanUpdateApplication" },
                    { new Guid("f96392e4-cac7-4e4c-a21b-c41b1e443318"), null, "CanReadBorrowers" },
                    { new Guid("fe22425b-6672-4b33-9332-00f4532f6395"), null, "IsRegistered" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("16511fe5-73b9-49a8-8902-097757c4993a"), "LoanOfficerBackOffice" },
                    { new Guid("283a02ba-4751-476e-a4f9-6bf9b436fc25"), "RegisteredUser" },
                    { new Guid("bf653a8f-c325-4c17-bed2-646feb8ac9ea"), "LoanOfficerFrontOffice" },
                    { new Guid("d0101d00-8144-4664-82a5-0d7ef4ec95fb"), "Borrower" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProductId",
                table: "Applications",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Applications_ProductId",
                table: "Applications");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("082692da-3b38-400a-a98f-b9ee67c19433"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("66e2fafa-ae81-4f1c-a24e-39f6e4033e4b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8f96605e-ee07-45f1-83c3-fa4c91263393"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b6956a5b-67b6-45a5-b431-f5ee303c4739"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("db3c566d-26a4-483b-b23f-dd606e0424f9"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("dd2c5f94-7be2-4cba-a48a-9fc540375ac9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("08e59584-1f81-4569-87cd-80d1489a39f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1ada15a4-ed51-40da-b4e4-c25e4c270866"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("31f69544-7656-404d-b5ea-11492078ca2c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("467dd1e7-dfb9-40e0-a8a8-a298cd93a230"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("58e8e4bd-c677-4f3a-b597-ed56b431efa4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("681c10d0-3dd3-4575-9240-1811ba33a4e5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("72d11591-ee3c-4efd-a6b0-60949f0db094"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("74544db4-1b55-4d8d-8a71-ddd045f7e612"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("806ec9e1-41bb-4520-ab87-9a19956713d0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("829d5b02-07e3-4ce4-bb12-1db04ecf7b2c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("86de7c1a-381f-473a-9ae7-cd2c57d891d7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9891aaaf-302d-4f5d-8885-7db67c60eb52"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9cd86dab-b4df-4120-bad1-aa448d877f93"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a1bd9f5e-f62a-46e9-a437-827279617732"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e7d606c5-bfc8-44eb-a4c0-b2d7545f32f4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f96392e4-cac7-4e4c-a21b-c41b1e443318"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fe22425b-6672-4b33-9332-00f4532f6395"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("16511fe5-73b9-49a8-8902-097757c4993a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("283a02ba-4751-476e-a4f9-6bf9b436fc25"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf653a8f-c325-4c17-bed2-646feb8ac9ea"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d0101d00-8144-4664-82a5-0d7ef4ec95fb"));

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("48bfe958-5974-4b62-bc94-9c9c2bb8fc4f"), null, "Cooperative Society" },
                    { new Guid("4dfb49a0-bb51-41cc-a27f-6dcf82a3c7e5"), null, "Sole Proprietorship" },
                    { new Guid("6f4343be-a680-49c7-8b9b-7b4973662462"), null, "General Partnership" },
                    { new Guid("b72d0829-70bc-45f3-8b57-24d425c7a76e"), null, "Limited Partnership" },
                    { new Guid("d55758e9-6651-47b4-bb8f-891ca93f1219"), null, "Other" },
                    { new Guid("f74dd062-1153-4c9f-bcc7-e3e11be87719"), null, "Partnership Limited by Shares" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1afc7496-ff0d-47fb-806e-490927d66ff1"), null, "CanDeleteLender" },
                    { new Guid("23208424-6825-47a4-ab2f-9bd9c0f8d38a"), null, "CanUpdateApplication" },
                    { new Guid("2674f494-c084-463f-9eb3-fc329f24c02b"), null, "CanAddLender" },
                    { new Guid("352c61eb-fb66-440d-9c5a-3dc9fecd8b52"), null, "CanReadApplications" },
                    { new Guid("384db5b7-6e91-42be-ab76-17826ce893fd"), null, "CanDeleteApplication" },
                    { new Guid("3fc0be3a-6242-4019-8b35-ad32038a11f5"), null, "CanUpdateLender" },
                    { new Guid("4f26760f-a6ce-40ba-9aba-ac14954021a9"), null, "CanAddBorrower" },
                    { new Guid("76f372cf-c7cb-47c0-beae-a771ca1e1907"), null, "CanReadUsers" },
                    { new Guid("9e4c4e7e-ad66-4241-89fb-aa42d10e2903"), null, "CanReadLenders" },
                    { new Guid("a60b2663-f958-425f-b33a-55c24ce949d5"), null, "CanAddApplication" },
                    { new Guid("b13958e5-a8c0-4ce1-a02a-a54a480e11f0"), null, "CanDeleteUser" },
                    { new Guid("d090e47d-ba66-47de-aeee-24d28b4ceeb3"), null, "CanUpdateBorrower" },
                    { new Guid("e34cb6ab-903e-4f42-b314-a0026f3fbbeb"), null, "IsRegistered" },
                    { new Guid("e6db6d1d-51e1-457a-9093-e4e53e3017e8"), null, "CanUpdateUser" },
                    { new Guid("e83738b5-8c11-4d7b-a75f-6cf9285ac4b9"), null, "CanAddUser" },
                    { new Guid("e9084d94-e6c0-4f93-8a17-8e6abe55b7b3"), null, "CanReadBorrowers" },
                    { new Guid("ef3fdaa6-ce5b-4109-81ba-74f456b8ec67"), null, "CanDeleteBorrower" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7127149d-ec7a-4dc6-bdc4-23bd6a1add6a"), "Borrower" },
                    { new Guid("92cdbe31-2e94-4c05-95f5-ef884e9039a5"), "LoanOfficerBackOffice" },
                    { new Guid("b99af9dc-4f86-4c83-8006-038ab353f4f5"), "RegisteredUser" },
                    { new Guid("d228ffe6-354c-4ee8-bcf6-4ae040dc26b7"), "LoanOfficerFrontOffice" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProductId",
                table: "Applications",
                column: "ProductId",
                unique: true);
        }
    }
}
