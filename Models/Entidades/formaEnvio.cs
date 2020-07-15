using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class formaEnvio
    {
        [Key]
        public int formaEnvioID { get; set; }

        [Required]
        [Display(Name = "Forma de Envio")]
        public String formaEnvioDescripcion { get; set; }


    }
}
