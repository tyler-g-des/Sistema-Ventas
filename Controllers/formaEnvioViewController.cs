using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Models.Entidades;
using PrimerParcial.ViewModels;

namespace PrimerParcial.Controllers
{
    public class formaEnvioViewController : Controller
    {
        public ActionResult formaEnvioView()
        {
            var FormaEnvioView = new formaEnvioView();
            FormaEnvioView.suplidor = new Models.Entidades.Suplidor();

            FormaEnvioView.formaPago = new Models.Entidades.formaPago();
            FormaEnvioView.formaEnvio = new Models.Entidades.formaEnvio();
            FormaEnvioView.formaPagoArticulos = new List<formaPagoArticulo>();

           



            return View(FormaEnvioView);
        }
    }
}