using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Empresa
    {

        [Key]
        public int idEmpresa { get; set; }

        public String nombre { get; set; }

        public String telefono { get; set; }

        public String Direccion { get; set; }

        public String CodPostal { get; set; }

        //----------------Ubicacion------------------
        [Display(Name = "Ubicacion")]
        [ForeignKey("Ubicacion")]
        public int idUbicacion { get; set; }
        public Ubicacion Ubicacion { get; set; }
    }
}
