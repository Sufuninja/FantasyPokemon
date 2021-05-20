using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamBattle.Data.Migrations
{
    public partial class UserOwnsManyBattleTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleTeams_AspNetUsers_ApplicationUserId",
                table: "BattleTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleTeams",
                table: "BattleTeams");

            migrationBuilder.DropIndex(
                name: "IX_BattleTeams_ApplicationUserId",
                table: "BattleTeams");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BattleTeams",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "BattleTeams",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleTeams_AspNetUsers_ApplicationUserId",
                table: "BattleTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattleTeams",
                table: "BattleTeams");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BattleTeams",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "BattleTeams",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattleTeams",
                table: "BattleTeams",
                column: "Id");

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
    }
}
