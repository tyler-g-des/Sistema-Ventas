using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class compra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    compraID = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Compra", x => x.compraID);
                    table.ForeignKey(
                        name: "FK_Compra_formaEnvios_formaEnvioID",
                        column: x => x.formaEnvioID,
                        principalTable: "formaEnvios",
                        principalColumn: "formaEnvioID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compra_formaPagos_formaPagoID",
                        column: x => x.formaPagoID,
                        principalTable: "formaPagos",
                        principalColumn: "formaPagoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compra_Clientes_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Clientes",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_formaEnvioID",
                table: "Compra",
                column: "formaEnvioID");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_formaPagoID",
                table: "Compra",
                column: "formaPagoID");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_idCliente",
                table: "Compra",
                column: "idCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra");
        }
    }
}
