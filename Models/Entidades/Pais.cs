using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Pais
    {

        [Key]
        public int idPais { get; set; }

        [Display(Name = "Pais")]
        public String nombre { get; set; }


        [Display(Name = "Descripcion")]
        public String Descripcion { get; set; }

    }
}
