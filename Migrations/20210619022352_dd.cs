using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeFilmesPF.Migrations
{
    public partial class dd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "FilmePreco",
                table: "Locacao",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmePreco",
                table: "Locacao");
        }
    }
}
