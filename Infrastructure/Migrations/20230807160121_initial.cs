using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                    table.UniqueConstraint("AK_CompanyTypes_Type", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "Lenders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestedAmount = table.Column<int>(type: "int", nullable: false),
                    Tenor = table.Column<int>(type: "int", nullable: false),
                    BorrowerCompanyType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lenders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.UniqueConstraint("AK_Permissions_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReferenceRate = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    FinanceMaxAmount = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    FinanceMinAmount = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.UniqueConstraint("AK_Products_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.UniqueConstraint("AK_Roles_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LoginTries = table.Column<int>(type: "int", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("AK_Users_Email", x => x.Email);
                    table.UniqueConstraint("AK_Users_Username", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VATNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiscalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrowers_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrowers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserVerificationAndReset",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailVerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailVerificationTokenExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordResetTokenExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVerificationAndReset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserVerificationAndReset_Users_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Users",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestedAmount = table.Column<int>(type: "int", nullable: false),
                    RequestedTenor = table.Column<int>(type: "int", nullable: false),
                    FinancePurposeDefinition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BorrowerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Borrowers_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "Borrowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Exchange = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MarketCapitalization = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShareOutstanding = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    Ticker = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WebUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FinnhubIndustry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BorrowerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyProfiles_Borrowers_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "Borrowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestedAmount = table.Column<int>(type: "int", nullable: false),
                    ReferenceRate = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Tenor = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Lenders_LenderId",
                        column: x => x.LenderId,
                        principalTable: "Lenders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMatrices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMatrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMatrices_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { new Guid("21fe46f1-c27e-4724-b6ca-3542420b8545"), null, "General Partnership" },
                    { new Guid("2d9b10e9-67f0-4c7d-8fd8-d6467437e478"), null, "Sole Proprietorship" },
                    { new Guid("30ae2255-dc30-41c6-8cc2-910c69b8b9e6"), null, "Other" },
                    { new Guid("41a47e50-2399-4fb8-9d3d-22f7feb1bd9e"), null, "Limited Partnership" },
                    { new Guid("8f985cc7-128f-4be7-9988-904b40b8317f"), null, "Partnership Limited by Shares" },
                    { new Guid("a581a59c-8836-42dc-85e4-27d878eaa29f"), null, "Cooperative Society" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0382e628-c695-4dbd-8aeb-2547708724fc"), null, "CanUpdateApplication" },
                    { new Guid("0656b88e-a20f-44f1-87e1-26eeecf11f0d"), null, "CanDeleteBorrower" },
                    { new Guid("09ba0246-8a00-4feb-b64a-a1a207ee6bbd"), null, "IsSuperAdmin" },
                    { new Guid("0e079ddf-db6f-45bb-81c2-37c916cde117"), null, "IsRegistered" },
                    { new Guid("2447a86e-c937-4faf-bd42-f9b8fdcc14f6"), null, "CanReadOwnApplications" },
                    { new Guid("519fbfeb-85ba-4d2d-8233-ba4c94a5c6f7"), null, "CanAddBorrower" },
                    { new Guid("a9a16378-0bdc-429e-809f-6360ef88bb4d"), null, "CanReadOwnBorrowers" },
                    { new Guid("dbb1b093-4f74-43ff-902f-9afe8f752952"), null, "CanDeleteApplication" },
                    { new Guid("dd6d543c-bf19-4e9c-b928-af274cce0f74"), null, "CanReadBorrowers" },
                    { new Guid("df4edda6-1227-48fd-ac8d-eea9e96f370b"), null, "CanReadApplications" },
                    { new Guid("e2f39824-c765-4971-869f-77fbb230b276"), null, "CanAddApplication" },
                    { new Guid("f47606a8-47e3-48fe-8e5f-ba904b4d1e3d"), null, "CanUpdateBorrower" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FinanceMaxAmount", "FinanceMinAmount", "Name", "ReferenceRate" },
                values: new object[,]
                {
                    { new Guid("1b13ef33-6fae-4e35-bce6-343be6cc8bd2"), "Installment with variable rate pre-amortization", 2000000.00m, 10000.00m, "Installment with variable rate pre-amortization", 0.03m },
                    { new Guid("ab105905-f008-40fe-bc5a-ca13711a3c2a"), "Installments with pre-amortization at a fixed rate", 2000000.00m, 10000.00m, "Installments with pre-amortization at a fixed rate", 0.0025m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb"), "LoanOfficer" },
                    { new Guid("947f29d9-1d93-4f14-aaf2-d7a8b6c712e8"), "SuperAdmin" },
                    { new Guid("b6803092-61f0-4aa7-9a77-c0e54154f451"), "RegisteredUser" },
                    { new Guid("c7493473-195e-485f-9e11-22be3c4599de"), "Borrower" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("79bd95cd-4401-4fd8-92ec-1e1988fb440c"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0382e628-c695-4dbd-8aeb-2547708724fc"), new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb") },
                    { new Guid("dd6d543c-bf19-4e9c-b928-af274cce0f74"), new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb") },
                    { new Guid("df4edda6-1227-48fd-ac8d-eea9e96f370b"), new Guid("21ac4ea3-5e49-43da-9b36-2454954513bb") },
                    { new Guid("09ba0246-8a00-4feb-b64a-a1a207ee6bbd"), new Guid("947f29d9-1d93-4f14-aaf2-d7a8b6c712e8") },
                    { new Guid("0e079ddf-db6f-45bb-81c2-37c916cde117"), new Guid("b6803092-61f0-4aa7-9a77-c0e54154f451") },
                    { new Guid("519fbfeb-85ba-4d2d-8233-ba4c94a5c6f7"), new Guid("b6803092-61f0-4aa7-9a77-c0e54154f451") },
                    { new Guid("0656b88e-a20f-44f1-87e1-26eeecf11f0d"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("2447a86e-c937-4faf-bd42-f9b8fdcc14f6"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("519fbfeb-85ba-4d2d-8233-ba4c94a5c6f7"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("a9a16378-0bdc-429e-809f-6360ef88bb4d"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("dbb1b093-4f74-43ff-902f-9afe8f752952"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("e2f39824-c765-4971-869f-77fbb230b276"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") },
                    { new Guid("f47606a8-47e3-48fe-8e5f-ba904b4d1e3d"), new Guid("c7493473-195e-485f-9e11-22be3c4599de") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("947f29d9-1d93-4f14-aaf2-d7a8b6c712e8"), new Guid("79bd95cd-4401-4fd8-92ec-1e1988fb440c") });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_BorrowerId",
                table: "Applications",
                column: "BorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProductId",
                table: "Applications",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_CompanyTypeId",
                table: "Borrowers",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_UserId",
                table: "Borrowers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProfiles_BorrowerId",
                table: "CompanyProfiles",
                column: "BorrowerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ApplicationId",
                table: "Loans",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LenderId",
                table: "Loans",
                column: "LenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMatrices_ApplicationId",
                table: "ProductMatrices",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVerificationAndReset_UserEmail",
                table: "UserVerificationAndReset",
                column: "UserEmail",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyProfiles");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "ProductMatrices");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserVerificationAndReset");

            migrationBuilder.DropTable(
                name: "Lenders");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Borrowers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
