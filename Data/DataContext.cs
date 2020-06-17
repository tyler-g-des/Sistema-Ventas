using Microsoft.EntityFrameworkCore;
using PrimerParcial.Models.Clasificaciones;
using PrimerParcial.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Data
{
    public class DataContext : DbContext 
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<TipoDeDocumento> tipoDeDocumentos { get; set; }
        public DbSet<ClasificacionCliente> clasificacionClientes { get; set; }
        public DbSet<PrimerParcial.Models.Entidades.Marca> Marca { get; set; }
        public DbSet<PrimerParcial.Models.Entidades.Articulo> Articulo { get; set; }
        public DbSet<PrimerParcial.Models.Entidades.Suplidor> Suplidor { get; set; }
        public DbSet<PrimerParcial.Models.Clasificaciones.ClasificacionSuplidor> ClasificacionSuplidor { get; set; }
        public DbSet<PrimerParcial.Models.Clasificaciones.ClasificacionArticulos> ClasificacionArticulos { get; set; }

        public DbSet<PuestoDeTrabajo> puestoDeTrabajos { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

 
    }
}
