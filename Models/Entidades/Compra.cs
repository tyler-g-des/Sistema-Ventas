using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Compra
    {
        [Key]
        public int compraID { get; set; }

        [Display(Name = "Cliente")]
        [ForeignKey("idCliente")]
        public int idCliente { get; set; }
        public Cliente Cliente { get; set; }

        [Display(Name = "Forma de pago")]
        [ForeignKey("formaPagoID")]
        public int formaPagoID { get; set; }
        public formaPago FormaPago { get; set; }

        [Display(Name = "Forma de envio")]
        [ForeignKey("formaEnvioID")]
        public int formaEnvioID { get; set; }
        public formaEnvio FormaEnvio { get; set; }

        [Display(Name = "Fecha de la orden")]
        [DataType(DataType.Date)]
        public DateTime fechaOrden { get; set; }

        [Display(Name = "Observaciones")]
        [DataType(DataType.MultilineText)]
        public String observacion { get; set; }

        [Display(Name = "Subtotal")]
        public decimal subtotal { get; set; }


        [Display(Name = "Impuestp")]
        public decimal impuesto { get; set; }


        [Display(Name = "total")]
        public decimal total { get; set; }
    }
}
