using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class CompraDetalle
    {
        [Key]
        public int compraDetallID { get; set; }

        [Display(Name = "Articulo")]
        [ForeignKey("idArticulo")]
        public int idArticulo { get; set; }
        public Articulo Articulo { get; set; }

        [Required(ErrorMessage = "No disponemos de esta cantidad")]
        [Display(Name = "Cantidad")]
        public decimal cantidad { get; set; }

        [Display(Name = "Precio")]
        public decimal precio { get; set; }

        [Display(Name = "Precio Total")]
        public decimal precioTotal { get; set; }

        [Display(Name = "Compra")]
        [ForeignKey("compraID")]
        public int compraID { get; set; }
        public Compra Compra { get; set; }
    }
}
