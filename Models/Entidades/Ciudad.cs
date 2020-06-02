using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Ciudad
    {

        [Key]
        public int idCiudad { get; set; }

        [Display(Name = "Ciudad")]
        public String nombre { get; set; }


        [Display(Name = "Descripcion")]
        public String Descripcion { get; set; }


        //-------------Pais---------
        [Display(Name = "Pais")]
        [ForeignKey("TipoDeDocumento")]
        public int idPais { get; set; }
        public Pais Pais { get; set; }
    }
}
