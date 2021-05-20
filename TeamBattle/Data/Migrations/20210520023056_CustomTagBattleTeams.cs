using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamBattle.Data.Migrations
{
    public partial class CustomTagBattleTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "BattleTeams",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BattleTeams_ApplicationUserId",
                table: "BattleTeams",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleTeams_AspNetUsers_ApplicationUserId",
                table: "BattleTeams",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleTeams_AspNetUsers_ApplicationUserId",
                table: "BattleTeams");

            migrationBuilder.DropIndex(
                name: "IX_BattleTeams_ApplicationUserId",
                table: "BattleTeams");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "BattleTeams");
        }
    }
}
