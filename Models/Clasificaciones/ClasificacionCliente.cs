using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Clasificaciones
{
    public class ClasificacionCliente
    {

        [Key]
        public int idClasificacionCliente { get; set; }

        [Display(Name = "TipoCliente")]
        public String TipoDeCliente { get; set; }
    }
}
