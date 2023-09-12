using Microsoft.EntityFrameworkCore.Migrations;

namespace Ship_Battle_BASIC.Migrations
{
    public partial class addedLogicToPlayerClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MachInProgress",
                table: "Player",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalMachesPlayed",
                table: "Player",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachInProgress",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "TotalMachesPlayed",
                table: "Player");
        }
    }
}
