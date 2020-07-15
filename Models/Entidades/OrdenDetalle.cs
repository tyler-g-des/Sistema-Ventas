using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class OrdenDetalle
    {
        [Key]
        public int ordenDetallID { get; set; }

        [Display(Name = "Articulo")]
        [ForeignKey("idArticulo")]
        public int idArticulo { get; set; }
        public Articulo Articulo { get; set; }


        [Display(Name = "Cantidad")]
        public decimal cantidad {get; set; }

        [Display(Name  = "Precio")]
        public decimal precio { get; set; }

        [Display(Name = "Precio Total")]
        public decimal precioTotal { get; set; }

        [Display(Name = "Orden")]
        [ForeignKey("ordenID")]
        public int ordenID { get; set; }
        public Orden Orden { get; set; }
    }
}
