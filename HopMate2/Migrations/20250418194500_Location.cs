using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HopMate2.Migrations
{
    /// <inheritdoc />
    public partial class Location : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripLocation_Locations_LocationIdLocation",
                table: "TripLocation");

            migrationBuilder.DropIndex(
                name: "IX_TripLocation_LocationIdLocation",
                table: "TripLocation");

            migrationBuilder.DropColumn(
                name: "LocationIdLocation",
                table: "TripLocation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LocationIdLocation",
                table: "TripLocation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TripLocation_LocationIdLocation",
                table: "TripLocation",
                column: "LocationIdLocation");

            migrationBuilder.AddForeignKey(
                name: "FK_TripLocation_Locations_LocationIdLocation",
                table: "TripLocation",
                column: "LocationIdLocation",
                principalTable: "Locations",
                principalColumn: "IdLocation");
        }
    }
}
