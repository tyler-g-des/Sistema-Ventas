using PrimerParcial.Models.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.ViewModels
{
    public class formaEnvioView
    {

        public Suplidor suplidor { get; set; }

        public formaPago formaPago  { get; set; }

        public formaEnvio formaEnvio { get; set; }


        [DataType(DataType.MultilineText)]
        public String Notas { get; set; }

        public formaPagoArticulo formaPagoArticulo { get; set; }

        public List<formaPagoArticulo> formaPagoArticulos { get; set; }
    }
}
