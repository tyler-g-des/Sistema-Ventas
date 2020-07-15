using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class ordenordenDetalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ordenDetalles",
                columns: table => new
                {
                    ordenDetallID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idArticulo = table.Column<int>(nullable: false),
                    cantidad = table.Column<decimal>(nullable: false),
                    precio = table.Column<decimal>(nullable: false),
                    precioTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordenDetalles", x => x.ordenDetallID);
                    table.ForeignKey(
                        name: "FK_ordenDetalles_Articulo_idArticulo",
                        column: x => x.idArticulo,
                        principalTable: "Articulo",
                        principalColumn: "idArticulo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ordens",
                columns: table => new
                {
                    ordenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idCliente = table.Column<int>(nullable: false),
                    formaPagoID = table.Column<int>(nullable: false),
                    formaEnvioID = table.Column<int>(nullable: false),
                    fechaOrden = table.Column<DateTime>(nullable: false),
                    observacion = table.Column<string>(nullable: true),
                    subtotal = table.Column<decimal>(nullable: false),
                    impuesto = table.Column<decimal>(nullable: false),
                    total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordens", x => x.ordenID);
                    table.ForeignKey(
                        name: "FK_Ordens_formaEnvios_formaEnvioID",
                        column: x => x.formaEnvioID,
                        principalTable: "formaEnvios",
                        principalColumn: "formaEnvioID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ordens_formaPagos_formaPagoID",
                        column: x => x.formaPagoID,
                        principalTable: "formaPagos",
                        principalColumn: "formaPagoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ordens_Clientes_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Clientes",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ordenDetalles_idArticulo",
                table: "ordenDetalles",
                column: "idArticulo");

            migrationBuilder.CreateIndex(
                name: "IX_Ordens_formaEnvioID",
                table: "Ordens",
                column: "formaEnvioID");

            migrationBuilder.CreateIndex(
                name: "IX_Ordens_formaPagoID",
                table: "Ordens",
                column: "formaPagoID");

            migrationBuilder.CreateIndex(
                name: "IX_Ordens_idCliente",
                table: "Ordens",
                column: "idCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ordenDetalles");

            migrationBuilder.DropTable(
                name: "Ordens");
        }
    }
}
