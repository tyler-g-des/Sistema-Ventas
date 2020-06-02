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
    public class CiudadsController : Controller
    {
        private readonly DataContext _context;

        public CiudadsController(DataContext context)
        {
            _context = context;
        }

        // GET: Ciudads
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Ciudades.Include(c => c.Pais);
            return View(await dataContext.ToListAsync());
        }

        // GET: Ciudads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudades
                .Include(c => c.Pais)
                .FirstOrDefaultAsync(m => m.idCiudad == id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return View(ciudad);
        }

        // GET: Ciudads/Create
        public IActionResult Create()
        {
            ViewData["idPais"] = new SelectList(_context.Paises, "idPais", "idPais");
            return View();
        }

        // POST: Ciudads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idCiudad,nombre,Descripcion,idPais")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ciudad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idPais"] = new SelectList(_context.Paises, "idPais", "idPais", ciudad.idPais);
            return View(ciudad);
        }

        // GET: Ciudads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudades.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }
            ViewData["idPais"] = new SelectList(_context.Paises, "idPais", "idPais", ciudad.idPais);
            return View(ciudad);
        }

        // POST: Ciudads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCiudad,nombre,Descripcion,idPais")] Ciudad ciudad)
        {
            if (id != ciudad.idCiudad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ciudad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CiudadExists(ciudad.idCiudad))
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
            ViewData["idPais"] = new SelectList(_context.Paises, "idPais", "idPais", ciudad.idPais);
            return View(ciudad);
        }

        // GET: Ciudads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudades
                .Include(c => c.Pais)
                .FirstOrDefaultAsync(m => m.idCiudad == id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return View(ciudad);
        }

        // POST: Ciudads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ciudad = await _context.Ciudades.FindAsync(id);
            _context.Ciudades.Remove(ciudad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CiudadExists(int id)
        {
            return _context.Ciudades.Any(e => e.idCiudad == id);
        }
    }
}
