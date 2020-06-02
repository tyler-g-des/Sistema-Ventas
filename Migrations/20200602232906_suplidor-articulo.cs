using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class suplidorarticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_ClasificacionSuplidor_idClasificacionSuplidor",
                table: "Articulo");

            migrationBuilder.RenameColumn(
                name: "idClasificacionSuplidor",
                table: "Articulo",
                newName: "idSuplidor");

            migrationBuilder.RenameIndex(
                name: "IX_Articulo_idClasificacionSuplidor",
                table: "Articulo",
                newName: "IX_Articulo_idSuplidor");

            migrationBuilder.AddColumn<int>(
                name: "idClasificacionArticulos",
                table: "Articulo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClasificacionArticulos",
                columns: table => new
                {
                    idClasificacionArticulos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoDeArticulos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasificacionArticulos", x => x.idClasificacionArticulos);
                });

            migrationBuilder.CreateTable(
                name: "Suplidor",
                columns: table => new
                {
                    idSuplidor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    idCiudad = table.Column<int>(nullable: false),
                    idClasificacionSuplidor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplidor", x => x.idSuplidor);
                    table.ForeignKey(
                        name: "FK_Suplidor_Ciudades_idCiudad",
                        column: x => x.idCiudad,
                        principalTable: "Ciudades",
                        principalColumn: "idCiudad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suplidor_ClasificacionSuplidor_idClasificacionSuplidor",
                        column: x => x.idClasificacionSuplidor,
                        principalTable: "ClasificacionSuplidor",
                        principalColumn: "idClasificacionSuplidor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_idClasificacionArticulos",
                table: "Articulo",
                column: "idClasificacionArticulos");

            migrationBuilder.CreateIndex(
                name: "IX_Suplidor_idCiudad",
                table: "Suplidor",
                column: "idCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Suplidor_idClasificacionSuplidor",
                table: "Suplidor",
                column: "idClasificacionSuplidor");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_ClasificacionArticulos_idClasificacionArticulos",
                table: "Articulo",
                column: "idClasificacionArticulos",
                principalTable: "ClasificacionArticulos",
                principalColumn: "idClasificacionArticulos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Suplidor_idSuplidor",
                table: "Articulo",
                column: "idSuplidor",
                principalTable: "Suplidor",
                principalColumn: "idSuplidor",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_ClasificacionArticulos_idClasificacionArticulos",
                table: "Articulo");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Suplidor_idSuplidor",
                table: "Articulo");

            migrationBuilder.DropTable(
                name: "ClasificacionArticulos");

            migrationBuilder.DropTable(
                name: "Suplidor");

            migrationBuilder.DropIndex(
                name: "IX_Articulo_idClasificacionArticulos",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "idClasificacionArticulos",
                table: "Articulo");

            migrationBuilder.RenameColumn(
                name: "idSuplidor",
                table: "Articulo",
                newName: "idClasificacionSuplidor");

            migrationBuilder.RenameIndex(
                name: "IX_Articulo_idSuplidor",
                table: "Articulo",
                newName: "IX_Articulo_idClasificacionSuplidor");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_ClasificacionSuplidor_idClasificacionSuplidor",
                table: "Articulo",
                column: "idClasificacionSuplidor",
                principalTable: "ClasificacionSuplidor",
                principalColumn: "idClasificacionSuplidor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
