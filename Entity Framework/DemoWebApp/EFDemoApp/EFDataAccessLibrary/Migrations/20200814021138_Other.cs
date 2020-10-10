using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLibrary.Migrations
{
    public partial class Other : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ADNType",
                table: "People",
                maxLength: 5,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADNType",
                table: "People");
        }
    }
}
