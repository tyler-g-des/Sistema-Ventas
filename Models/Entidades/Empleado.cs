using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Empleado
    {
        [Key]
        public int idEmpleado { get; set; }

        [Display(Name = "empleado")]
        public String nombre { get; set; }

        [Display(Name = "Telefono")]
        public String telefono { get; set; }

        [Display(Name = "Correo Electronico")]
        public String email { get; set; }

        [Display(Name = "Direccion")]
        public String Direccion { get; set; }

        //-------------Empresa---------
        [Display(Name = "Empresa")]
        [ForeignKey("Empresa")]
        public int idEmpresa { get; set; }
        public Empresa Empresa { get; set; }

        //-------------Ciudad---------
        [Display(Name = "Ciudad")]
        [ForeignKey("Ciudad")]
        public int idCiudad { get; set; }
        public Ciudad Ciudad { get; set; }

        //-------------Tipo de documento---------
        [Display(Name = "Documento")]
        [ForeignKey("TipoDeDocumento")]
        public int idTipoDocumento { get; set; }
        public TipoDeDocumento Documento { get; set; }
    }
}
