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
    public class PuestoDeTrabajosController : Controller
    {
        private readonly DataContext _context;

        public PuestoDeTrabajosController(DataContext context)
        {
            _context = context;
        }

        // GET: PuestoDeTrabajos
        public async Task<IActionResult> Index()
        {
            return View(await _context.puestoDeTrabajos.ToListAsync());
        }

        // GET: PuestoDeTrabajos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puestoDeTrabajo = await _context.puestoDeTrabajos
                .FirstOrDefaultAsync(m => m.idPuesto == id);
            if (puestoDeTrabajo == null)
            {
                return NotFound();
            }

            return View(puestoDeTrabajo);
        }

        // GET: PuestoDeTrabajos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PuestoDeTrabajos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idPuesto,nombre,descripcion")] PuestoDeTrabajo puestoDeTrabajo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(puestoDeTrabajo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(puestoDeTrabajo);
        }

        // GET: PuestoDeTrabajos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puestoDeTrabajo = await _context.puestoDeTrabajos.FindAsync(id);
            if (puestoDeTrabajo == null)
            {
                return NotFound();
            }
            return View(puestoDeTrabajo);
        }

        // POST: PuestoDeTrabajos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idPuesto,nombre,descripcion")] PuestoDeTrabajo puestoDeTrabajo)
        {
            if (id != puestoDeTrabajo.idPuesto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(puestoDeTrabajo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PuestoDeTrabajoExists(puestoDeTrabajo.idPuesto))
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
            return View(puestoDeTrabajo);
        }

        // GET: PuestoDeTrabajos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puestoDeTrabajo = await _context.puestoDeTrabajos
                .FirstOrDefaultAsync(m => m.idPuesto == id);
            if (puestoDeTrabajo == null)
            {
                return NotFound();
            }

            return View(puestoDeTrabajo);
        }

        // POST: PuestoDeTrabajos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var puestoDeTrabajo = await _context.puestoDeTrabajos.FindAsync(id);
            _context.puestoDeTrabajos.Remove(puestoDeTrabajo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PuestoDeTrabajoExists(int id)
        {
            return _context.puestoDeTrabajos.Any(e => e.idPuesto == id);
        }
    }
}
