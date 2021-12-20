using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaDeViagens.Migrations
{
    public partial class dbagencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    num_contato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_contato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nome_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.num_contato);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contato");
        }
    }
}
