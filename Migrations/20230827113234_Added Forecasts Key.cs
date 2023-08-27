using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet.Migrations
{
    /// <inheritdoc />
    public partial class AddedForecastsKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "WeatherChecks");

            migrationBuilder.DropColumn(
                name: "ForecastId",
                table: "WeatherChecks");

            migrationBuilder.CreateTable(
                name: "StationForecasts",
                columns: table => new
                {
                    ForecastTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ForecastId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StationId = table.Column<int>(type: "INTEGER", nullable: false),
                    ObservationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ForecastText = table.Column<string>(type: "TEXT", nullable: false),
                    Temperature = table.Column<double>(type: "REAL", nullable: false),
                    WindSpeed = table.Column<double>(type: "REAL", nullable: false),
                    WindDirection = table.Column<string>(type: "TEXT", nullable: false),
                    WindGust = table.Column<double>(type: "REAL", nullable: false),
                    Pressure = table.Column<double>(type: "REAL", nullable: false),
                    Humidity = table.Column<double>(type: "REAL", nullable: false),
                    Visibility = table.Column<double>(type: "REAL", nullable: false),
                    CloudCover = table.Column<double>(type: "REAL", nullable: false),
                    Precipitation = table.Column<double>(type: "REAL", nullable: false),
                    AirQualityIndex = table.Column<double>(type: "REAL", nullable: false),
                    UVIndex = table.Column<double>(type: "REAL", nullable: false),
                    DewPoint = table.Column<double>(type: "REAL", nullable: false),
                    WindChill = table.Column<double>(type: "REAL", nullable: false),
                    HeatIndex = table.Column<double>(type: "REAL", nullable: false),
                    FeelsLike = table.Column<double>(type: "REAL", nullable: false),
                    ChanceOfRain = table.Column<double>(type: "REAL", nullable: false),
                    ChanceOfSnow = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationForecasts", x => x.ForecastTime);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StationForecasts");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "WeatherChecks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ForecastId",
                table: "WeatherChecks",
                type: "TEXT",
                nullable: true);
        }
    }
}
