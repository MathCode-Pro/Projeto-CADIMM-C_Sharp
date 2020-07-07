using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Cadimm.Migrations
{
    public partial class EntidadesSecundarias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conjugue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    MembroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conjugue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conjugue_Membro_MembroId",
                        column: x => x.MembroId,
                        principalTable: "Membro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DadosEleitor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<int>(nullable: false),
                    Zona = table.Column<int>(nullable: false),
                    Secao = table.Column<int>(nullable: false),
                    MembroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosEleitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DadosEleitor_Membro_MembroId",
                        column: x => x.MembroId,
                        principalTable: "Membro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Rua = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Setor = table.Column<string>(nullable: true),
                    Cep = table.Column<int>(nullable: false),
                    MembroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Membro_MembroId",
                        column: x => x.MembroId,
                        principalTable: "Membro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filiacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FiliadoEm = table.Column<string>(nullable: true),
                    seraConsagrado = table.Column<bool>(nullable: false),
                    ConsagAtual = table.Column<string>(nullable: true),
                    ConsagPretendida = table.Column<string>(nullable: true),
                    MembroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filiacao_Membro_MembroId",
                        column: x => x.MembroId,
                        principalTable: "Membro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Numero = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MembroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_Telefone_Membro_MembroId",
                        column: x => x.MembroId,
                        principalTable: "Membro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conjugue_MembroId",
                table: "Conjugue",
                column: "MembroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DadosEleitor_MembroId",
                table: "DadosEleitor",
                column: "MembroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_MembroId",
                table: "Endereco",
                column: "MembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Filiacao_MembroId",
                table: "Filiacao",
                column: "MembroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_MembroId",
                table: "Telefone",
                column: "MembroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conjugue");

            migrationBuilder.DropTable(
                name: "DadosEleitor");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Filiacao");

            migrationBuilder.DropTable(
                name: "Telefone");
        }
    }
}
