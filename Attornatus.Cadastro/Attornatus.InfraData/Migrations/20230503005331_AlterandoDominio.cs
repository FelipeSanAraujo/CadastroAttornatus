using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attornatus.InfraData.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoDominio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoPrincipal",
                table: "Endereco");

            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoPrincipal",
                table: "Pessoa",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoPrincipal",
                table: "Pessoa");

            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoPrincipal",
                table: "Endereco",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
