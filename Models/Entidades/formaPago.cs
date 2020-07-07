using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class formaPago
    {

        public int formaPagoID { get; set; }

        public int formaPagoDescripcion { get; set; }


        public virtual ICollection<formaEnvio> FormaEnvios { get; set; }

    }
}
