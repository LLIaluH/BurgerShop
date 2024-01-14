using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerShop.Migrations
{
    public partial class UpdateNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageSrc",
                table: "BurgerNames",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageSrc",
                table: "BurgerNames");
        }
    }
}
