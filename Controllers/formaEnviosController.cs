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
    public class formaEnviosController : Controller
    {
        private readonly DataContext _context;

        public formaEnviosController(DataContext context)
        {
            _context = context;
        }

        // GET: formaEnvios
        public async Task<IActionResult> Index()
        {
            return View(await _context.formaEnvios.ToListAsync());
        }

        // GET: formaEnvios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaEnvio = await _context.formaEnvios
                .FirstOrDefaultAsync(m => m.formaEnvioID == id);
            if (formaEnvio == null)
            {
                return NotFound();
            }

            return View(formaEnvio);
        }

        // GET: formaEnvios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: formaEnvios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("formaEnvioID,formaEnvioDescripcion")] formaEnvio formaEnvio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaEnvio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formaEnvio);
        }

        // GET: formaEnvios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaEnvio = await _context.formaEnvios.FindAsync(id);
            if (formaEnvio == null)
            {
                return NotFound();
            }
            return View(formaEnvio);
        }

        // POST: formaEnvios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("formaEnvioID,formaEnvioDescripcion")] formaEnvio formaEnvio)
        {
            if (id != formaEnvio.formaEnvioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaEnvio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!formaEnvioExists(formaEnvio.formaEnvioID))
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
            return View(formaEnvio);
        }

        // GET: formaEnvios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaEnvio = await _context.formaEnvios
                .FirstOrDefaultAsync(m => m.formaEnvioID == id);
            if (formaEnvio == null)
            {
                return NotFound();
            }

            return View(formaEnvio);
        }

        // POST: formaEnvios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaEnvio = await _context.formaEnvios.FindAsync(id);
            _context.formaEnvios.Remove(formaEnvio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool formaEnvioExists(int id)
        {
            return _context.formaEnvios.Any(e => e.formaEnvioID == id);
        }
    }
}
