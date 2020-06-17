using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Marca
    {
        [Key]
        public int idMarca { get; set; }

        public String Nombre { get; set; }

        public String Descripcion { get; set; }

    }
}
