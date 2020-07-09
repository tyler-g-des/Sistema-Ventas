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
    public class formaEnvioDetallesController : Controller
    {
        private readonly DataContext _context;

        public formaEnvioDetallesController(DataContext context)
        {
            _context = context;
        }

        // GET: formaEnvioDetalles
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.formaEnvioDetalles.Include(f => f.Articulo);
            return View(await dataContext.ToListAsync());
        }

        // GET: formaEnvioDetalles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaEnvioDetalle = await _context.formaEnvioDetalles
                .Include(f => f.Articulo)
                .FirstOrDefaultAsync(m => m.formaEnvioDetalleID == id);
            if (formaEnvioDetalle == null)
            {
                return NotFound();
            }

            return View(formaEnvioDetalle);
        }

        // GET: formaEnvioDetalles/Create
        public IActionResult Create()
        {
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "Discriminator");
            return View();
        }

        // POST: formaEnvioDetalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("formaEnvioDetalleID,formaEnvioID,idArticulo,costo,cantidad")] formaEnvioDetalle formaEnvioDetalle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaEnvioDetalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "Discriminator", formaEnvioDetalle.idArticulo);
            return View(formaEnvioDetalle);
        }

        // GET: formaEnvioDetalles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaEnvioDetalle = await _context.formaEnvioDetalles.FindAsync(id);
            if (formaEnvioDetalle == null)
            {
                return NotFound();
            }
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "Discriminator", formaEnvioDetalle.idArticulo);
            return View(formaEnvioDetalle);
        }

        // POST: formaEnvioDetalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("formaEnvioDetalleID,formaEnvioID,idArticulo,costo,cantidad")] formaEnvioDetalle formaEnvioDetalle)
        {
            if (id != formaEnvioDetalle.formaEnvioDetalleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaEnvioDetalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!formaEnvioDetalleExists(formaEnvioDetalle.formaEnvioDetalleID))
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
            ViewData["idArticulo"] = new SelectList(_context.Articulo, "idArticulo", "Discriminator", formaEnvioDetalle.idArticulo);
            return View(formaEnvioDetalle);
        }

        // GET: formaEnvioDetalles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaEnvioDetalle = await _context.formaEnvioDetalles
                .Include(f => f.Articulo)
                .FirstOrDefaultAsync(m => m.formaEnvioDetalleID == id);
            if (formaEnvioDetalle == null)
            {
                return NotFound();
            }

            return View(formaEnvioDetalle);
        }

        // POST: formaEnvioDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaEnvioDetalle = await _context.formaEnvioDetalles.FindAsync(id);
            _context.formaEnvioDetalles.Remove(formaEnvioDetalle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool formaEnvioDetalleExists(int id)
        {
            return _context.formaEnvioDetalles.Any(e => e.formaEnvioDetalleID == id);
        }
    }
}
