using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clasificacionClientes",
                columns: table => new
                {
                    idClasificacionCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoDeCliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clasificacionClientes", x => x.idClasificacionCliente);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    idPais = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.idPais);
                });

            migrationBuilder.CreateTable(
                name: "tipoDeDocumentos",
                columns: table => new
                {
                    idTipoDeDocumento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Documento = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoDeDocumentos", x => x.idTipoDeDocumento);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    idCiudad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    idPais = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.idCiudad);
                    table.ForeignKey(
                        name: "FK_Ciudades_Paises_idPais",
                        column: x => x.idPais,
                        principalTable: "Paises",
                        principalColumn: "idPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    idTipoDocumento = table.Column<int>(nullable: false),
                    DocumentoidTipoDeDocumento = table.Column<int>(nullable: true),
                    idCiudad = table.Column<int>(nullable: false),
                    idClasificacionCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.idCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_tipoDeDocumentos_DocumentoidTipoDeDocumento",
                        column: x => x.DocumentoidTipoDeDocumento,
                        principalTable: "tipoDeDocumentos",
                        principalColumn: "idTipoDeDocumento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Ciudades_idCiudad",
                        column: x => x.idCiudad,
                        principalTable: "Ciudades",
                        principalColumn: "idCiudad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_clasificacionClientes_idClasificacionCliente",
                        column: x => x.idClasificacionCliente,
                        principalTable: "clasificacionClientes",
                        principalColumn: "idClasificacionCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_idPais",
                table: "Ciudades",
                column: "idPais");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DocumentoidTipoDeDocumento",
                table: "Clientes",
                column: "DocumentoidTipoDeDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_idCiudad",
                table: "Clientes",
                column: "idCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_idClasificacionCliente",
                table: "Clientes",
                column: "idClasificacionCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "tipoDeDocumentos");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "clasificacionClientes");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
