using PrimerParcial.Models.Clasificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial.Models.Entidades
{
    public class Articulo
    {
        [Key]
        public int idArticulo { get; set; }

        public String Nombre { get; set; }

        [DisplayName("Costo")]
        [Required(ErrorMessage = "Completar el campo {0}")]
        public int Precio { get; set; }

        public int Cantidad { get; set; }


        //-------------Marca------------
        [Display(Name = "Marca")]
        [ForeignKey("Marca")]
        public int idMarca { get; set; }
        public Marca Marca { get; set; }

        //-------------------------Clasificacion Articulo -----------
        [Display(Name = "ClasificacionArticulos")]
        [ForeignKey("idClasificacionArticulo")]
        public int idClasificacionArticulos { get; set; }
        public ClasificacionArticulos ClasificacionArticulos { get; set; }



    }
}
