using Microsoft.EntityFrameworkCore.Migrations;

namespace WindEFCore.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FiscalCode",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Addresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FiscalCode",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
