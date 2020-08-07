using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLibrary.Migrations
{
    public partial class ReduceAddressInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Addresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
