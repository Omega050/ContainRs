using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContainRs.WebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNascimentoToCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Clientes");

            migrationBuilder.AddColumn<DateTime>(
                name: "Nascimento",
                table: "Clientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
