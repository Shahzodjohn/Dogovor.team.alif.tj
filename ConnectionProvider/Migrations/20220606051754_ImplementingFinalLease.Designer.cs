﻿// <auto-generated />
using System;
using ConnectionProvider.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConnectionProvider.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220606051754_ImplementingFinalLease")]
    partial class ImplementingFinalLease
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entity.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("HomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerINN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Entity.BankSignatoryData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CitizenshipId")
                        .HasColumnType("int");

                    b.Property<int>("CityzenshipId")
                        .HasColumnType("int");

                    b.Property<int>("ContracterId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateofRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<string>("WorkersFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("attorney")
                        .HasColumnType("bit");

                    b.Property<bool>("charter")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CitizenshipId");

                    b.HasIndex("ContracterId");

                    b.HasIndex("PositionId");

                    b.ToTable("BankSignatoryDatas");
                });

            modelBuilder.Entity("Entity.Citizenship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityzenshipName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Citizenships");
                });

            modelBuilder.Entity("Entity.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Entity.Contracter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ContracterName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contracters");
                });

            modelBuilder.Entity("Entity.ContragentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AuthorityIssuingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CitizenshipId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateofRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassportId")
                        .HasColumnType("int");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CitizenshipId");

                    b.HasIndex("PassportId");

                    b.ToTable("ContragentInfos");
                });

            modelBuilder.Entity("Entity.Departments.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Entity.FinalizedInformationLease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("IndividualEnterpreneurId")
                        .HasColumnType("int");

                    b.Property<int?>("IndividualId")
                        .HasColumnType("int");

                    b.Property<int?>("LeaseContractId")
                        .HasColumnType("int");

                    b.Property<int?>("LegalEntityId")
                        .HasColumnType("int");

                    b.Property<int?>("NonResidentalLeaseId")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentWayId")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentWaysId")
                        .HasColumnType("int");

                    b.Property<int?>("PremisesOwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("RentalPaymentId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomInfoId")
                        .HasColumnType("int");

                    b.Property<int?>("SubrentalId")
                        .HasColumnType("int");

                    b.Property<int?>("TaxesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("IndividualEnterpreneurId");

                    b.HasIndex("IndividualId");

                    b.HasIndex("LeaseContractId");

                    b.HasIndex("LegalEntityId");

                    b.HasIndex("NonResidentalLeaseId");

                    b.HasIndex("PaymentWaysId");

                    b.HasIndex("PremisesOwnerId");

                    b.HasIndex("RentalPaymentId");

                    b.HasIndex("RoomInfoId");

                    b.HasIndex("SubrentalId");

                    b.HasIndex("TaxesId");

                    b.ToTable("FinalizedInformationLeases");
                });

            modelBuilder.Entity("Entity.Individual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PassportNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfRelease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("passportDateOfRelease")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("Entity.IndividualEnterpreneur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LegalEntityPositionId")
                        .HasColumnType("int");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("IndividualEnterpreneurs");
                });

            modelBuilder.Entity("Entity.LeaseContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BankSignatoryDataId")
                        .HasColumnType("int");

                    b.Property<int?>("ContrAgentInfoId")
                        .HasColumnType("int");

                    b.Property<int?>("PlaceAndDateOfReleaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankSignatoryDataId");

                    b.HasIndex("ContrAgentInfoId");

                    b.HasIndex("PlaceAndDateOfReleaseId");

                    b.ToTable("LeaseContracts");
                });

            modelBuilder.Entity("Entity.LegalEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EntityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LegalEntityPositionId")
                        .HasColumnType("int");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("LegalEntity");
                });

            modelBuilder.Entity("Entity.NonResidentalLease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DucumentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Individual")
                        .HasColumnType("bit");

                    b.Property<bool>("IndividualEnterpreneur")
                        .HasColumnType("bit");

                    b.Property<int?>("IndividualEnterpreneurId")
                        .HasColumnType("int");

                    b.Property<int?>("IndividualId")
                        .HasColumnType("int");

                    b.Property<bool>("LegalEntity")
                        .HasColumnType("bit");

                    b.Property<int?>("LegalEntityId")
                        .HasColumnType("int");

                    b.Property<int?>("PremisesOwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IndividualEnterpreneurId");

                    b.HasIndex("IndividualId");

                    b.HasIndex("LegalEntityId");

                    b.HasIndex("PremisesOwnerId");

                    b.ToTable("NonResidentalLeases");
                });

            modelBuilder.Entity("Entity.Passport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PassportName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Passports");
                });

            modelBuilder.Entity("Entity.PaymentWays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("WayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentWays");
                });

            modelBuilder.Entity("Entity.PlaceAndDateofRelease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PlacesAndDatesofRelease");
                });

            modelBuilder.Entity("Entity.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Entity.PremisesOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PremisesOwners");
                });

            modelBuilder.Entity("Entity.RentalPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AreTaxesIncluded")
                        .HasColumnType("bit");

                    b.Property<bool>("MonthlyPayment")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("MonthlyPaymentDeadline")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentWayId")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentWaysId")
                        .HasColumnType("int");

                    b.Property<bool>("PrePayment")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PrePaymentDeadline")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RentalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaymentWaysId");

                    b.ToTable("RentalPayment");
                });

            modelBuilder.Entity("Entity.Reset.ResetPassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("RandomNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ValidDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ResetPasswords");
                });

            modelBuilder.Entity("Entity.Roles.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Entity.RoomInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContractDeadline")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DocumentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OwningReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quadrature")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomInfos");
                });

            modelBuilder.Entity("Entity.Subrental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("possibleSubrental")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Subrentals");
                });

            modelBuilder.Entity("Entity.Taxes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("BankWithholdTaxes")
                        .HasColumnType("bit");

                    b.Property<bool>("OwnerPaysTaxes")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("Entity.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entity.BankSignatoryData", b =>
                {
                    b.HasOne("Entity.Citizenship", "Citizenship")
                        .WithMany()
                        .HasForeignKey("CitizenshipId");

                    b.HasOne("Entity.Contracter", "Contracter")
                        .WithMany()
                        .HasForeignKey("ContracterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Citizenship");

                    b.Navigation("Contracter");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Entity.ContragentInfo", b =>
                {
                    b.HasOne("Entity.Citizenship", "Citizenship")
                        .WithMany()
                        .HasForeignKey("CitizenshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Passport", "Passport")
                        .WithMany()
                        .HasForeignKey("PassportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Citizenship");

                    b.Navigation("Passport");
                });

            modelBuilder.Entity("Entity.FinalizedInformationLease", b =>
                {
                    b.HasOne("Entity.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Entity.IndividualEnterpreneur", "IndividualEnterpreneur")
                        .WithMany()
                        .HasForeignKey("IndividualEnterpreneurId");

                    b.HasOne("Entity.Individual", "Individual")
                        .WithMany()
                        .HasForeignKey("IndividualId");

                    b.HasOne("Entity.LeaseContract", "LeaseContract")
                        .WithMany()
                        .HasForeignKey("LeaseContractId");

                    b.HasOne("Entity.LegalEntity", "LegalEntity")
                        .WithMany()
                        .HasForeignKey("LegalEntityId");

                    b.HasOne("Entity.NonResidentalLease", "NonResidentalLease")
                        .WithMany()
                        .HasForeignKey("NonResidentalLeaseId");

                    b.HasOne("Entity.PaymentWays", "PaymentWays")
                        .WithMany()
                        .HasForeignKey("PaymentWaysId");

                    b.HasOne("Entity.PremisesOwner", "PremisesOwner")
                        .WithMany()
                        .HasForeignKey("PremisesOwnerId");

                    b.HasOne("Entity.RentalPayment", "RentalPayment")
                        .WithMany()
                        .HasForeignKey("RentalPaymentId");

                    b.HasOne("Entity.RoomInfo", "RoomInfo")
                        .WithMany()
                        .HasForeignKey("RoomInfoId");

                    b.HasOne("Entity.Subrental", "Subrental")
                        .WithMany()
                        .HasForeignKey("SubrentalId");

                    b.HasOne("Entity.Taxes", "Taxes")
                        .WithMany()
                        .HasForeignKey("TaxesId");

                    b.Navigation("Address");

                    b.Navigation("Individual");

                    b.Navigation("IndividualEnterpreneur");

                    b.Navigation("LeaseContract");

                    b.Navigation("LegalEntity");

                    b.Navigation("NonResidentalLease");

                    b.Navigation("PaymentWays");

                    b.Navigation("PremisesOwner");

                    b.Navigation("RentalPayment");

                    b.Navigation("RoomInfo");

                    b.Navigation("Subrental");

                    b.Navigation("Taxes");
                });

            modelBuilder.Entity("Entity.IndividualEnterpreneur", b =>
                {
                    b.HasOne("Entity.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Entity.LeaseContract", b =>
                {
                    b.HasOne("Entity.BankSignatoryData", "BankSignatoryData")
                        .WithMany()
                        .HasForeignKey("BankSignatoryDataId");

                    b.HasOne("Entity.ContragentInfo", "ContragentInfo")
                        .WithMany()
                        .HasForeignKey("ContrAgentInfoId");

                    b.HasOne("Entity.PlaceAndDateofRelease", "PlaceAndDateofRelease")
                        .WithMany()
                        .HasForeignKey("PlaceAndDateOfReleaseId");

                    b.Navigation("BankSignatoryData");

                    b.Navigation("ContragentInfo");

                    b.Navigation("PlaceAndDateofRelease");
                });

            modelBuilder.Entity("Entity.LegalEntity", b =>
                {
                    b.HasOne("Entity.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Entity.NonResidentalLease", b =>
                {
                    b.HasOne("Entity.IndividualEnterpreneur", "LegalEnterpreneurs")
                        .WithMany()
                        .HasForeignKey("IndividualEnterpreneurId");

                    b.HasOne("Entity.Individual", "Individuals")
                        .WithMany()
                        .HasForeignKey("IndividualId");

                    b.HasOne("Entity.LegalEntity", "LegalEntitys")
                        .WithMany()
                        .HasForeignKey("LegalEntityId");

                    b.HasOne("Entity.PremisesOwner", "PremisesOwners")
                        .WithMany()
                        .HasForeignKey("PremisesOwnerId");

                    b.Navigation("Individuals");

                    b.Navigation("LegalEnterpreneurs");

                    b.Navigation("LegalEntitys");

                    b.Navigation("PremisesOwners");
                });

            modelBuilder.Entity("Entity.PlaceAndDateofRelease", b =>
                {
                    b.HasOne("Entity.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Entity.RentalPayment", b =>
                {
                    b.HasOne("Entity.PaymentWays", "PaymentWays")
                        .WithMany()
                        .HasForeignKey("PaymentWaysId");

                    b.Navigation("PaymentWays");
                });

            modelBuilder.Entity("Entity.Reset.ResetPassword", b =>
                {
                    b.HasOne("Entity.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.Users.User", b =>
                {
                    b.HasOne("Entity.Departments.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Roles.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}