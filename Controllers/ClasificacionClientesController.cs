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
    public class ClasificacionClientesController : Controller
    {
        private readonly DataContext _context;

        public ClasificacionClientesController(DataContext context)
        {
            _context = context;
        }

        // GET: ClasificacionClientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.clasificacionClientes.ToListAsync());
        }

        // GET: ClasificacionClientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionCliente = await _context.clasificacionClientes
                .FirstOrDefaultAsync(m => m.idClasificacionCliente == id);
            if (clasificacionCliente == null)
            {
                return NotFound();
            }

            return View(clasificacionCliente);
        }

        // GET: ClasificacionClientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClasificacionClientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idClasificacionCliente,TipoDeCliente")] ClasificacionCliente clasificacionCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clasificacionCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clasificacionCliente);
        }

        // GET: ClasificacionClientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionCliente = await _context.clasificacionClientes.FindAsync(id);
            if (clasificacionCliente == null)
            {
                return NotFound();
            }
            return View(clasificacionCliente);
        }

        // POST: ClasificacionClientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idClasificacionCliente,TipoDeCliente")] ClasificacionCliente clasificacionCliente)
        {
            if (id != clasificacionCliente.idClasificacionCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clasificacionCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClasificacionClienteExists(clasificacionCliente.idClasificacionCliente))
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
            return View(clasificacionCliente);
        }

        // GET: ClasificacionClientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clasificacionCliente = await _context.clasificacionClientes
                .FirstOrDefaultAsync(m => m.idClasificacionCliente == id);
            if (clasificacionCliente == null)
            {
                return NotFound();
            }

            return View(clasificacionCliente);
        }

        // POST: ClasificacionClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clasificacionCliente = await _context.clasificacionClientes.FindAsync(id);
            _context.clasificacionClientes.Remove(clasificacionCliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClasificacionClienteExists(int id)
        {
            return _context.clasificacionClientes.Any(e => e.idClasificacionCliente == id);
        }
    }
}
