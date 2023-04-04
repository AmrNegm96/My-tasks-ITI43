﻿// <auto-generated />
using System;
using CompanyConsoleApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyConsoleApp.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20230224200847_addEmployeeClientRelation")]
    partial class addEmployeeClientRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BranchClient", b =>
                {
                    b.Property<int>("BranchesId")
                        .HasColumnType("int");

                    b.Property<int>("ClientsCID")
                        .HasColumnType("int");

                    b.HasKey("BranchesId", "ClientsCID");

                    b.HasIndex("ClientsCID");

                    b.ToTable("BranchClient");
                });

            modelBuilder.Entity("CompanyConsoleApp.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("CompanyConsoleApp.Entities.Client", b =>
                {
                    b.Property<int>("CID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CID"));

                    b.Property<decimal>("Deposit")
                        .HasColumnType("money")
                        .HasColumnName("OrderDeposit");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nchar(2)")
                        .IsFixedLength();

                    b.HasKey("CID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CompanyConsoleApp.Entities.Employee", b =>
                {
                    b.Property<int>("EId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EId"));

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("MName")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("Money");

                    b.HasKey("EId");

                    b.HasIndex("BranchId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CompanyConsoleApp.Entities.EmployeeClient", b =>
                {
                    b.Property<int>("clientCID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeEID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Visit")
                        .HasColumnType("datetime2");

                    b.HasKey("clientCID", "EmployeeEID");

                    b.HasIndex("EmployeeEID");

                    b.ToTable("EmployeeClient");
                });

            modelBuilder.Entity("BranchClient", b =>
                {
                    b.HasOne("CompanyConsoleApp.Entities.Branch", null)
                        .WithMany()
                        .HasForeignKey("BranchesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyConsoleApp.Entities.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsCID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyConsoleApp.Entities.Employee", b =>
                {
                    b.HasOne("CompanyConsoleApp.Entities.Branch", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("BranchId");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("CompanyConsoleApp.Entities.EmployeeClient", b =>
                {
                    b.HasOne("CompanyConsoleApp.Entities.Employee", "Employee")
                        .WithMany("EmployeeClients")
                        .HasForeignKey("EmployeeEID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyConsoleApp.Entities.Client", "Client")
                        .WithMany("EmployeeClients")
                        .HasForeignKey("clientCID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CompanyConsoleApp.Entities.Branch", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CompanyConsoleApp.Entities.Client", b =>
                {
                    b.Navigation("EmployeeClients");
                });

            modelBuilder.Entity("CompanyConsoleApp.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeClients");
                });
#pragma warning restore 612, 618
        }
    }
}
