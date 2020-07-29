using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID19Relief.Middleware.Migrations
{
    public partial class OnMyWindowsMac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    BankId = table.Column<byte>(nullable: false),
                    BankName = table.Column<string>(maxLength: 50, nullable: false),
                    BankCode = table.Column<string>(maxLength: 50, nullable: true),
                    BankSortCode = table.Column<string>(maxLength: 50, nullable: true),
                    BankType = table.Column<string>(maxLength: 50, nullable: false),
                    NIPCode = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityTypes",
                columns: table => new
                {
                    IdentityTypesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityTypes", x => x.IdentityTypesId);
                });

            migrationBuilder.CreateTable(
                name: "OtpTable",
                columns: table => new
                {
                    OtpTableId = table.Column<int>(nullable: false),
                    UserEmail = table.Column<string>(maxLength: 250, nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    DateInserted = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    DateOtpverified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpTable", x => x.OtpTableId);
                });

            migrationBuilder.CreateTable(
                name: "StateLocalGovernment",
                columns: table => new
                {
                    StateLocalGovernmentId = table.Column<short>(nullable: false),
                    StateId = table.Column<byte>(nullable: false),
                    LocalGovernmentName = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<byte>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModifiedDate = table.Column<string>(maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateLocalGovernment", x => x.StateLocalGovernmentId);
                });

            migrationBuilder.CreateTable(
                name: "StatesTable",
                columns: table => new
                {
                    StateId = table.Column<byte>(nullable: false),
                    StateName = table.Column<string>(maxLength: 50, nullable: false),
                    StateCode = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Region = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatesTable", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    TitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    UsersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    bvn = table.Column<string>(maxLength: 50, nullable: false),
                    BvnIsValidated = table.Column<bool>(nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: false),
                    EmailIsValidated = table.Column<bool>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumberIsValidated = table.Column<bool>(nullable: true),
                    AccountNumber = table.Column<string>(maxLength: 50, nullable: false),
                    AccountNumberIsValidated = table.Column<bool>(nullable: true),
                    BankId = table.Column<string>(maxLength: 50, nullable: true),
                    StateId = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    IdentityDocumentType = table.Column<string>(maxLength: 50, nullable: false),
                    DocumentIdNumber = table.Column<string>(maxLength: 50, nullable: false),
                    SpouseUniqueNumber = table.Column<int>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    MaritalStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NoOfDependents = table.Column<int>(nullable: true),
                    LocalGovernmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.UsersId);
                });

            migrationBuilder.CreateTable(
                name: "BVNDetails",
                columns: table => new
                {
                    BVNDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EnrollmentBank = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 250, nullable: false),
                    Gender = table.Column<string>(maxLength: 50, nullable: false),
                    LGAOfOrigin = table.Column<string>(maxLength: 50, nullable: false),
                    LGAOfResidence = table.Column<string>(maxLength: 50, nullable: false),
                    Nationality = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumberAlt = table.Column<string>(maxLength: 50, nullable: false),
                    ResidentialAddress = table.Column<string>(maxLength: 50, nullable: false),
                    StateOfOrigin = table.Column<string>(maxLength: 50, nullable: false),
                    StateOfResidence = table.Column<string>(maxLength: 50, nullable: false),
                    WatchListed = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BVNDetails", x => x.BVNDetailsId);
                    table.ForeignKey(
                        name: "FK_User_BVNDetails",
                        column: x => x.UserId,
                        principalTable: "USERS",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PaymentDetailsId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PaymentRef = table.Column<string>(maxLength: 50, nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    CReatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PaymentDetailsId);
                    table.ForeignKey(
                        name: "FK_Users_Payment",
                        column: x => x.UserId,
                        principalTable: "USERS",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalaryDetails",
                columns: table => new
                {
                    SalaryDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    SalaryAmount = table.Column<double>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryDetails", x => x.SalaryDetailsId);
                    table.ForeignKey(
                        name: "FK_Users_SalaryDetails",
                        column: x => x.UserId,
                        principalTable: "USERS",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalaryWorkersDetails",
                columns: table => new
                {
                    SalaryWorkersDetaildId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ActiveEmail = table.Column<string>(maxLength: 250, nullable: false),
                    ActivePhoneNumber = table.Column<string>(maxLength: 50, nullable: false),
                    AreYouCurrentlyInEmployment = table.Column<bool>(nullable: false),
                    EmployerName = table.Column<string>(maxLength: 250, nullable: false),
                    EmployerIndustry = table.Column<string>(maxLength: 50, nullable: false),
                    EmployerRcNoOrBrNo = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfEmployment = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateOfLeaving = table.Column<DateTime>(type: "datetime", nullable: false),
                    AvgMonthlySalaryForSixMonths = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SalaryWo__1DBEF810E920B61A", x => x.SalaryWorkersDetaildId);
                    table.ForeignKey(
                        name: "FK_Users_SalaryWorkersDetails",
                        column: x => x.UserId,
                        principalTable: "USERS",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SelfEmployedWorkersDetails",
                columns: table => new
                {
                    SelfEmployedWorkersDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ActiveResidentialAddress = table.Column<string>(maxLength: 250, nullable: false),
                    ActivePhoneNumber = table.Column<string>(maxLength: 50, nullable: false),
                    NameOfBusiness = table.Column<string>(maxLength: 250, nullable: false),
                    Industry = table.Column<string>(maxLength: 50, nullable: false),
                    BusinessDescription = table.Column<string>(nullable: false),
                    BusinessRcNoOrBrNo = table.Column<string>(maxLength: 50, nullable: false),
                    OwnBusinessAlone = table.Column<bool>(nullable: false),
                    BusinessStillOperational = table.Column<bool>(nullable: false),
                    StartDateOfBusiness = table.Column<DateTime>(type: "datetime", nullable: false),
                    CloseDateOfBusiness = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateOfLeaving = table.Column<DateTime>(type: "datetime", nullable: false),
                    AvgMonthlySalaryForSixMonths = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfEmployedWorkersDetails", x => x.SelfEmployedWorkersDetailsId);
                    table.ForeignKey(
                        name: "FK_Users_SelfEmployedWorkersDetails",
                        column: x => x.UserId,
                        principalTable: "USERS",
                        principalColumn: "UsersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BVNDetails_UserId",
                table: "BVNDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_UserId",
                table: "PaymentDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryDetails_UserId",
                table: "SalaryDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryWorkersDetails_UserId",
                table: "SalaryWorkersDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SelfEmployedWorkersDetails_UserId",
                table: "SelfEmployedWorkersDetails",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "BVNDetails");

            migrationBuilder.DropTable(
                name: "IdentityTypes");

            migrationBuilder.DropTable(
                name: "OtpTable");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "SalaryDetails");

            migrationBuilder.DropTable(
                name: "SalaryWorkersDetails");

            migrationBuilder.DropTable(
                name: "SelfEmployedWorkersDetails");

            migrationBuilder.DropTable(
                name: "StateLocalGovernment");

            migrationBuilder.DropTable(
                name: "StatesTable");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "USERS");
        }
    }
}
