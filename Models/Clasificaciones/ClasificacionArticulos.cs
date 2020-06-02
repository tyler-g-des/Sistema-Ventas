using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Clasificaciones
{
    public class ClasificacionArticulos
    {
        [Key]
        public int idClasificacionArticulos { get; set; }

        [Display(Name = "Tipo")]
        public String TipoDeArticulos { get; set; }
    }
}
