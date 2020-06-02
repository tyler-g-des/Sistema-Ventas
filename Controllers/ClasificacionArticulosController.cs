using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimerParcial.Data;
using PrimerParcial.Models.Clasificaciones;

namespace PrimerParcial.Controllers
{
    public class ClasificacionArticulosController : Controller
    {
        private readonly DataContext _context;

        public ClasificacionArticulosController(DataContext context)
        {
            _context = context;
        }

        // GET: ClasificacionArticulos
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClasificacionArticulos.ToListAsync());
        }

        // GET: ClasificacionArticulos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionArticulos = await _context.ClasificacionArticulos
                .FirstOrDefaultAsync(m => m.idClasificacionArticulos == id);
            if (clasificacionArticulos == null)
            {
                return NotFound();
            }

            return View(clasificacionArticulos);
        }

        // GET: ClasificacionArticulos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClasificacionArticulos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idClasificacionArticulos,TipoDeArticulos")] ClasificacionArticulos clasificacionArticulos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clasificacionArticulos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clasificacionArticulos);
        }

        // GET: ClasificacionArticulos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionArticulos = await _context.ClasificacionArticulos.FindAsync(id);
            if (clasificacionArticulos == null)
            {
                return NotFound();
            }
            return View(clasificacionArticulos);
        }

        // POST: ClasificacionArticulos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idClasificacionArticulos,TipoDeArticulos")] ClasificacionArticulos clasificacionArticulos)
        {
            if (id != clasificacionArticulos.idClasificacionArticulos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clasificacionArticulos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClasificacionArticulosExists(clasificacionArticulos.idClasificacionArticulos))
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
            return View(clasificacionArticulos);
        }

        // GET: ClasificacionArticulos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionArticulos = await _context.ClasificacionArticulos
                .FirstOrDefaultAsync(m => m.idClasificacionArticulos == id);
            if (clasificacionArticulos == null)
            {
                return NotFound();
            }

            return View(clasificacionArticulos);
        }

        // POST: ClasificacionArticulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clasificacionArticulos = await _context.ClasificacionArticulos.FindAsync(id);
            _context.ClasificacionArticulos.Remove(clasificacionArticulos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClasificacionArticulosExists(int id)
        {
            return _context.ClasificacionArticulos.Any(e => e.idClasificacionArticulos == id);
        }
    }
}
