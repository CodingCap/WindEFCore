using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WindEFCore.Migrations
{
    public partial class ShadowProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 29, 0, 43, 54, 125, DateTimeKind.Local).AddTicks(7527));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Orders");
        }
    }
}
