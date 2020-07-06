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

        public int formaEnvioID { get; set; }

        public int idArticulo { get; set; }

        public  decimal costo { get; set; }

        public float cantidad { get; set; }

        [NotMapped]
        public string Value { get; set; }

        public virtual formaEnvio FormaEnvio { get; set; }

        public virtual Articulo Articulo { get; set; }
    }
}
