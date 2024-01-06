using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gutenberg.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GutenbergID",
                table: "BookshelfItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GutenbergID",
                table: "BookshelfItems");
        }
    }
}
