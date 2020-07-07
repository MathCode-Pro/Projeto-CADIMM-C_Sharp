using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Cadimm.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    NomePai = table.Column<string>(nullable: true),
                    NomeMae = table.Column<string>(nullable: true),
                    Cpf = table.Column<int>(nullable: false),
                    Rg = table.Column<int>(nullable: false),
                    EstadoCivil = table.Column<string>(nullable: true),
                    Escolaridade = table.Column<string>(nullable: true),
                    Filiado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Membro");
        }
    }
}
