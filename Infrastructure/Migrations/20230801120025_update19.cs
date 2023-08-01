using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("109f2f95-ec92-4e18-9719-d2320100e501"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("473815ca-a27f-4d64-83bc-ee6e1c61742a"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8dca8c6e-1dd3-4d67-9537-f4c1599eda15"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("a3ff42d6-747d-4d59-9160-5bf5efceeb36"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("c124297a-9464-4b67-b2c4-08b6e115df59"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0a9abc1-8a3e-4073-8340-43df0a62862e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00483675-a293-4a18-ba49-744551dd8c15"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0330a775-62f1-48f4-a3b8-0b3a08d2e9ec"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1235530e-f5c6-46a5-ad75-e873e1118113"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("208dfc93-b385-4cb5-9233-5b55b442d64c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2cd454fe-970d-4d35-bff9-edd410c44ed3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3a050ce8-f80a-444f-8403-e1dc8441c0b2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5c1a966d-0b14-42a6-a450-0203aa65594b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("60bbd834-04d1-49f5-aae0-884bd6fc79c5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7d265e0c-7b8f-414b-b195-0ef9f8175fd3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("87b5f381-678c-402d-90b2-06543fc96f42"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("acc0bbe2-f118-4e04-849e-7e38ccfeb672"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b399a24b-07b5-4982-abce-f1c4349b07b0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cac3072a-c709-4fc3-be94-08177cff0c8d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cd2c8e86-cfdd-449c-8590-89e09ba295d7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e850749e-2b01-478f-917c-7add61b00cac"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e8508cb3-3045-4ad5-9b24-727d23e14791"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc9a773c-bb34-4148-a848-224edb8f5521"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("477dc494-89bf-4308-ac38-0611d6f38cb1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("56a68241-1947-4f89-914b-ed01506db13e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ff7fe9c-b585-4a0c-8714-4f8c54992190"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9cda4a78-e089-46a4-b361-7fa8faf56233"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("109f2f95-ec92-4e18-9719-d2320100e501"), null, "Partnership Limited by Shares" },
                    { new Guid("473815ca-a27f-4d64-83bc-ee6e1c61742a"), null, "General Partnership" },
                    { new Guid("8dca8c6e-1dd3-4d67-9537-f4c1599eda15"), null, "Other" },
                    { new Guid("a3ff42d6-747d-4d59-9160-5bf5efceeb36"), null, "Limited Partnership" },
                    { new Guid("c124297a-9464-4b67-b2c4-08b6e115df59"), null, "Cooperative Society" },
                    { new Guid("d0a9abc1-8a3e-4073-8340-43df0a62862e"), null, "Sole Proprietorship" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00483675-a293-4a18-ba49-744551dd8c15"), null, "CanDeleteLender" },
                    { new Guid("0330a775-62f1-48f4-a3b8-0b3a08d2e9ec"), null, "CanReadApplications" },
                    { new Guid("1235530e-f5c6-46a5-ad75-e873e1118113"), null, "CanDeleteUser" },
                    { new Guid("208dfc93-b385-4cb5-9233-5b55b442d64c"), null, "CanAddLender" },
                    { new Guid("2cd454fe-970d-4d35-bff9-edd410c44ed3"), null, "CanDeleteBorrower" },
                    { new Guid("3a050ce8-f80a-444f-8403-e1dc8441c0b2"), null, "CanUpdateLender" },
                    { new Guid("5c1a966d-0b14-42a6-a450-0203aa65594b"), null, "CanAddUser" },
                    { new Guid("60bbd834-04d1-49f5-aae0-884bd6fc79c5"), null, "CanUpdateUser" },
                    { new Guid("7d265e0c-7b8f-414b-b195-0ef9f8175fd3"), null, "CanUpdateBorrower" },
                    { new Guid("87b5f381-678c-402d-90b2-06543fc96f42"), null, "CanDeleteApplication" },
                    { new Guid("acc0bbe2-f118-4e04-849e-7e38ccfeb672"), null, "IsRegistered" },
                    { new Guid("b399a24b-07b5-4982-abce-f1c4349b07b0"), null, "CanAddBorrower" },
                    { new Guid("cac3072a-c709-4fc3-be94-08177cff0c8d"), null, "CanReadBorrowers" },
                    { new Guid("cd2c8e86-cfdd-449c-8590-89e09ba295d7"), null, "CanReadUsers" },
                    { new Guid("e850749e-2b01-478f-917c-7add61b00cac"), null, "CanUpdateApplication" },
                    { new Guid("e8508cb3-3045-4ad5-9b24-727d23e14791"), null, "CanReadLenders" },
                    { new Guid("fc9a773c-bb34-4148-a848-224edb8f5521"), null, "CanAddApplication" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("477dc494-89bf-4308-ac38-0611d6f38cb1"), "LoanOfficerFrontOffice" },
                    { new Guid("56a68241-1947-4f89-914b-ed01506db13e"), "LoanOfficerBackOffice" },
                    { new Guid("6ff7fe9c-b585-4a0c-8714-4f8c54992190"), "RegisteredUser" },
                    { new Guid("9cda4a78-e089-46a4-b361-7fa8faf56233"), "Borrower" }
                });
        }
    }
}
