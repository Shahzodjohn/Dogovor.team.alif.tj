using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectionProvider.Migrations
{
    public partial class ImplementingFinalLease : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerINN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citizenships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityzenshipName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizenships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContracterName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passportDateOfRelease = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfRelease = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassportName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentWays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentWays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PremisesOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremisesOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwningReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractDeadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quadrature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subrentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    possibleSubrental = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subrentals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankWithholdTaxes = table.Column<bool>(type: "bit", nullable: false),
                    OwnerPaysTaxes = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlacesAndDatesofRelease",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DateOfRelease = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacesAndDatesofRelease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlacesAndDatesofRelease_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContragentInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportId = table.Column<int>(type: "int", nullable: false),
                    AuthorityIssuingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenshipId = table.Column<int>(type: "int", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofRelease = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContragentInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContragentInfos_Citizenships_CitizenshipId",
                        column: x => x.CitizenshipId,
                        principalTable: "Citizenships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContragentInfos_Passports_PassportId",
                        column: x => x.PassportId,
                        principalTable: "Passports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentalPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreTaxesIncluded = table.Column<bool>(type: "bit", nullable: false),
                    RentalPrice = table.Column<int>(type: "int", nullable: true),
                    PaymentWayId = table.Column<int>(type: "int", nullable: false),
                    PrePayment = table.Column<bool>(type: "bit", nullable: false),
                    PrePaymentDeadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MonthlyPayment = table.Column<bool>(type: "bit", nullable: false),
                    MonthlyPaymentDeadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentWaysId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalPayment_PaymentWays_PaymentWaysId",
                        column: x => x.PaymentWaysId,
                        principalTable: "PaymentWays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BankSignatoryDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContracterId = table.Column<int>(type: "int", nullable: false),
                    WorkersFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityzenshipId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    attorney = table.Column<bool>(type: "bit", nullable: false),
                    charter = table.Column<bool>(type: "bit", nullable: false),
                    DateofRelease = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenshipId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankSignatoryDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankSignatoryDatas_Citizenships_CitizenshipId",
                        column: x => x.CitizenshipId,
                        principalTable: "Citizenships",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BankSignatoryDatas_Contracters_ContracterId",
                        column: x => x.ContracterId,
                        principalTable: "Contracters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankSignatoryDatas_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndividualEnterpreneurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalEntityPositionId = table.Column<int>(type: "int", nullable: false),
                    DateOfRelease = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualEnterpreneurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualEnterpreneurs_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LegalEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalEntityPositionId = table.Column<int>(type: "int", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LegalEntity_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaseContracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceAndDateOfReleaseId = table.Column<int>(type: "int", nullable: true),
                    BankSignatoryDataId = table.Column<int>(type: "int", nullable: true),
                    ContrAgentInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaseContracts_BankSignatoryDatas_BankSignatoryDataId",
                        column: x => x.BankSignatoryDataId,
                        principalTable: "BankSignatoryDatas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeaseContracts_ContragentInfos_ContrAgentInfoId",
                        column: x => x.ContrAgentInfoId,
                        principalTable: "ContragentInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeaseContracts_PlacesAndDatesofRelease_PlaceAndDateOfReleaseId",
                        column: x => x.PlaceAndDateOfReleaseId,
                        principalTable: "PlacesAndDatesofRelease",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NonResidentalLeases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DucumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremisesOwnerId = table.Column<int>(type: "int", nullable: true),
                    Individual = table.Column<bool>(type: "bit", nullable: false),
                    IndividualId = table.Column<int>(type: "int", nullable: true),
                    LegalEntity = table.Column<bool>(type: "bit", nullable: false),
                    LegalEntityId = table.Column<int>(type: "int", nullable: true),
                    IndividualEnterpreneur = table.Column<bool>(type: "bit", nullable: false),
                    IndividualEnterpreneurId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonResidentalLeases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonResidentalLeases_IndividualEnterpreneurs_IndividualEnterpreneurId",
                        column: x => x.IndividualEnterpreneurId,
                        principalTable: "IndividualEnterpreneurs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonResidentalLeases_Individuals_IndividualId",
                        column: x => x.IndividualId,
                        principalTable: "Individuals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonResidentalLeases_LegalEntity_LegalEntityId",
                        column: x => x.LegalEntityId,
                        principalTable: "LegalEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonResidentalLeases_PremisesOwners_PremisesOwnerId",
                        column: x => x.PremisesOwnerId,
                        principalTable: "PremisesOwners",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResetPasswords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RandomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResetPasswords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResetPasswords_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FinalizedInformationLeases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaseContractId = table.Column<int>(type: "int", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    IndividualId = table.Column<int>(type: "int", nullable: true),
                    IndividualEnterpreneurId = table.Column<int>(type: "int", nullable: true),
                    LegalEntityId = table.Column<int>(type: "int", nullable: true),
                    NonResidentalLeaseId = table.Column<int>(type: "int", nullable: true),
                    PaymentWayId = table.Column<int>(type: "int", nullable: true),
                    PremisesOwnerId = table.Column<int>(type: "int", nullable: true),
                    RentalPaymentId = table.Column<int>(type: "int", nullable: true),
                    RoomInfoId = table.Column<int>(type: "int", nullable: true),
                    SubrentalId = table.Column<int>(type: "int", nullable: true),
                    TaxesId = table.Column<int>(type: "int", nullable: true),
                    PaymentWaysId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalizedInformationLeases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_IndividualEnterpreneurs_IndividualEnterpreneurId",
                        column: x => x.IndividualEnterpreneurId,
                        principalTable: "IndividualEnterpreneurs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_Individuals_IndividualId",
                        column: x => x.IndividualId,
                        principalTable: "Individuals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_LeaseContracts_LeaseContractId",
                        column: x => x.LeaseContractId,
                        principalTable: "LeaseContracts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_LegalEntity_LegalEntityId",
                        column: x => x.LegalEntityId,
                        principalTable: "LegalEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_NonResidentalLeases_NonResidentalLeaseId",
                        column: x => x.NonResidentalLeaseId,
                        principalTable: "NonResidentalLeases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_PaymentWays_PaymentWaysId",
                        column: x => x.PaymentWaysId,
                        principalTable: "PaymentWays",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_PremisesOwners_PremisesOwnerId",
                        column: x => x.PremisesOwnerId,
                        principalTable: "PremisesOwners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_RentalPayment_RentalPaymentId",
                        column: x => x.RentalPaymentId,
                        principalTable: "RentalPayment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_RoomInfos_RoomInfoId",
                        column: x => x.RoomInfoId,
                        principalTable: "RoomInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_Subrentals_SubrentalId",
                        column: x => x.SubrentalId,
                        principalTable: "Subrentals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinalizedInformationLeases_Taxes_TaxesId",
                        column: x => x.TaxesId,
                        principalTable: "Taxes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankSignatoryDatas_CitizenshipId",
                table: "BankSignatoryDatas",
                column: "CitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_BankSignatoryDatas_ContracterId",
                table: "BankSignatoryDatas",
                column: "ContracterId");

            migrationBuilder.CreateIndex(
                name: "IX_BankSignatoryDatas_PositionId",
                table: "BankSignatoryDatas",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContragentInfos_CitizenshipId",
                table: "ContragentInfos",
                column: "CitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_ContragentInfos_PassportId",
                table: "ContragentInfos",
                column: "PassportId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_AddressId",
                table: "FinalizedInformationLeases",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_IndividualEnterpreneurId",
                table: "FinalizedInformationLeases",
                column: "IndividualEnterpreneurId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_IndividualId",
                table: "FinalizedInformationLeases",
                column: "IndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_LeaseContractId",
                table: "FinalizedInformationLeases",
                column: "LeaseContractId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_LegalEntityId",
                table: "FinalizedInformationLeases",
                column: "LegalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_NonResidentalLeaseId",
                table: "FinalizedInformationLeases",
                column: "NonResidentalLeaseId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_PaymentWaysId",
                table: "FinalizedInformationLeases",
                column: "PaymentWaysId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_PremisesOwnerId",
                table: "FinalizedInformationLeases",
                column: "PremisesOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_RentalPaymentId",
                table: "FinalizedInformationLeases",
                column: "RentalPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_RoomInfoId",
                table: "FinalizedInformationLeases",
                column: "RoomInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_SubrentalId",
                table: "FinalizedInformationLeases",
                column: "SubrentalId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalizedInformationLeases_TaxesId",
                table: "FinalizedInformationLeases",
                column: "TaxesId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualEnterpreneurs_PositionId",
                table: "IndividualEnterpreneurs",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseContracts_BankSignatoryDataId",
                table: "LeaseContracts",
                column: "BankSignatoryDataId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseContracts_ContrAgentInfoId",
                table: "LeaseContracts",
                column: "ContrAgentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseContracts_PlaceAndDateOfReleaseId",
                table: "LeaseContracts",
                column: "PlaceAndDateOfReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalEntity_PositionId",
                table: "LegalEntity",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_NonResidentalLeases_IndividualEnterpreneurId",
                table: "NonResidentalLeases",
                column: "IndividualEnterpreneurId");

            migrationBuilder.CreateIndex(
                name: "IX_NonResidentalLeases_IndividualId",
                table: "NonResidentalLeases",
                column: "IndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_NonResidentalLeases_LegalEntityId",
                table: "NonResidentalLeases",
                column: "LegalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_NonResidentalLeases_PremisesOwnerId",
                table: "NonResidentalLeases",
                column: "PremisesOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacesAndDatesofRelease_CityId",
                table: "PlacesAndDatesofRelease",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalPayment_PaymentWaysId",
                table: "RentalPayment",
                column: "PaymentWaysId");

            migrationBuilder.CreateIndex(
                name: "IX_ResetPasswords_UserId",
                table: "ResetPasswords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinalizedInformationLeases");

            migrationBuilder.DropTable(
                name: "ResetPasswords");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "LeaseContracts");

            migrationBuilder.DropTable(
                name: "NonResidentalLeases");

            migrationBuilder.DropTable(
                name: "RentalPayment");

            migrationBuilder.DropTable(
                name: "RoomInfos");

            migrationBuilder.DropTable(
                name: "Subrentals");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BankSignatoryDatas");

            migrationBuilder.DropTable(
                name: "ContragentInfos");

            migrationBuilder.DropTable(
                name: "PlacesAndDatesofRelease");

            migrationBuilder.DropTable(
                name: "IndividualEnterpreneurs");

            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "LegalEntity");

            migrationBuilder.DropTable(
                name: "PremisesOwners");

            migrationBuilder.DropTable(
                name: "PaymentWays");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Contracters");

            migrationBuilder.DropTable(
                name: "Citizenships");

            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
