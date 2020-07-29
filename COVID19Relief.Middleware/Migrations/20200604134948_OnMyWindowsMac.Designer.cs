﻿// <auto-generated />
using System;
using COVID19Relief.Middleware.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COVID19Relief.Middleware.Migrations
{
    [DbContext(typeof(COVONENINEContext))]
    [Migration("20200604134948_OnMyWindowsMac")]
    partial class OnMyWindowsMac
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COVID19Relief.Middleware.Model.Banks", b =>
                {
                    b.Property<byte>("BankId")
                        .HasColumnType("tinyint");

                    b.Property<string>("BankCode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BankSortCode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BankType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nipcode")
                        .HasColumnName("NIPCode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("BankId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.Bvndetails", b =>
                {
                    b.Property<int>("BvndetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BVNDetailsId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("EnrollmentBank")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LgaofOrigin")
                        .IsRequired()
                        .HasColumnName("LGAOfOrigin")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LgaofResidence")
                        .IsRequired()
                        .HasColumnName("LGAOfResidence")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("PhoneNumberAlt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ResidentialAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("StateOfOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("StateOfResidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WatchListed")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("BvndetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("BVNDetails");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.IdentityTypes", b =>
                {
                    b.Property<int>("IdentityTypesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdentityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdentityTypesId");

                    b.ToTable("IdentityTypes");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.OtpTable", b =>
                {
                    b.Property<int>("OtpTableId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("DateInserted")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOtpverified")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("OtpTableId");

                    b.ToTable("OtpTable");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.PaymentDetails", b =>
                {
                    b.Property<int>("PaymentDetailsId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CReatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("PaymentRef")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PaymentDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.SalaryDetails", b =>
                {
                    b.Property<int>("SalaryDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<double>("SalaryAmount")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("SalaryDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("SalaryDetails");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.SalaryWorkersDetails", b =>
                {
                    b.Property<int>("SalaryWorkersDetaildId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("ActivePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("AreYouCurrentlyInEmployment")
                        .HasColumnType("bit");

                    b.Property<string>("AvgMonthlySalaryForSixMonths")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("DateOfEmployment")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOfLeaving")
                        .HasColumnType("datetime");

                    b.Property<string>("EmployerIndustry")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("EmployerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("EmployerRcNoOrBrNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SalaryWorkersDetaildId")
                        .HasName("PK__SalaryWo__1DBEF810E920B61A");

                    b.HasIndex("UserId");

                    b.ToTable("SalaryWorkersDetails");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.SelfEmployedWorkersDetails", b =>
                {
                    b.Property<int>("SelfEmployedWorkersDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ActiveResidentialAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("AvgMonthlySalaryForSixMonths")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BusinessDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessRcNoOrBrNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("BusinessStillOperational")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CloseDateOfBusiness")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("DateOfLeaving")
                        .HasColumnType("datetime");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NameOfBusiness")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<bool>("OwnBusinessAlone")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDateOfBusiness")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SelfEmployedWorkersDetailsId");

                    b.HasIndex("UserId");

                    b.ToTable("SelfEmployedWorkersDetails");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.StateLocalGovernment", b =>
                {
                    b.Property<short>("StateLocalGovernmentId")
                        .HasColumnType("smallint");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("IsActive")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LocalGovernmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte>("StateId")
                        .HasColumnType("tinyint");

                    b.HasKey("StateLocalGovernmentId");

                    b.ToTable("StateLocalGovernment");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.StatesTable", b =>
                {
                    b.Property<byte>("StateId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("StateId");

                    b.ToTable("StatesTable");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TitleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("TitleId");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.Users", b =>
                {
                    b.Property<int>("UsersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("AccountNumberIsValidated")
                        .HasColumnType("bit");

                    b.Property<string>("BankId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Bvn")
                        .IsRequired()
                        .HasColumnName("bvn")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("BvnIsValidated")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("DocumentIdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<bool?>("EmailIsValidated")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("IdentityDocumentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("LocalGovernmentId")
                        .HasColumnType("int");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("NoOfDependents")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("PhoneNumberIsValidated")
                        .HasColumnType("bit");

                    b.Property<int?>("SpouseUniqueNumber")
                        .HasColumnType("int");

                    b.Property<string>("StateId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UsersId");

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.Bvndetails", b =>
                {
                    b.HasOne("COVID19Relief.Middleware.Model.Users", "User")
                        .WithMany("Bvndetails")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_User_BVNDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.PaymentDetails", b =>
                {
                    b.HasOne("COVID19Relief.Middleware.Model.Users", "User")
                        .WithMany("PaymentDetails")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Users_Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.SalaryDetails", b =>
                {
                    b.HasOne("COVID19Relief.Middleware.Model.Users", "User")
                        .WithMany("SalaryDetails")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Users_SalaryDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.SalaryWorkersDetails", b =>
                {
                    b.HasOne("COVID19Relief.Middleware.Model.Users", "User")
                        .WithMany("SalaryWorkersDetails")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Users_SalaryWorkersDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("COVID19Relief.Middleware.Model.SelfEmployedWorkersDetails", b =>
                {
                    b.HasOne("COVID19Relief.Middleware.Model.Users", "User")
                        .WithMany("SelfEmployedWorkersDetails")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Users_SelfEmployedWorkersDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}