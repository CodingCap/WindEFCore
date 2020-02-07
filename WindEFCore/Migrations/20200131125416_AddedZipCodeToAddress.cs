using Microsoft.EntityFrameworkCore.Migrations;

namespace WindEFCore.Migrations
{
    public partial class AddedZipCodeToAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FiscalCode",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FiscalCode",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Addresses");
        }
    }
}
