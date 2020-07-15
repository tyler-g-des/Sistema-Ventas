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
    public class OrdenDetallesController : Controller
    {
        private readonly DataContext _context;

        public OrdenDetallesController(DataContext context)
        {
            _context = context;
        }

        // GET: OrdenDetalles
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.ordenDetalles.Include(o => o.Articulo).Include(o => o.Orden);
            return View(await dataContext.ToListAsync());
        }

        // GET: OrdenDetalles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenDetalle = await _context.ordenDetalles
                .Include(o => o.Articulo)
                .Include(o => o.Orden)
                .FirstOrDefaultAsync(m => m.ordenDetallID == id);
            if (ordenDetalle == null)
            {
                return NotFound();
            }

            return View(ordenDetalle);
        }

        // GET: OrdenDetalles/Create
        public IActionResult Create()
        {
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "Nombre");
            ViewData["ordenID"] = new SelectList(_context.Ordens, "ordenID", "ordenID");
            return View();
        }

        // POST: OrdenDetalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ordenDetallID,idArticulo,cantidad,precio,precioTotal,ordenID")] OrdenDetalle ordenDetalle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordenDetalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "idArticulo", ordenDetalle.idArticulo);
            ViewData["ordenID"] = new SelectList(_context.Ordens, "ordenID", "ordenID", ordenDetalle.ordenID);
            return View(ordenDetalle);
        }

        // GET: OrdenDetalles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenDetalle = await _context.ordenDetalles.FindAsync(id);
            if (ordenDetalle == null)
            {
                return NotFound();
            }
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "Nombre", ordenDetalle.idArticulo);
            ViewData["ordenID"] = new SelectList(_context.Ordens, "ordenID", "ordenID", ordenDetalle.ordenID);
            return View(ordenDetalle);
        }

        // POST: OrdenDetalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ordenDetallID,idArticulo,cantidad,precio,precioTotal,ordenID")] OrdenDetalle ordenDetalle)
        {
            if (id != ordenDetalle.ordenDetallID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordenDetalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenDetalleExists(ordenDetalle.ordenDetallID))
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
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "idArticulo", ordenDetalle.idArticulo);
            ViewData["ordenID"] = new SelectList(_context.Ordens, "ordenID", "ordenID", ordenDetalle.ordenID);
            return View(ordenDetalle);
        }

        // GET: OrdenDetalles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenDetalle = await _context.ordenDetalles
                .Include(o => o.Articulo)
                .Include(o => o.Orden)
                .FirstOrDefaultAsync(m => m.ordenDetallID == id);
            if (ordenDetalle == null)
            {
                return NotFound();
            }

            return View(ordenDetalle);
        }

        // POST: OrdenDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordenDetalle = await _context.ordenDetalles.FindAsync(id);
            _context.ordenDetalles.Remove(ordenDetalle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdenDetalleExists(int id)
        {
            return _context.ordenDetalles.Any(e => e.ordenDetallID == id);
        }
    }
}
