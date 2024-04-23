using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentail.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarNumber",
                table: "HybridCars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarNumber",
                table: "ElectricMotorcycles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarNumber",
                table: "ElectricCars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarNumber",
                table: "CombustionMotorcycles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarNumber",
                table: "CombustionCars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarNumber",
                table: "HybridCars");

            migrationBuilder.DropColumn(
                name: "CarNumber",
                table: "ElectricMotorcycles");

            migrationBuilder.DropColumn(
                name: "CarNumber",
                table: "ElectricCars");

            migrationBuilder.DropColumn(
                name: "CarNumber",
                table: "CombustionMotorcycles");

            migrationBuilder.DropColumn(
                name: "CarNumber",
                table: "CombustionCars");
        }
    }
}
