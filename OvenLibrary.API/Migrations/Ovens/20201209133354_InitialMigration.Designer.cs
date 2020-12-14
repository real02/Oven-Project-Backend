﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OvenLibrary.API.DbContexts;

namespace OvenLibrary.API.Migrations.Ovens
{
    [DbContext(typeof(OvensContext))]
    [Migration("20201209133354_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("OvenLibrary.API.Entities.Measurement", b =>
                {
                    b.Property<long>("MeasurementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("OvenId")
                        .HasColumnType("bigint");

                    b.Property<double>("PowerConsumption")
                        .HasColumnType("float");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<double>("TemperatureInFahrenheit")
                        .HasColumnType("float");

                    b.HasKey("MeasurementId");

                    b.HasIndex("OvenId");

                    b.ToTable("Measurements");

                    b.HasData(
                        new
                        {
                            MeasurementId = 1L,
                            DateTime = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 1L,
                            PowerConsumption = 2.29,
                            Temperature = 28.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 2L,
                            DateTime = new DateTime(2020, 8, 1, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 1L,
                            PowerConsumption = 2.3300000000000001,
                            Temperature = 22.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 3L,
                            DateTime = new DateTime(2020, 8, 1, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 1L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 24.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 4L,
                            DateTime = new DateTime(2020, 8, 1, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 1L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 26.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 5L,
                            DateTime = new DateTime(2020, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 1L,
                            PowerConsumption = 3.1000000000000001,
                            Temperature = 221.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 6L,
                            DateTime = new DateTime(2020, 8, 1, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 1L,
                            PowerConsumption = 3.2000000000000002,
                            Temperature = 23.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 7L,
                            DateTime = new DateTime(2020, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 1L,
                            PowerConsumption = 2.3999999999999999,
                            Temperature = 19.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 8L,
                            DateTime = new DateTime(2020, 8, 1, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 1L,
                            PowerConsumption = 3.0,
                            Temperature = 22.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 9L,
                            DateTime = new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 1L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 20.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 10L,
                            DateTime = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 2L,
                            PowerConsumption = 2.29,
                            Temperature = 21.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 11L,
                            DateTime = new DateTime(2020, 8, 1, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 2L,
                            PowerConsumption = 2.3300000000000001,
                            Temperature = 22.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 12L,
                            DateTime = new DateTime(2020, 8, 1, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 2L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 23.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 13L,
                            DateTime = new DateTime(2020, 8, 1, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 2L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 24.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 14L,
                            DateTime = new DateTime(2020, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 2L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 20.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 15L,
                            DateTime = new DateTime(2020, 8, 1, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 2L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 19.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 16L,
                            DateTime = new DateTime(2020, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 2L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 18.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 17L,
                            DateTime = new DateTime(2020, 8, 1, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 2L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 20.0,
                            TemperatureInFahrenheit = 0.0
                        },
                        new
                        {
                            MeasurementId = 18L,
                            DateTime = new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OvenId = 2L,
                            PowerConsumption = 3.3999999999999999,
                            Temperature = 23.0,
                            TemperatureInFahrenheit = 0.0
                        });
                });

            modelBuilder.Entity("OvenLibrary.API.Entities.Oven", b =>
                {
                    b.Property<long>("OvenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LocationLatitude")
                        .HasColumnType("float");

                    b.Property<double>("LocationLongitude")
                        .HasColumnType("float");

                    b.HasKey("OvenId");

                    b.ToTable("Ovens");

                    b.HasData(
                        new
                        {
                            OvenId = 1L,
                            Address = "Krapinska 15",
                            LocationLatitude = 45.804232267064577,
                            LocationLongitude = 15.948932298011403
                        },
                        new
                        {
                            OvenId = 2L,
                            Address = "Rooseveltov trg 5",
                            LocationLatitude = 45.808512770246949,
                            LocationLongitude = 15.966035138678405
                        });
                });

            modelBuilder.Entity("OvenLibrary.API.Entities.Measurement", b =>
                {
                    b.HasOne("OvenLibrary.API.Entities.Oven", null)
                        .WithMany("Measurements")
                        .HasForeignKey("OvenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OvenLibrary.API.Entities.Oven", b =>
                {
                    b.Navigation("Measurements");
                });
#pragma warning restore 612, 618
        }
    }
}
