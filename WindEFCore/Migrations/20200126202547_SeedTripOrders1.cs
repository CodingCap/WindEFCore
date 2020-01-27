using Microsoft.EntityFrameworkCore.Migrations;

namespace WindEFCore.Migrations
{
    public partial class SeedTripOrders1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "CarrierId", "Currency", "Price", "TripReference" },
                values: new object[] { -1, -1, (byte)1, 20m, "tesdt" });

            migrationBuilder.InsertData(
                table: "TripOrders",
                columns: new[] { "TripId", "OrderId" },
                values: new object[] { -1, -1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TripOrders",
                keyColumns: new[] { "TripId", "OrderId" },
                keyValues: new object[] { -1, -1 });

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: -1);
        }
    }
}
