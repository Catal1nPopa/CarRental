using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentail.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FIx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Advanced",
                table: "CarInspections",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Advanced",
                table: "CarInspections");
        }
    }
}
