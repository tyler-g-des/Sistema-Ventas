using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Ubicacion
    {
        [Key]
        public int idUbicacion { get; set; }

        public String Sector { get; set; }

        public  String Calle { get; set; }

        public int NoCasa { get; set; }

    }
}
