using Microsoft.EntityFrameworkCore.Migrations;

namespace WindEFCore.Migrations
{
    public partial class SeedCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[] { -1, "WindSoft" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Street", "StreetNumber" },
                values: new object[] { -1, "Theodor Pallady", "47" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: -1);
        }
    }
}
