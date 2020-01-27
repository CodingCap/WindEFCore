using Microsoft.EntityFrameworkCore.Migrations;

namespace WindEFCore.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 2,
                column: "Price",
                value: 20m);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 3,
                column: "Price",
                value: 30m);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 4,
                column: "Price",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 5,
                column: "Price",
                value: 50m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 2,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 3,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 4,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 5,
                column: "Price",
                value: 10m);
        }
    }
}
