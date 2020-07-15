using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class ORDENID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ordenID",
                table: "ordenDetalles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ordenDetalles_ordenID",
                table: "ordenDetalles",
                column: "ordenID");

            migrationBuilder.AddForeignKey(
                name: "FK_ordenDetalles_Ordens_ordenID",
                table: "ordenDetalles",
                column: "ordenID",
                principalTable: "Ordens",
                principalColumn: "ordenID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ordenDetalles_Ordens_ordenID",
                table: "ordenDetalles");

            migrationBuilder.DropIndex(
                name: "IX_ordenDetalles_ordenID",
                table: "ordenDetalles");

            migrationBuilder.DropColumn(
                name: "ordenID",
                table: "ordenDetalles");
        }
    }
}
