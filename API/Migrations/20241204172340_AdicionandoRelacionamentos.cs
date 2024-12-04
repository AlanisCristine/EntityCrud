using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AdicionandoRelacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CidadeId",
                table: "Pessoas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_CidadeId",
                table: "Pessoas",
                column: "CidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Cidades_CidadeId",
                table: "Pessoas",
                column: "CidadeId",
                principalTable: "Cidades",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Cidades_CidadeId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_CidadeId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "Pessoas");
        }
    }
}
