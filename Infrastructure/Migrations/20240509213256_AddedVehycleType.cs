using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentail.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedVehycleType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "HybridCars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "ElectricMotorcycles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "ElectricCars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "CombustionMotorcycles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "CombustionCars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "HybridCars");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "ElectricMotorcycles");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "ElectricCars");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "CombustionMotorcycles");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "CombustionCars");
        }
    }
}
