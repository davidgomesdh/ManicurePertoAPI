using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace manicureAPI.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataAlterou = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCadastrou = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<int>(type: "int", nullable: false),
                    UsuarioAlterou = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioCadastrou = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataAlterou = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCadastrou = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: true),
                    Skype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioAlterou = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioCadastrou = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Whatsapp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EnderecoId",
                table: "Usuario",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
