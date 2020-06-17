using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Vendedor
    {
        [Key]
        public int idVendedor { get; set; }

        [Display(Name = "Vendedor")]
        public String nombre { get; set; }

        [Display(Name = "Telefono")]
        public String telefono { get; set; }

        [Display(Name = "Correo Electronico")]
        public String email { get; set; }

        [Display(Name = "Direccion")]
        public String Direccion { get; set; }

        //-------------Posibles relaciones-------
        //-------------Tipo de documento---------

        [Display(Name = "Documento")]
        [ForeignKey("TipoDeDocumento")]
        public int idTipoDocumento { get; set; }
        public TipoDeDocumento Documento { get; set; }


        //-------------Ciudad---------
        [Display(Name = "Ciudad")]
        [ForeignKey("Ciudad")]
        public int idCiudad { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
