using Microsoft.EntityFrameworkCore.Migrations;

namespace RewardsApp.SQLite.Migrations
{
    public partial class Points : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Points",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "Customers");
        }
    }
}
