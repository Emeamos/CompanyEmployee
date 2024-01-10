﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231224202109_InitialData")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CompanyId")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new byte[] { 83, 192, 212, 201, 182, 73, 12, 65, 188, 120, 45, 84, 169, 153, 24, 112 },
                            Address = "583 Wall Dr. Gwynn Oak, MD 21207",
                            Country = "USA",
                            Name = "IT_Solutions Ltd"
                        },
                        new
                        {
                            Id = new byte[] { 112, 10, 73, 61, 206, 148, 21, 77, 148, 148, 82, 72, 40, 12, 44, 227 },
                            Address = "312 Forest Avenue, BF 923",
                            Country = "USA",
                            Name = "Admin_Solutions Ltd"
                        });
                });

            modelBuilder.Entity("Entities.Models.Employee", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeId")
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<byte[]>("CompanyId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new byte[] { 168, 188, 171, 128, 77, 102, 32, 75, 181, 222, 2, 71, 5, 73, 125, 74 },
                            Age = 26,
                            CompanyId = new byte[] { 83, 192, 212, 201, 182, 73, 12, 65, 188, 120, 45, 84, 169, 153, 24, 112 },
                            Name = "Sam Raiden",
                            Position = "Software developer"
                        },
                        new
                        {
                            Id = new byte[] { 192, 168, 219, 134, 120, 209, 231, 65, 147, 140, 237, 73, 119, 143, 181, 42 },
                            Age = 30,
                            CompanyId = new byte[] { 83, 192, 212, 201, 182, 73, 12, 65, 188, 120, 45, 84, 169, 153, 24, 112 },
                            Name = "Jana McLeaf",
                            Position = "Software developer"
                        },
                        new
                        {
                            Id = new byte[] { 193, 163, 28, 2, 235, 13, 253, 74, 174, 148, 33, 89, 168, 71, 152, 17 },
                            Age = 35,
                            CompanyId = new byte[] { 112, 10, 73, 61, 206, 148, 21, 77, 148, 148, 82, 72, 40, 12, 44, 227 },
                            Name = "Kane Miller",
                            Position = "Administrator"
                        });
                });

            modelBuilder.Entity("Entities.Models.Employee", b =>
                {
                    b.HasOne("Entities.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
