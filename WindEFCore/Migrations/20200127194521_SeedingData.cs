using Microsoft.EntityFrameworkCore.Migrations;

namespace WindEFCore.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "TripOrders",
                keyColumns: new[] { "TripId", "OrderId" },
                keyValues: new object[] { -1, -1 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[] { 1, "WindSoft" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[] { 2, "Perly Gates" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[] { 3, "Valhala INC." });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Street", "StreetNumber" },
                values: new object[,]
                {
                    { 1, "Theodor Pallady", "47" },
                    { 2, "Highway to hell", "666" },
                    { 3, "Ragnarok", "13" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "ClientId", "Currency", "Price", "ReferenceNumber" },
                values: new object[,]
                {
                    { 1, 1, (byte)2, 10m, "test1" },
                    { 2, 1, (byte)1, 20m, "test2" },
                    { 3, 1, (byte)1, 30m, "test3" },
                    { 4, 1, (byte)3, 40m, "test4" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "CarrierId", "Currency", "Price", "TripReference" },
                values: new object[,]
                {
                    { 1, 1, (byte)1, 10m, "tesd1" },
                    { 2, 1, (byte)1, 10m, "tesd1" },
                    { 3, 1, (byte)1, 10m, "tesd1" },
                    { 4, 1, (byte)1, 10m, "tesd1" },
                    { 5, 1, (byte)1, 10m, "tesd1" }
                });

            migrationBuilder.InsertData(
                table: "TripOrders",
                columns: new[] { "TripId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 3 },
                    { 5, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TripOrders",
                keyColumns: new[] { "TripId", "OrderId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TripOrders",
                keyColumns: new[] { "TripId", "OrderId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "TripOrders",
                keyColumns: new[] { "TripId", "OrderId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TripOrders",
                keyColumns: new[] { "TripId", "OrderId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TripOrders",
                keyColumns: new[] { "TripId", "OrderId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "TripOrders",
                keyColumns: new[] { "TripId", "OrderId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[] { -1, "WindSoft" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Street", "StreetNumber" },
                values: new object[] { -1, "Theodor Pallady", "47" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "ClientId", "Currency", "Price", "ReferenceNumber" },
                values: new object[] { -1, -1, (byte)2, 20m, "test11" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "CarrierId", "Currency", "Price", "TripReference" },
                values: new object[] { -1, -1, (byte)1, 20m, "tesdt" });

            migrationBuilder.InsertData(
                table: "TripOrders",
                columns: new[] { "TripId", "OrderId" },
                values: new object[] { -1, -1 });
        }
    }
}
