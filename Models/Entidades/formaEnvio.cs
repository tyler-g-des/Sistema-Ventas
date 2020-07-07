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

        public int formaPago { get; set; }

        public DateTime formaEnvioDia { get; set; }


        [DataType(DataType.MultilineText)]
        public string Nota { get; set; }

        public Suplidor Suplidor { get; set; }

        public formaPago FormaPago { get; set; }

        public virtual ICollection<formaEnvioDetalle> FormaEnvioDetalles { get; set; }
    }
}
