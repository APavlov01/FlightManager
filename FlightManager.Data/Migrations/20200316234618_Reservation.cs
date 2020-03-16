using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightManager.Data.Migrations
{
    public partial class Reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaneUniqueId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TicketCount",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TicketType",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Reservations");

            migrationBuilder.AddColumn<string>(
                name: "PlaneUniqueId",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketCount",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TicketType",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
