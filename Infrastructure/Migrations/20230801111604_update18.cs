using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "MarketCapitalization",
                table: "CompanyProfiles",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "MarketCapitalization",
                table: "CompanyProfiles",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

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
    }
}
