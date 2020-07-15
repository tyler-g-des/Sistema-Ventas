using PrimerParcial.Models.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.ViewModels
{
    public class OrdenView
    {
        public Orden Orden { get; set; }

        public OrdenDetalle OrdenDetalle { get; set; }

        public formaPago FormaPago { get; set; }

        public formaEnvio FormaEnvio { get; set; }

        public Cliente Cliente { get; set; }

        public List<OrdenDetalle> Articulos { get; set; }


    }
}
