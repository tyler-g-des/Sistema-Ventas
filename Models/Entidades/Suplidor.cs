using PrimerParcial.Models.Clasificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Suplidor
    {
        [Key]
        public int idSuplidor { get; set; }

        public String nombre { get; set; }

        public String telefono { get; set; }

        public String email { get; set; }


        //----------------Ciudad------------------
        [Display(Name = "Ciudad")]
        [ForeignKey("Ciudad")]
        public int idCiudad { get; set; }
        public Ciudad Ciudad { get; set; }


        //----------------Clasificacion Suplidor------------------
        [Display(Name = "ClasificacionSuplidor")]
        [ForeignKey("ClasificacionSuplidor")]
        public int idClasificacionSuplidor { get; set; }
        public ClasificacionSuplidor clasificacionSuplidor { get; set; }

 

    }
}
