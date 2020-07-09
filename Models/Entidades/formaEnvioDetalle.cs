using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class formaEnvioDetalle
    {
        [Key]
        public int formaEnvioDetalleID { get; set; }

        [Display(Name = "Forma de Envio")]
        [ForeignKey("formaEnvio")]
        public int formaEnvioID { get; set; }

        [Display(Name = "Articulo")]
        [ForeignKey("Articulo")]
        public int  idArticulo { get; set; }

        public decimal costo { get; set; }

        public float cantidad { get; set; }

        public virtual formaPago FormaPago { get; set; }

        public virtual Articulo Articulo { get; set; }
    }
}
