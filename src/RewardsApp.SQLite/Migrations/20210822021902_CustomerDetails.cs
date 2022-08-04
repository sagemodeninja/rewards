using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RewardsApp.SQLite.Migrations
{
    public partial class CustomerDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Customers",
                newName: "LastRedeemed");

            migrationBuilder.RenameColumn(
                name: "FamilyName",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LastRedeemedPoints",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastRedeemedPoints",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "LastRedeemed",
                table: "Customers",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "FamilyName");
        }
    }
}
