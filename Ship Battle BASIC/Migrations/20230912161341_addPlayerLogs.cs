using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ship_Battle_BASIC.Migrations
{
    public partial class addPlayerLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CloseddDate = table.Column<DateTime>(nullable: false),
                    GameTable = table.Column<string>(maxLength: 101, nullable: true),
                    PlayerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerLog_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerLog_PlayerId",
                table: "PlayerLog",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerLog");
        }
    }
}
