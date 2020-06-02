using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class article : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClasificacionSuplidor",
                columns: table => new
                {
                    idClasificacionSuplidor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoDeSuplidor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasificacionSuplidor", x => x.idClasificacionSuplidor);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    idMarca = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.idMarca);
                });

            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    idArticulo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    idMarca = table.Column<int>(nullable: false),
                    idClasificacionSuplidor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.idArticulo);
                    table.ForeignKey(
                        name: "FK_Articulo_ClasificacionSuplidor_idClasificacionSuplidor",
                        column: x => x.idClasificacionSuplidor,
                        principalTable: "ClasificacionSuplidor",
                        principalColumn: "idClasificacionSuplidor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articulo_Marca_idMarca",
                        column: x => x.idMarca,
                        principalTable: "Marca",
                        principalColumn: "idMarca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_idClasificacionSuplidor",
                table: "Articulo",
                column: "idClasificacionSuplidor");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_idMarca",
                table: "Articulo",
                column: "idMarca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropTable(
                name: "ClasificacionSuplidor");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
