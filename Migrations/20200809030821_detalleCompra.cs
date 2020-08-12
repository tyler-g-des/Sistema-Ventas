using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class detalleCompra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "compraDetalles",
                columns: table => new
                {
                    compraDetallID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idArticulo = table.Column<int>(nullable: false),
                    cantidad = table.Column<decimal>(nullable: false),
                    precio = table.Column<decimal>(nullable: false),
                    precioTotal = table.Column<decimal>(nullable: false),
                    compraID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compraDetalles", x => x.compraDetallID);
                    table.ForeignKey(
                        name: "FK_compraDetalles_Compra_compraID",
                        column: x => x.compraID,
                        principalTable: "Compra",
                        principalColumn: "compraID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_compraDetalles_Articulo_idArticulo",
                        column: x => x.idArticulo,
                        principalTable: "Articulo",
                        principalColumn: "idArticulo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_compraDetalles_compraID",
                table: "compraDetalles",
                column: "compraID");

            migrationBuilder.CreateIndex(
                name: "IX_compraDetalles_idArticulo",
                table: "compraDetalles",
                column: "idArticulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "compraDetalles");
        }
    }
}
