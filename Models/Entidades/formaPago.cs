using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class formaPago
    {

        [Key]
        public int formaPagoID { get; set; }

        [Display(Name = "Tipo de pago")]
        public String descripcionFormaPago { get; set; }


        public Boolean Status { get; set; }

        public virtual ICollection<Suplidor> Suplidors { get; set; }

        public virtual ICollection<formaEnvio> FormaEnvios { get; set; }
    }
}
