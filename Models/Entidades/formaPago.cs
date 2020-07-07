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

        public int formaPagoID { get; set; }

        public int formaPagoDescripcion { get; set; }

        [Display(Name = "Forma Envio")]
        [ForeignKey("formaEnvio")]
        public virtual ICollection<formaEnvio> FormaEnvios { get; set; }

    }
}
