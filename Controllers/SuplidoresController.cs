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
    public class SuplidoresController : Controller
    {
        private readonly DataContext _context;

        public SuplidoresController(DataContext context)
        {
            _context = context;
        }

        // GET: Suplidores
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Suplidor.Include(s => s.Ciudad).Include(s => s.clasificacionSuplidor);
            return View(await dataContext.ToListAsync());
        }

        // GET: Suplidores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidor = await _context.Suplidor
                .Include(s => s.Ciudad)
                .Include(s => s.clasificacionSuplidor)
                .FirstOrDefaultAsync(m => m.idSuplidor == id);
            if (suplidor == null)
            {
                return NotFound();
            }

            return View(suplidor);
        }

        // GET: Suplidores/Create
        public IActionResult Create()
        {
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "nombre");
            ViewData["idClasificacionSuplidor"] = new SelectList(_context.ClasificacionSuplidor, "idClasificacionSuplidor", "TipoDeSuplidor");
            return View();
        }

        // POST: Suplidores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idSuplidor,nombre,telefono,email,idCiudad,idClasificacionSuplidor")] Suplidor suplidor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suplidor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "nombrw", suplidor.Ciudad.nombre);
            ViewData["idClasificacionSuplidor"] = new SelectList(_context.ClasificacionSuplidor, "idClasificacionSuplidor", "TipoDeSuplidor", suplidor.clasificacionSuplidor.TipoDeSuplidor);
            return View(suplidor);
        }

        // GET: Suplidores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidor = await _context.Suplidor.FindAsync(id);
            if (suplidor == null)
            {
                return NotFound();
            }
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "nombre", suplidor.idCiudad);
            ViewData["idClasificacionSuplidor"] = new SelectList(_context.ClasificacionSuplidor, "idClasificacionSuplidor", "TipoDeSuplidor", suplidor.idClasificacionSuplidor);
            return View(suplidor);
        }

        // POST: Suplidores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idSuplidor,nombre,telefono,email,idCiudad,idClasificacionSuplidor")] Suplidor suplidor)
        {
            if (id != suplidor.idSuplidor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suplidor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuplidorExists(suplidor.idSuplidor))
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
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "nombre", suplidor.Ciudad.nombre);
            ViewData["idClasificacionSuplidor"] = new SelectList(_context.ClasificacionSuplidor, "idClasificacionSuplidor", "TipoDeSuplidor", suplidor.clasificacionSuplidor.TipoDeSuplidor);
            return View(suplidor);
        }

        // GET: Suplidores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidor = await _context.Suplidor
                .Include(s => s.Ciudad)
                .Include(s => s.clasificacionSuplidor)
                .FirstOrDefaultAsync(m => m.idSuplidor == id);
            if (suplidor == null)
            {
                return NotFound();
            }

            return View(suplidor);
        }

        // POST: Suplidores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suplidor = await _context.Suplidor.FindAsync(id);
            _context.Suplidor.Remove(suplidor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuplidorExists(int id)
        {
            return _context.Suplidor.Any(e => e.idSuplidor == id);
        }
    }
}
