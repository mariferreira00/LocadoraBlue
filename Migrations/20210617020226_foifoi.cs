using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeFilmesPF.Migrations
{
    public partial class foifoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Locacao",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_userId",
                table: "Locacao",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_AspNetUsers_userId",
                table: "Locacao",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_AspNetUsers_userId",
                table: "Locacao");

            migrationBuilder.DropIndex(
                name: "IX_Locacao_userId",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Locacao");
        }
    }
}
