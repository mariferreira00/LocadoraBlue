using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraDeFilmesPF.Migrations
{
    public partial class pagto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataFinal",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "dataInicial",
                table: "Locacao");

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

            migrationBuilder.AddColumn<int>(
                name: "valorLocacao",
                table: "Locacao",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "diasLocacao",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "precoFinal",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "valorLocacao",
                table: "Locacao");

            migrationBuilder.AddColumn<DateTime>(
                name: "dataFinal",
                table: "Locacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dataInicial",
                table: "Locacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
