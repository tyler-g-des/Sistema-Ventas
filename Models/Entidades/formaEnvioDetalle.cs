using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class formaEnvioDetalle
    {
        public int formaEnvioDetalleID { get; set; }

        public int formaEnvioID { get; set; }

        public int  idArticulo { get; set; }

        public decimal costo { get; set; }

        public float cantidad { get; set; }

        public virtual formaPago FormaPago { get; set; }

        public virtual Articulo Articulo { get; set; }
    }
}
