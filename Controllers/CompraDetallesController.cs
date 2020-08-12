using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimerParcial.Data;
using PrimerParcial.Models.Entidades;

namespace PrimerParcial.Controllers
{
    public class CompraDetallesController : Controller
    {
        private readonly DataContext _context;

        public CompraDetallesController(DataContext context)
        {
            _context = context;
        }

        // GET: CompraDetalles
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.compraDetalles.Include(c => c.Articulo).Include(c => c.Compra);
            return View(await dataContext.ToListAsync());
        }

        // GET: CompraDetalles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compraDetalle = await _context.compraDetalles
                .Include(c => c.Articulo)
                .Include(c => c.Compra)
                .FirstOrDefaultAsync(m => m.compraDetallID == id);
            if (compraDetalle == null)
            {
                return NotFound();
            }

            return View(compraDetalle);
        }

        // GET: CompraDetalles/Create
        public IActionResult Create()
        {
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "idArticulo");
            ViewData["compraID"] = new SelectList(_context.Compra, "compraID", "compraID");
            return View();
        }

        // POST: CompraDetalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("compraDetallID,idArticulo,cantidad,precio,precioTotal,compraID")] CompraDetalle compraDetalle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compraDetalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "idArticulo", compraDetalle.idArticulo);
            ViewData["compraID"] = new SelectList(_context.Compra, "compraID", "compraID", compraDetalle.compraID);
            return View(compraDetalle);
        }

        // GET: CompraDetalles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compraDetalle = await _context.compraDetalles.FindAsync(id);
            if (compraDetalle == null)
            {
                return NotFound();
            }
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "idArticulo", compraDetalle.idArticulo);
            ViewData["compraID"] = new SelectList(_context.Compra, "compraID", "compraID", compraDetalle.compraID);
            return View(compraDetalle);
        }

        // POST: CompraDetalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("compraDetallID,idArticulo,cantidad,precio,precioTotal,compraID")] CompraDetalle compraDetalle)
        {
            if (id != compraDetalle.compraDetallID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compraDetalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompraDetalleExists(compraDetalle.compraDetallID))
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
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "idArticulo", compraDetalle.idArticulo);
            ViewData["compraID"] = new SelectList(_context.Compra, "compraID", "compraID", compraDetalle.compraID);
            return View(compraDetalle);
        }

        // GET: CompraDetalles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compraDetalle = await _context.compraDetalles
                .Include(c => c.Articulo)
                .Include(c => c.Compra)
                .FirstOrDefaultAsync(m => m.compraDetallID == id);
            if (compraDetalle == null)
            {
                return NotFound();
            }

            return View(compraDetalle);
        }

        // POST: CompraDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compraDetalle = await _context.compraDetalles.FindAsync(id);
            _context.compraDetalles.Remove(compraDetalle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompraDetalleExists(int id)
        {
            return _context.compraDetalles.Any(e => e.compraDetallID == id);
        }
    }
}
