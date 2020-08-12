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
using Rotativa.AspNetCore;

namespace PrimerParcial.Controllers
{
    public class ComprasController : Controller
    {
        private readonly DataContext _context;

        public ComprasController(DataContext context)
        {
            _context = context;
        }

        // GET: Compras
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Compra.Include(c => c.Cliente).Include(c => c.FormaEnvio).Include(c => c.FormaPago);
            return View(await dataContext.ToListAsync());
        }

        // GET: Compras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra
                .Include(c => c.Cliente)
                .Include(c => c.FormaEnvio)
                .Include(c => c.FormaPago)
                .FirstOrDefaultAsync(m => m.compraID == id);
            if (compra == null)
            {
                return NotFound();
            }


            var compraview = new CompraView();
            var OrdenDetalle = new OrdenDetalle();
            var CompraDetalle = new CompraDetalle();

            compraview.Compra = await _context.Compra
                .Include(o => o.Cliente)
                .Include(o => o.FormaEnvio)
                .Include(o => o.FormaPago)
                .FirstOrDefaultAsync(m => m.compraID == id);

            var data = _context.compraDetalles.Include(od => od.Compra).Include(od => od.Articulo).Where(od => od.compraID.Equals(id)).ToList();
            compraview.Articulos = data;


            ViewData["formaPago"] = new SelectList(_context.Compra, "formaPago", "formaPago", CompraDetalle.compraID);
            ViewData["compra"] = new SelectList(_context.Compra, "compraID", "compraID", CompraDetalle.compraID);
            ViewData["Articuloo"] = new SelectList(_context.Articulo, "idArticulo", "Nombre");
            return View(compraview);
        }

        // GET: Compras/Create
        public IActionResult Create()
        {
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idCliente", "nombre");
            ViewData["formaEnvioID"] = new SelectList(_context.formaEnvios, "formaEnvioID", "formaEnvioDescripcion");
            ViewData["formaPagoID"] = new SelectList(_context.formaPagos, "formaPagoID", "formaPagoDescripcion");
            return View();
        }

        // POST: Compras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("compraID,idCliente,formaPagoID,formaEnvioID,fechaOrden,observacion,subtotal,impuesto,total")] Compra compra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idCliente", "idCliente", compra.idCliente);
            ViewData["formaEnvioID"] = new SelectList(_context.formaEnvios, "formaEnvioID", "formaEnvioDescripcion", compra.formaEnvioID);
            ViewData["formaPagoID"] = new SelectList(_context.formaPagos, "formaPagoID", "formaPagoDescripcion", compra.formaPagoID);
            return View(compra);
        }

        // GET: Compras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idCliente", "idCliente", compra.idCliente);
            ViewData["formaEnvioID"] = new SelectList(_context.formaEnvios, "formaEnvioID", "formaEnvioDescripcion", compra.formaEnvioID);
            ViewData["formaPagoID"] = new SelectList(_context.formaPagos, "formaPagoID", "formaPagoDescripcion", compra.formaPagoID);
            return View(compra);
        }

        // POST: Compras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("compraID,idCliente,formaPagoID,formaEnvioID,fechaOrden,observacion,subtotal,impuesto,total")] Compra compra)
        {
            if (id != compra.compraID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompraExists(compra.compraID))
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
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idCliente", "idCliente", compra.idCliente);
            ViewData["formaEnvioID"] = new SelectList(_context.formaEnvios, "formaEnvioID", "formaEnvioDescripcion", compra.formaEnvioID);
            ViewData["formaPagoID"] = new SelectList(_context.formaPagos, "formaPagoID", "formaPagoDescripcion", compra.formaPagoID);
            return View(compra);
        }

        // GET: Compras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra
                .Include(c => c.Cliente)
                .Include(c => c.FormaEnvio)
                .Include(c => c.FormaPago)
                .FirstOrDefaultAsync(m => m.compraID == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]        
        public async Task<IActionResult> borrarDetalleConfirmacion(int idArticulo, int idCompra)
        {
            //Se busca la compra detalle
            var compradetalle = await _context.compraDetalles
             .Include(c => c.Articulo)
             .Include(c => c.Compra)
             .FirstOrDefaultAsync(m => m.idArticulo == idArticulo);
            
            //Se busca la compra 
            var compra = await _context.Compra
            .FirstOrDefaultAsync(t => t.compraID == idCompra);

            //Se busca el articulo el articulo
            var articuloSumaNueva = await _context.Articulo
              .FirstOrDefaultAsync(o => o.idArticulo == idArticulo);

         
                //Se vuelve a incrementar la cantidad
                articuloSumaNueva.Cantidad += decimal.ToInt32(compradetalle.cantidad);

                // Se decrementa todos los precios de la orden
                compradetalle.precioTotal -= articuloSumaNueva.Cantidad * articuloSumaNueva.Precio;
                compra.subtotal -= articuloSumaNueva.Cantidad * articuloSumaNueva.Precio;
                compra.total -= articuloSumaNueva.Cantidad * articuloSumaNueva.Precio;

           
                if (compra.subtotal < 0 || compra.total < 0 || compradetalle.precioTotal < 0)
                {
                    compra.subtotal = 0;
                    compra.total = 0;
                    compradetalle.precioTotal = 0;
                }    

      
            _context.Remove(compradetalle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Compras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compra = await _context.Compra.FindAsync(id);
            _context.Compra.Remove(compra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompraExists(int id)
        {
            return _context.Compra.Any(e => e.compraID == id);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdicionarArticulo([Bind("compraDetallID ,idArticulo,cantidad,precio,precioTotal,compraID")] CompraDetalle compraDetalle)
        {
            if (ModelState.IsValid)
            {

                int id = compraDetalle.compraID;
                int idArticulo = compraDetalle.idArticulo;

                Models.Entidades.Articulo articulo = _context.Articulo.Find(idArticulo);

                decimal precio = articulo.Precio;
                decimal cantidad = compraDetalle.cantidad;

                compraDetalle.precio = precio;
                compraDetalle.precioTotal = cantidad * precio;

                if (compraDetalle.cantidad <= articulo.Cantidad)
                {
                    articulo.Cantidad -= decimal.ToInt32(cantidad);
                    _context.Update(articulo);


                    if (_context.compraDetalles.Any(o => o.compraDetallID == id))
                    {
                        Models.Entidades.CompraDetalle ordenDetalleUpdate = _context.compraDetalles.Where(t => t.idArticulo
                       == idArticulo).FirstOrDefault();
                        Models.Entidades.CompraDetalle ordenDetalleUpdate1 = _context.compraDetalles.Find(id);
            

                        if (ordenDetalleUpdate == null  && ordenDetalleUpdate1.compraID == id)
                        {

                            Models.Entidades.CompraDetalle ordene = _context.compraDetalles
                                                                .Where(s => s.idArticulo == idArticulo)
                                                                .FirstOrDefault();

                            Models.Entidades.CompraDetalle ordene1 = _context.compraDetalles
                                                               .Where(s => s.compraID == id)
                                                               .FirstOrDefault();

                            if (ordene != null && ordene1 != null)
                            {
                                ordene.cantidad += cantidad;
                                _context.Update(ordene);

                            }
                            else
                            {
                                _context.Add(compraDetalle);
                            }

                        }

                        else
                        {
                            if (ordenDetalleUpdate.compraID == id)
                            {
                                ordenDetalleUpdate.cantidad += cantidad;
                                _context.Update(ordenDetalleUpdate);
                            }else
                            {
                                _context.Add(compraDetalle);
                            }
                        }

                    }
                    else
                    {
                        _context.Add(compraDetalle);                        
                    }

                    await _context.SaveChangesAsync();

                    Models.Entidades.Compra compra = _context.Compra.Find(id);
                    compra.subtotal += cantidad * precio;
                    compra.total += cantidad * precio;

                    _context.Update(compra);
                    _context.SaveChanges();
                }

                else
                {
                    TempData["msg"] = "<script>alert('No contamos con esa cantidad');</script>";
                    return RedirectToAction("Details", new { id = id });
                }

                return RedirectToAction("Details", new { id = id });
            }
    

            return View(compraDetalle);
        }

        public async Task<IActionResult> Factura(int? id)
        {

            CompraView dd = new CompraView();

            dd.Compra = await _context.Compra
                .Include(o => o.Cliente)
                .Include(o => o.FormaEnvio)
                .Include(o => o.FormaPago)
                .FirstOrDefaultAsync(m => m.compraID == id);

            var data = _context.compraDetalles
                .Include(od => od.Compra)
                 .Include(od => od.Articulo)
                .Where(od => od.compraID.Equals(id)).ToList();
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
            CompraView dd = new CompraView();

            dd.Compra = await _context.Compra
                .Include(o => o.Cliente)
                .Include(o => o.FormaEnvio)
                .Include(o => o.FormaPago)
                .FirstOrDefaultAsync(m => m.compraID == id);

            var data = _context.compraDetalles
                .Include(od => od.Compra)
                .Include(od => od.Articulo)
                .Where(od => od.compraID.Equals(id)).ToList();
            dd.Articulos = data;

            return View("ValidaFactura", dd);
        }

        public async Task<IActionResult> GuardarImpresion(int? id)
        {

            CompraView dd = new CompraView();

            dd.Compra = await _context.Compra
                .Include(o => o.Cliente)
                .Include(o => o.FormaEnvio)
                .Include(o => o.FormaPago)
                .FirstOrDefaultAsync(m => m.compraID == id);

            var data = _context.compraDetalles
                .Include(od => od.Compra)
                 .Include(od => od.Articulo)
                .Where(od => od.compraID.Equals(id)).ToList();
            dd.Articulos = data;

            
            return new ViewAsPdf("Factura", dd)
            {
                FileName = "reporteFactura.pdf",
                PageSize = Rotativa.AspNetCore.Options.Size.A3,
            };
        }
    }
}
