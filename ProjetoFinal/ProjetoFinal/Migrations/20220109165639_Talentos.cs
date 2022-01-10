using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinal.Migrations
{
    public partial class Talentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Talento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagemNome = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Localidade = table.Column<string>(nullable: true),
                    Sobre = table.Column<string>(nullable: true),
                    Profissao = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Formacao = table.Column<string>(nullable: true),
                    Local1 = table.Column<string>(nullable: true),
                    Funcao1 = table.Column<string>(nullable: true),
                    Atividade1 = table.Column<string>(nullable: true),
                    Local2 = table.Column<string>(nullable: true),
                    Funcao2 = table.Column<string>(nullable: true),
                    Atividade2 = table.Column<string>(nullable: true),
                    Instituicao1 = table.Column<string>(nullable: true),
                    CargaHoraria1 = table.Column<string>(nullable: true),
                    Instituicao2 = table.Column<string>(nullable: true),
                    CargaHoraria2 = table.Column<string>(nullable: true),
                    Aprendeu1 = table.Column<string>(nullable: true),
                    Aprendeu2 = table.Column<string>(nullable: true),
                    Habilidades = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Nivel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Talento");
        }
    }
}
