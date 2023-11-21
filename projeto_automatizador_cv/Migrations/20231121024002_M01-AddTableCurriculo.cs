using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_automatizador_cv.Migrations
{
    public partial class M01AddTableCurriculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curriculos",
                columns: table => new
                {
                    Candidato = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posicao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resumo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Competencias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atividades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Formacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Certificacoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cursos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idiomas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculos", x => x.Candidato);
                });

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Termino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atividades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurriculoCandidato = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiencia_Curriculos_CurriculoCandidato",
                        column: x => x.CurriculoCandidato,
                        principalTable: "Curriculos",
                        principalColumn: "Candidato");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experiencia_CurriculoCandidato",
                table: "Experiencia",
                column: "CurriculoCandidato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "Curriculos");
        }
    }
}
