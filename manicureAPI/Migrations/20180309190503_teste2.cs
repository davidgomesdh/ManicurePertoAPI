using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace manicureAPI.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Endereco_EnderecoId",
                table: "Usuario");

            migrationBuilder.AlterColumn<Guid>(
                name: "EnderecoId",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdFirebase",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Endereco_EnderecoId",
                table: "Usuario",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Endereco_EnderecoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdFirebase",
                table: "Usuario");

            migrationBuilder.AlterColumn<Guid>(
                name: "EnderecoId",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Endereco_EnderecoId",
                table: "Usuario",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
