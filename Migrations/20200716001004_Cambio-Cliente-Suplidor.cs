using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class CambioClienteSuplidor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordens_Clientes_idCliente",
                table: "Ordens");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Ordens",
                newName: "idSuplidor");

            migrationBuilder.RenameIndex(
                name: "IX_Ordens_idCliente",
                table: "Ordens",
                newName: "IX_Ordens_idSuplidor");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordens_Suplidor_idSuplidor",
                table: "Ordens",
                column: "idSuplidor",
                principalTable: "Suplidor",
                principalColumn: "idSuplidor",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordens_Suplidor_idSuplidor",
                table: "Ordens");

            migrationBuilder.RenameColumn(
                name: "idSuplidor",
                table: "Ordens",
                newName: "idCliente");

            migrationBuilder.RenameIndex(
                name: "IX_Ordens_idSuplidor",
                table: "Ordens",
                newName: "IX_Ordens_idCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordens_Clientes_idCliente",
                table: "Ordens",
                column: "idCliente",
                principalTable: "Clientes",
                principalColumn: "idCliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
