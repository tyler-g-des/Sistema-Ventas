using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimerParcial.Data;
using PrimerParcial.Models.Entidades;
using PrimerParcial.ViewModels;
using Rotativa;
using Rotativa.AspNetCore;

namespace PrimerParcial.Controllers
{
    public class OrdensController : Controller
    {
        private readonly DataContext _context;

        public OrdensController(DataContext context)
        {
            _context = context;
        }

        // GET: Ordens
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Ordens.Include(o => o.Suplidor).Include(o => o.FormaEnvio).Include(o => o.FormaPago);
            return View(await dataContext.ToListAsync());
        }

        // GET: Ordens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orden = await _context.Ordens
                .Include(o => o.Suplidor)
                .Include(o => o.FormaEnvio)
                .Include(o => o.FormaPago)
                .FirstOrDefaultAsync(m => m.ordenID == id);

            if (orden == null)
            {
                return NotFound();
            }

            var OrdenView = new OrdenView();
            var OrdenDetalle = new OrdenDetalle();

            OrdenView.Orden = await _context.Ordens
                .Include(o => o.Suplidor)
                .Include(o => o.FormaEnvio)
                .Include(o => o.FormaPago)
                .FirstOrDefaultAsync(m => m.ordenID == id);

            var data = _context.ordenDetalles.Include(od => od.Orden).Include(od => od.Articulo).Where(od => od.ordenID.Equals(id)).ToList();
            OrdenView.Articulos = data;

            ViewData["formaPago"] = new SelectList(_context.Ordens, "formaPago", "formaPago", OrdenDetalle.ordenID);
            ViewData["orden"] = new SelectList(_context.Ordens, "ordenID", "ordenID", OrdenDetalle.ordenID);
            ViewData["Articuloo"] = new SelectList(_context.Articulo, "idArticulo", "Nombre");

            return View(OrdenView);
        }

        // GET: Ordens/Create
        public IActionResult Create()
        {
            ViewData["idSuplidor"] = new SelectList(_context.Suplidor, "idSuplidor", "nombre");
            ViewData["formaEnvioID"] = new SelectList(_context.formaEnvios, "formaEnvioID", "formaEnvioDescripcion");
            ViewData["formaPagoID"] = new SelectList(_context.formaPagos, "formaPagoID", "formaPagoDescripcion");

            return View();
        }

        // POST: Ordens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ordenID,idSuplidor,formaPagoID,formaEnvioID,fechaOrden,observacion,subtotal,impuesto,total")] Orden orden)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orden);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idSuplidor"] = new SelectList(_context.Clientes, "idSuplidor", "idSuplidor", orden.idSuplidor);
            ViewData["formaEnvioID"] = new SelectList(_context.formaEnvios, "formaEnvioID", "formaEnvioDescripcion", orden.formaEnvioID);
            ViewData["formaPagoID"] = new SelectList(_context.formaPagos, "formaPagoID", "formaPagoDescripcion", orden.formaPagoID);
            return View(orden);
        }

        // GET: Ordens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orden = await _context.Ordens.FindAsync(id);
            if (orden == null)
            {
                return NotFound();
            }
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idSuplidor", "nombre", orden.idSuplidor);
            ViewData["formaEnvioID"] = new SelectList(_context.formaEnvios, "formaEnvioID", "formaEnvioDescripcion", orden.formaEnvioID);
            ViewData["formaPagoID"] = new SelectList(_context.formaPagos, "formaPagoID", "formaPagoDescripcion", orden.formaPagoID);
            return View(orden);
        }

        // POST: Ordens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ordenID,idCliente,formaPagoID,formaEnvioID,fechaOrden,observacion,subtotal,impuesto,total")] Orden orden)
        {
            if (id != orden.ordenID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orden);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenExists(orden.ordenID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idSuplidor", "nombre", orden.idSuplidor);
            ViewData["formaEnvioID"] = new SelectList(_context.formaEnvios, "formaEnvioID", "formaEnvioDescripcion", orden.formaEnvioID);
            ViewData["formaPagoID"] = new SelectList(_context.formaPagos, "formaPagoID", "formaPagoDescripcion", orden.formaPagoID);
            return View(orden);
        }

        // GET: Ordens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orden = await _context.Ordens
                .Include(o => o.Suplidor)
                .Include(o => o.FormaEnvio)
                .Include(o => o.FormaPago)
                 .FirstOrDefaultAsync(m => m.ordenID == id);

            if (orden == null)
            {
                return NotFound();
            }

            return View(orden);
        }

        // POST: Ordens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orden = await _context.Ordens.FindAsync(id);
            _context.Ordens.Remove(orden);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdenExists(int id)
        {
            return _context.Ordens.Any(e => e.ordenID == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdicionarArticulo([Bind("ordenDetallID,idArticulo,cantidad,precio,precioTotal,ordenID")] OrdenDetalle ordenDetalle)
        {

            if (ModelState.IsValid)
            {

                int id = ordenDetalle.ordenID;
                int idArticulo = ordenDetalle.idArticulo;

                Models.Entidades.Articulo articulo = _context.Articulo.Find(idArticulo);

                decimal precio = articulo.Precio;
                decimal cantidad = ordenDetalle.cantidad;

                ordenDetalle.precio = precio;
                ordenDetalle.precioTotal = cantidad * precio;

                articulo.Cantidad += decimal.ToInt32(cantidad);
                _context.Update(articulo);

                if (_context.ordenDetalles.Any(o => o.ordenID == id))
                {
                    Models.Entidades.OrdenDetalle ordenDetalleUpdate = _context.ordenDetalles.Where(t => t.idArticulo 
                       == idArticulo).FirstOrDefault();
                    Models.Entidades.OrdenDetalle ordenDetalleUpdate1 = _context.ordenDetalles.Find(id);

                    if (ordenDetalleUpdate == null && ordenDetalleUpdate1.ordenID == id)
                    {
                        Models.Entidades.OrdenDetalle ordene = _context.ordenDetalles
                                                            .Where(s => s.idArticulo == idArticulo)
                                                            .FirstOrDefault();

                        Models.Entidades.OrdenDetalle ordene1 = _context.ordenDetalles
                                                           .Where(s => s.ordenID == id)
                                                           .FirstOrDefault();

                        if (ordene != null && ordene1 != null)
                        {
                            ordene.cantidad += cantidad;
                            _context.Update(ordene);
                        }
                        else
                        {
                            _context.Add(ordenDetalle);
                        }

                    }

                    else
                    {
                        if (ordenDetalleUpdate.ordenID == id)
                        {
                            ordenDetalleUpdate.cantidad += cantidad;
                            _context.Update(ordenDetalleUpdate);
                        }else
                        {
                            _context.Add(ordenDetalle);

                        }
                    }

                }
                else
                {
                    _context.Add(ordenDetalle);
                }

                await _context.SaveChangesAsync();

                Models.Entidades.Orden Orden = _context.Ordens.Find(id);
                Orden.subtotal += cantidad * precio;
                Orden.total += cantidad * precio;

                _context.Update(Orden);
                _context.SaveChanges();

                return RedirectToAction("Details", new { id = id });
            }
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "idArticulo", ordenDetalle.idArticulo);
            ViewData["ordenID"] = new SelectList(_context.Ordens, "ordenID", "ordenID", ordenDetalle.ordenID);


            return View(ordenDetalle);
        }
    

    public async Task<IActionResult> Factura(int? id)
    {

        OrdenView dd = new OrdenView();

        dd.Orden = await _context.Ordens
            .Include(o => o.Suplidor)
            .Include(o => o.FormaEnvio)
            .Include(o => o.FormaPago)
            .FirstOrDefaultAsync(m => m.ordenID == id);

        var data = _context.ordenDetalles
            .Include(od => od.Orden)
             .Include(od => od.Articulo)
            .Where(od => od.ordenID.Equals(id)).ToList();
        dd.Articulos = data;

        ////Tyler 
        //return new ViewAsPdf("Details", dd)
        //{
        //    FileName = "reporte.pdf",
        //    PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
        //    PageSize = Rotativa.AspNetCore.Options.Size.A4,    
        //};

        return View("Factura", dd);


    }
    public async Task<IActionResult> ValidarImprimir(int? id)
    {
        OrdenView dd = new OrdenView();

        dd.Orden = await _context.Ordens
            .Include(o => o.Suplidor)
            .Include(o => o.FormaEnvio)
            .Include(o => o.FormaPago)
            .FirstOrDefaultAsync(m => m.ordenID == id);

        var data = _context.ordenDetalles
            .Include(od => od.Orden)
            .Include(od => od.Articulo)
            .Where(od => od.ordenID.Equals(id)).ToList();
        dd.Articulos = data;

        return View("ValidaFactura", dd);
    }


      public async Task<IActionResult> GuardarImpresion(int? id)
      {

        OrdenView dd = new OrdenView();

        dd.Orden = await _context.Ordens
            .Include(o => o.Suplidor)
            .Include(o => o.FormaEnvio)
            .Include(o => o.FormaPago)
            .FirstOrDefaultAsync(m => m.ordenID == id);

        var data = _context.ordenDetalles
            .Include(od => od.Orden)
             .Include(od => od.Articulo)
            .Where(od => od.ordenID.Equals(id)).ToList();
        dd.Articulos = data;

        ////Tyler 
        return new ViewAsPdf("Factura", dd)
        {
            FileName = "reporteFactura.pdf",
            PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
            PageSize = Rotativa.AspNetCore.Options.Size.A3,

        };
      }
   }
}
