using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class formaEnvio
    {
        [Key]
        public int formaEnvioID { get; set; }

        public int idSuplidor { get; set; }

        public int formaPagoID { get; set; }

        public DateTime formaEnvioOrderDate { get; set; }

        public formaPagoStatus formaPagoStatus { get; set; }

        public  string notas { get; set; }

        public virtual Suplidor Suplidor { get; set; }

        public virtual formaPago FormaPago { get; set; }

        public virtual ICollection<formaEnvioDetalle> FormaEnvioDetalles { get; set; }
    }
}
