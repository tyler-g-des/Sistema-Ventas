using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Clasificaciones
{
    public class ClasificacionSuplidor
    {

        [Key]
        public int idClasificacionSuplidor { get; set; }

        [Display(Name = "Tipo")]
        public String TipoDeSuplidor { get; set; }

    }
}
