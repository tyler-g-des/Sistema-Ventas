using PrimerParcial.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.ViewModels
{
    public class CompraView
    {
        public Compra Compra { get; set; }

        public CompraDetalle CompraDetalle { get; set; }

        public formaPago FormaPago { get; set; }

        public formaEnvio FormaEnvio { get; set; }

        public Cliente Cliente { get; set; }

        public List<CompraDetalle> Articulos { get; set; }
    }
}
