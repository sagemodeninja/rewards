using Microsoft.EntityFrameworkCore.Migrations;

namespace RewardsApp.SQLite.Migrations
{
    public partial class Referrer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Taken",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "ReferrerId",
                table: "Customers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ReferrerId",
                table: "Customers",
                column: "ReferrerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Customers_ReferrerId",
                table: "Customers",
                column: "ReferrerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Customers_ReferrerId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ReferrerId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ReferrerId",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "Taken",
                table: "Cards",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
