using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gerenciamento.Migrations
{
    public partial class criacaoTabelaUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Dt_Nascimento = table.Column<DateTime>(nullable: false),
                    Dt_Criacao = table.Column<DateTime>(nullable: false),
                    Dt_Atualizacao = table.Column<DateTime>(nullable: true),
                    Funcao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
