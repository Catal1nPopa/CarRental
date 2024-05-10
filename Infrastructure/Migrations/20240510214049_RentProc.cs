﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentail.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RentProc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalPrice",
                table: "RentalRegistration",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "RentalRegistration");
        }
    }
}
