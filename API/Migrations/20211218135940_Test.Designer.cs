﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(TemplateDBContext))]
    [Migration("20211218135940_Test")]
    partial class Test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Models.Output", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DörrBenämning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Time")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Outputs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826772L
                        },
                        new
                        {
                            ID = 2,
                            Code = "DÖUT",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826939L
                        },
                        new
                        {
                            ID = 3,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754363807826942L
                        },
                        new
                        {
                            ID = 4,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754363807826944L
                        },
                        new
                        {
                            ID = 5,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754363807826947L
                        },
                        new
                        {
                            ID = 6,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754363807826949L
                        },
                        new
                        {
                            ID = 7,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754363807826951L
                        },
                        new
                        {
                            ID = 8,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754363807826953L
                        },
                        new
                        {
                            ID = 9,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754363807826955L
                        },
                        new
                        {
                            ID = 10,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754363807826957L
                        },
                        new
                        {
                            ID = 11,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826958L
                        },
                        new
                        {
                            ID = 12,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826960L
                        },
                        new
                        {
                            ID = 13,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826962L
                        },
                        new
                        {
                            ID = 14,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826963L
                        },
                        new
                        {
                            ID = 15,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826965L
                        },
                        new
                        {
                            ID = 16,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826969L
                        },
                        new
                        {
                            ID = 17,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826971L
                        },
                        new
                        {
                            ID = 18,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826973L
                        },
                        new
                        {
                            ID = 19,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826974L
                        },
                        new
                        {
                            ID = 20,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826976L
                        },
                        new
                        {
                            ID = 21,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826978L
                        },
                        new
                        {
                            ID = 22,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754363807826979L
                        });
                });

            modelBuilder.Entity("API.Models.Tenant", b =>
                {
                    b.Property<int>("TenantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TenantID"), 1L, 1);

                    b.Property<int>("Apartment")
                        .HasColumnType("int");

                    b.Property<string>("Namne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TenantID");

                    b.ToTable("Tenants");

                    b.HasData(
                        new
                        {
                            TenantID = 1,
                            Apartment = 1001,
                            Namne = "Göran Svensson",
                            Tag = "1001A"
                        },
                        new
                        {
                            TenantID = 2,
                            Apartment = 1002,
                            Namne = "Göran Andersson",
                            Tag = "1002A"
                        },
                        new
                        {
                            TenantID = 3,
                            Apartment = 1002,
                            Namne = "Jonas Andersson",
                            Tag = "1002B"
                        },
                        new
                        {
                            TenantID = 4,
                            Apartment = 1001,
                            Namne = "Stefan Andersson",
                            Tag = "1002B"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
