using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeFilmesPF.Migrations
{
    public partial class asdhuads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sinopse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco = table.Column<double>(type: "float", nullable: false),
                    lancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    duracao = table.Column<int>(type: "int", nullable: false),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.id);
                    table.ForeignKey(
                        name: "FK_Locacao_Filme_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filme",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_FilmeId",
                table: "Locacao",
                column: "FilmeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropTable(
                name: "Filme");
        }
    }
}
