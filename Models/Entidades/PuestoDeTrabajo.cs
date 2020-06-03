using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class PuestoDeTrabajo
    {
        [Key]
        public int idPuesto { get; set; }

        public String nombre { get; set; }

        public String descripcion { get; set; }
    }
}
