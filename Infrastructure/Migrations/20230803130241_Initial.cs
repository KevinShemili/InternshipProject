using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    ReferenceRate = table.Column<decimal>(type: "decimal(18,4)", maxLength: 50, precision: 18, scale: 4, nullable: false),
                    FinanceMaxAmount = table.Column<int>(type: "int", nullable: false),
                    FinanceMinAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestedAmount = table.Column<int>(type: "int", nullable: false),
                    ReferenceRate = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Tenor = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Lenders_LenderId",
                        column: x => x.LenderId,
                        principalTable: "Lenders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_Applications_Loans_LoanId",
                        column: x => x.LoanId,
                        principalTable: "Loans",
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
                    { new Guid("445248ae-bc8b-4a7e-90ce-1636f8206fa5"), null, "IsSuperAdmin" },
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
                    { new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"), "SuperAdmin" },
                    { new Guid("7127149d-ec7a-4dc6-bdc4-23bd6a1add6a"), "Borrower" },
                    { new Guid("92cdbe31-2e94-4c05-95f5-ef884e9039a5"), "LoanOfficerBackOffice" },
                    { new Guid("b99af9dc-4f86-4c83-8006-038ab353f4f5"), "RegisteredUser" },
                    { new Guid("d228ffe6-354c-4ee8-bcf6-4ae040dc26b7"), "LoanOfficerFrontOffice" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsBlocked", "IsEmailConfirmed", "LastName", "LoginTries", "PasswordHash", "PasswordSalt", "PhoneNumber", "Prefix", "Username" },
                values: new object[] { new Guid("0f7195df-de82-429c-a430-dc0742edf721"), "kevin.shemili@cardoai.com", "Kevin", false, true, "Shemili", 0, "nsslp9QXF6wOvaGzfIHsoI+23nH+e8+l1SD8bv0IFrI=", "jWRLoRafDBcFS72uPEqyqg==", "683363203", "+355", "kevinshemili1" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[] { new Guid("445248ae-bc8b-4a7e-90ce-1636f8206fa5"), new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6b8f8ee8-d394-487a-847a-cd9e40df4fcf"), new Guid("0f7195df-de82-429c-a430-dc0742edf721") });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_BorrowerId",
                table: "Applications",
                column: "BorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_LoanId",
                table: "Applications",
                column: "LoanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProductId",
                table: "Applications",
                column: "ProductId",
                unique: true);

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
                name: "ProductMatrices");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserVerificationAndReset");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Borrowers");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Lenders");
        }
    }
}
