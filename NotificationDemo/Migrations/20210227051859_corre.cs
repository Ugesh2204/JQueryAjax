using Microsoft.EntityFrameworkCore.Migrations;

namespace NotificationDemo.Migrations
{
    public partial class corre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notis_Users_UserId",
                table: "Notis");

            migrationBuilder.DropIndex(
                name: "IX_Notis_UserId",
                table: "Notis");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Notis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Notis",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notis_UserId",
                table: "Notis",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notis_Users_UserId",
                table: "Notis",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
