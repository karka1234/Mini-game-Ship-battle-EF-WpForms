using Microsoft.EntityFrameworkCore.Migrations;

namespace Ship_Battle_BASIC.Migrations
{
    public partial class playerTableAddCurrentHits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentHits",
                table: "Player",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentHits",
                table: "Player");
        }
    }
}
