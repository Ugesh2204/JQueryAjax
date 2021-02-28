using Microsoft.EntityFrameworkCore.Migrations;

namespace NotificationDemo.Migrations
{
    public partial class correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notis_Users_UsersUserId",
                table: "Notis");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "Notis",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Notis_UsersUserId",
                table: "Notis",
                newName: "IX_Notis_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notis_Users_UserId",
                table: "Notis",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notis_Users_UserId",
                table: "Notis");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Notis",
                newName: "UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Notis_UserId",
                table: "Notis",
                newName: "IX_Notis_UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notis_Users_UsersUserId",
                table: "Notis",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
