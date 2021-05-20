using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamBattle.Data.Migrations
{
    public partial class BattleTeamsHasOwnerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleTeams_AspNetUsers_ApplicationUserId",
                table: "BattleTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleTeams",
                table: "BattleTeams");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "BattleTeams");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "BattleTeams",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleTeams",
                table: "BattleTeams",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BattleTeams_OwnerId",
                table: "BattleTeams",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleTeams_AspNetUsers_OwnerId",
                table: "BattleTeams",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleTeams_AspNetUsers_OwnerId",
                table: "BattleTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleTeams",
                table: "BattleTeams");

            migrationBuilder.DropIndex(
                name: "IX_BattleTeams_OwnerId",
                table: "BattleTeams");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "BattleTeams");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "BattleTeams",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleTeams",
                table: "BattleTeams",
                columns: new[] { "ApplicationUserId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_BattleTeams_AspNetUsers_ApplicationUserId",
                table: "BattleTeams",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
