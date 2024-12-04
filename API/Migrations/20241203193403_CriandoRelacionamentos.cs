using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class CriandoRelacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Produtos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PessoaId",
                table: "Produtos",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pessoas_PessoaId",
                table: "Produtos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pessoas_PessoaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_PessoaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Produtos");
        }
    }
}
