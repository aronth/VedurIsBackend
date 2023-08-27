﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace dotnet.Migrations
{
    [DbContext(typeof(WeatherContext))]
    partial class WeatherContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("StationForecast", b =>
                {
                    b.Property<DateTime>("ForecastTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("AirQualityIndex")
                        .HasColumnType("REAL");

                    b.Property<double>("ChanceOfRain")
                        .HasColumnType("REAL");

                    b.Property<double>("ChanceOfSnow")
                        .HasColumnType("REAL");

                    b.Property<double>("CloudCover")
                        .HasColumnType("REAL");

                    b.Property<double>("DewPoint")
                        .HasColumnType("REAL");

                    b.Property<double>("FeelsLike")
                        .HasColumnType("REAL");

                    b.Property<Guid>("ForecastId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ForecastText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("HeatIndex")
                        .HasColumnType("REAL");

                    b.Property<double>("Humidity")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("ObservationTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("Precipitation")
                        .HasColumnType("REAL");

                    b.Property<double>("Pressure")
                        .HasColumnType("REAL");

                    b.Property<int>("StationId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Temperature")
                        .HasColumnType("REAL");

                    b.Property<double>("UVIndex")
                        .HasColumnType("REAL");

                    b.Property<double>("Visibility")
                        .HasColumnType("REAL");

                    b.Property<double>("WindChill")
                        .HasColumnType("REAL");

                    b.Property<string>("WindDirection")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("WindGust")
                        .HasColumnType("REAL");

                    b.Property<double>("WindSpeed")
                        .HasColumnType("REAL");

                    b.HasKey("ForecastTime");

                    b.ToTable("StationForecasts");
                });

            modelBuilder.Entity("WeatherCheck", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CheckedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("StationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("WeatherChecks");
                });
#pragma warning restore 612, 618
        }
    }
}
