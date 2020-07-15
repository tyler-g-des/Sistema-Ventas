using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrimerParcial.Data;
using PrimerParcial.Models.Entidades;
using PrimerParcial.ViewModels;
using System;
using System.Collections.Generic;

namespace PrimerParcial.Controllers
{

    public class formaEnvioViewController : Controller
    {

        private readonly DataContext _context;

             public formaEnvioViewController(DataContext context)
             {
               _context = context;
             }

        public ActionResult formaEnvioView()
        {
            //var FormaEnvioView = new OrdenView();
            //FormaEnvioView.suplidor = new Models.Entidades.Suplidor();
            //FormaEnvioView.formaPago = new Models.Entidades.formaPago();
            //FormaEnvioView.formaEnvio = new Models.Entidades.formaEnvio();
    

            ViewData["formaEnvioSuplidor"] = new SelectList(_context.Suplidor, "idSuplidor", "nombre");
            ViewData["formaEnvioo"] = new SelectList(_context.formaEnvios, "formaEnvioID", "Nota");
            ViewData["formaPago"] = new SelectList(_context.formaPagos, "formaPagoID", "formaPagoDescripcion");
            ViewData["Articuloo"] = new SelectList(_context.Articulo, "idArticulo", "Nombre");


            return View();
        }

 
        //public ActionResult AdicionarArticulo(formaPagoArticulo formaPagoArticulo)
        //{

        //    var formaOrdenVieww = new formaEnvioView();
        //    var articleID = formaPagoArticulo.idArticulo;


        //    var articulo = _context.Articulo.Find(articleID);
        //    formaPagoArticulo = formaOrdenVieww.formaPagoArticulos.Find(a => a.idArticulo == articleID);

        //    if (formaPagoArticulo == null)
        //    {
        //        formaPagoArticulo = new formaPagoArticulo
        //        {
        //            idArticulo = articulo.idArticulo,
        //            Nombre = articulo.Nombre,
        //            Precio = articulo.Precio,
        //            Cantidad = articulo.Cantidad,
        //            ClasificacionArticulos = articulo.ClasificacionArticulos

        //        };
        //    }
        //    else
        //    {
        //        formaPagoArticulo.ArticlePurchaseOrderQuantity += 
        //    }
        //        formaOrdenVieww.formaPagoArticulos.Add(formaPagoArticulo);
        //        return View("formaEnvioView", formaOrdenVieww);

 
        //}

    }
}