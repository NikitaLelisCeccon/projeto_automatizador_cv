using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_automatizador_cv.Migrations
{
    public partial class M03AdjustTableCurriculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiencia_Curriculos_CurriculoCandidato",
                table: "Experiencia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiencia",
                table: "Experiencia");

            migrationBuilder.DropColumn(
                name: "Atividades",
                table: "Curriculos");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Curriculos");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Curriculos");

            migrationBuilder.DropColumn(
                name: "Inicio",
                table: "Curriculos");

            migrationBuilder.DropColumn(
                name: "Termino",
                table: "Curriculos");

            migrationBuilder.RenameTable(
                name: "Experiencia",
                newName: "Experiencias");

            migrationBuilder.RenameIndex(
                name: "IX_Experiencia_CurriculoCandidato",
                table: "Experiencias",
                newName: "IX_Experiencias_CurriculoCandidato");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiencias",
                table: "Experiencias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiencias_Curriculos_CurriculoCandidato",
                table: "Experiencias",
                column: "CurriculoCandidato",
                principalTable: "Curriculos",
                principalColumn: "Candidato",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiencias_Curriculos_CurriculoCandidato",
                table: "Experiencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiencias",
                table: "Experiencias");

            migrationBuilder.RenameTable(
                name: "Experiencias",
                newName: "Experiencia");

            migrationBuilder.RenameIndex(
                name: "IX_Experiencias_CurriculoCandidato",
                table: "Experiencia",
                newName: "IX_Experiencia_CurriculoCandidato");

            migrationBuilder.AddColumn<string>(
                name: "Atividades",
                table: "Curriculos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Curriculos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Curriculos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inicio",
                table: "Curriculos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Termino",
                table: "Curriculos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiencia",
                table: "Experiencia",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiencia_Curriculos_CurriculoCandidato",
                table: "Experiencia",
                column: "CurriculoCandidato",
                principalTable: "Curriculos",
                principalColumn: "Candidato");
        }
    }
}
