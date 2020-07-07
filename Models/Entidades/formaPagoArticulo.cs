using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class formaPagoArticulo : Articulo
    {
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Digite la cantidad")]
        [DisplayName("Cantidad")]
        public float ArticlePurchaseOrderQuantity { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [DisplayName("Monto")]
        public decimal Value { get { return ArticleCost * (decimal)ArticlePurchaseOrderQuantity; } }

    }
}
