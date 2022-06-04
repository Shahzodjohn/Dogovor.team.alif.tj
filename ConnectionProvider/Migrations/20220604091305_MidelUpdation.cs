using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectionProvider.Migrations
{
    public partial class MidelUpdation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "LeaseContracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceAndDateOfReleaseId = table.Column<int>(type: "int", nullable: false),
                    BankSignatoryDataId = table.Column<int>(type: "int", nullable: false),
                    ContrAgentInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaseContracts_BankSignatoryDatas_BankSignatoryDataId",
                        column: x => x.BankSignatoryDataId,
                        principalTable: "BankSignatoryDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaseContracts_ContragentInfos_ContrAgentInfoId",
                        column: x => x.ContrAgentInfoId,
                        principalTable: "ContragentInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaseContracts_PlacesAndDatesofRelease_PlaceAndDateOfReleaseId",
                        column: x => x.PlaceAndDateOfReleaseId,
                        principalTable: "PlacesAndDatesofRelease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_PlacesAndDatesofRelease_CityId",
                table: "PlacesAndDatesofRelease",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaseContracts");

            migrationBuilder.DropTable(
                name: "BankSignatoryDatas");

            migrationBuilder.DropTable(
                name: "ContragentInfos");

            migrationBuilder.DropTable(
                name: "PlacesAndDatesofRelease");

            migrationBuilder.DropTable(
                name: "Contracters");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Citizenships");

            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
