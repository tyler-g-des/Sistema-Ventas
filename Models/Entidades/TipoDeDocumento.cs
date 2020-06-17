using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class TipoDeDocumento
    {
        [Key]
        public int idTipoDeDocumento {get; set; } 

        public String Documento { get; set; }

        public String Numero { get; set; }
    }
}