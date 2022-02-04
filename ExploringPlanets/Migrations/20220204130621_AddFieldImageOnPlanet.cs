using Microsoft.EntityFrameworkCore.Migrations;

namespace ExploringPlanets.Migrations
{
    public partial class AddFieldImageOnPlanet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Planets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Planets");
        }
    }
}
