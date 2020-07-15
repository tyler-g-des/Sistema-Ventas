using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class formaPago
    {
        [Key]
        public int formaPagoID { get; set; }

        [Required]
        [Display(Name = "Forma de Pago")]
        public String formaPagoDescripcion { get; set; }


    }
}
