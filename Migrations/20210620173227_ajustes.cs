using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeFilmesPF.Migrations
{
    public partial class ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmePreco",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "diasLocacao",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "precoFinal",
                table: "Locacao");

            migrationBuilder.AddColumn<DateTime>(
                name: "dataDevolucao",
                table: "Locacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "datalocação",
                table: "Locacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataDevolucao",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "datalocação",
                table: "Locacao");

            migrationBuilder.AddColumn<double>(
                name: "FilmePreco",
                table: "Locacao",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "diasLocacao",
                table: "Locacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "precoFinal",
                table: "Locacao",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
