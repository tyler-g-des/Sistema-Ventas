using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class formaenviopago : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Suplidor_idSuplidor",
                table: "Articulo");

            migrationBuilder.DropIndex(
                name: "IX_Articulo_idSuplidor",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "idSuplidor",
                table: "Articulo");

            migrationBuilder.CreateTable(
                name: "formaEnvios",
                columns: table => new
                {
                    formaEnvioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    formaEnvioDescripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formaEnvios", x => x.formaEnvioID);
                });

            migrationBuilder.CreateTable(
                name: "formaPagos",
                columns: table => new
                {
                    formaPagoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    formaPagoDescripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formaPagos", x => x.formaPagoID);
                });

            migrationBuilder.CreateTable(
                name: "puestoDeTrabajos",
                columns: table => new
                {
                    idPuesto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_puestoDeTrabajos", x => x.idPuesto);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    idUbicacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sector = table.Column<string>(nullable: true),
                    Calle = table.Column<string>(nullable: true),
                    NoCasa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.idUbicacion);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    idVendedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    idTipoDocumento = table.Column<int>(nullable: false),
                    DocumentoidTipoDeDocumento = table.Column<int>(nullable: true),
                    idCiudad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.idVendedor);
                    table.ForeignKey(
                        name: "FK_Vendedores_tipoDeDocumentos_DocumentoidTipoDeDocumento",
                        column: x => x.DocumentoidTipoDeDocumento,
                        principalTable: "tipoDeDocumentos",
                        principalColumn: "idTipoDeDocumento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendedores_Ciudades_idCiudad",
                        column: x => x.idCiudad,
                        principalTable: "Ciudades",
                        principalColumn: "idCiudad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    idEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    CodPostal = table.Column<string>(nullable: true),
                    idUbicacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.idEmpresa);
                    table.ForeignKey(
                        name: "FK_Empresas_Ubicaciones_idUbicacion",
                        column: x => x.idUbicacion,
                        principalTable: "Ubicaciones",
                        principalColumn: "idUbicacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    idEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    idEmpresa = table.Column<int>(nullable: false),
                    idCiudad = table.Column<int>(nullable: false),
                    idTipoDocumento = table.Column<int>(nullable: false),
                    DocumentoidTipoDeDocumento = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.idEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleados_tipoDeDocumentos_DocumentoidTipoDeDocumento",
                        column: x => x.DocumentoidTipoDeDocumento,
                        principalTable: "tipoDeDocumentos",
                        principalColumn: "idTipoDeDocumento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleados_Ciudades_idCiudad",
                        column: x => x.idCiudad,
                        principalTable: "Ciudades",
                        principalColumn: "idCiudad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Empresas_idEmpresa",
                        column: x => x.idEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "idEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DocumentoidTipoDeDocumento",
                table: "Empleados",
                column: "DocumentoidTipoDeDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_idCiudad",
                table: "Empleados",
                column: "idCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_idEmpresa",
                table: "Empleados",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_idUbicacion",
                table: "Empresas",
                column: "idUbicacion");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_DocumentoidTipoDeDocumento",
                table: "Vendedores",
                column: "DocumentoidTipoDeDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_idCiudad",
                table: "Vendedores",
                column: "idCiudad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "formaEnvios");

            migrationBuilder.DropTable(
                name: "formaPagos");

            migrationBuilder.DropTable(
                name: "puestoDeTrabajos");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.AddColumn<int>(
                name: "idSuplidor",
                table: "Articulo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_idSuplidor",
                table: "Articulo",
                column: "idSuplidor");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Suplidor_idSuplidor",
                table: "Articulo",
                column: "idSuplidor",
                principalTable: "Suplidor",
                principalColumn: "idSuplidor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
