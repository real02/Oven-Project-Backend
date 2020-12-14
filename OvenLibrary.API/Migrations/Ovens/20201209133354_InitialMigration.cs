using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OvenLibrary.API.Migrations.Ovens
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ovens",
                columns: table => new
                {
                    OvenId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationLatitude = table.Column<double>(type: "float", nullable: false),
                    LocationLongitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ovens", x => x.OvenId);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    MeasurementId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OvenId = table.Column<long>(type: "bigint", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperature = table.Column<double>(type: "float", nullable: false),
                    TemperatureInFahrenheit = table.Column<double>(type: "float", nullable: false),
                    PowerConsumption = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.MeasurementId);
                    table.ForeignKey(
                        name: "FK_Measurements_Ovens_OvenId",
                        column: x => x.OvenId,
                        principalTable: "Ovens",
                        principalColumn: "OvenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ovens",
                columns: new[] { "OvenId", "Address", "LocationLatitude", "LocationLongitude" },
                values: new object[] { 1L, "Krapinska 15", 45.804232267064577, 15.948932298011403 });

            migrationBuilder.InsertData(
                table: "Ovens",
                columns: new[] { "OvenId", "Address", "LocationLatitude", "LocationLongitude" },
                values: new object[] { 2L, "Rooseveltov trg 5", 45.808512770246949, 15.966035138678405 });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "MeasurementId", "DateTime", "OvenId", "PowerConsumption", "Temperature", "TemperatureInFahrenheit" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 2.29, 28.0, 0.0 },
                    { 16L, new DateTime(2020, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 2L, 3.3999999999999999, 18.0, 0.0 },
                    { 15L, new DateTime(2020, 8, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 2L, 3.3999999999999999, 19.0, 0.0 },
                    { 14L, new DateTime(2020, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 2L, 3.3999999999999999, 20.0, 0.0 },
                    { 13L, new DateTime(2020, 8, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 2L, 3.3999999999999999, 24.0, 0.0 },
                    { 12L, new DateTime(2020, 8, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), 2L, 3.3999999999999999, 23.0, 0.0 },
                    { 11L, new DateTime(2020, 8, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), 2L, 2.3300000000000001, 22.0, 0.0 },
                    { 10L, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 2.29, 21.0, 0.0 },
                    { 9L, new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 3.3999999999999999, 20.0, 0.0 },
                    { 8L, new DateTime(2020, 8, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 1L, 3.0, 22.0, 0.0 },
                    { 7L, new DateTime(2020, 8, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1L, 2.3999999999999999, 19.0, 0.0 },
                    { 6L, new DateTime(2020, 8, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 1L, 3.2000000000000002, 23.0, 0.0 },
                    { 5L, new DateTime(2020, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1L, 3.1000000000000001, 221.0, 0.0 },
                    { 4L, new DateTime(2020, 8, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 1L, 3.3999999999999999, 26.0, 0.0 },
                    { 3L, new DateTime(2020, 8, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), 1L, 3.3999999999999999, 24.0, 0.0 },
                    { 2L, new DateTime(2020, 8, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), 1L, 2.3300000000000001, 22.0, 0.0 },
                    { 17L, new DateTime(2020, 8, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 2L, 3.3999999999999999, 20.0, 0.0 },
                    { 18L, new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 3.3999999999999999, 23.0, 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_OvenId",
                table: "Measurements",
                column: "OvenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "Ovens");
        }
    }
}
