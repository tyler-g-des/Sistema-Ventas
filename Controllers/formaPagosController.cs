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
    public class formaPagosController : Controller
    {
        private readonly DataContext _context;

        public formaPagosController(DataContext context)
        {
            _context = context;
        }

        // GET: formaPagos
        public async Task<IActionResult> Index()
        {
            return View(await _context.formaPagos.ToListAsync());
        }

        // GET: formaPagos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPago = await _context.formaPagos
                .FirstOrDefaultAsync(m => m.formaPagoID == id);
            if (formaPago == null)
            {
                return NotFound();
            }

            return View(formaPago);
        }

        // GET: formaPagos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: formaPagos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("formaPagoID,formaPagoDescripcion")] formaPago formaPago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaPago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formaPago);
        }

        // GET: formaPagos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPago = await _context.formaPagos.FindAsync(id);
            if (formaPago == null)
            {
                return NotFound();
            }
            return View(formaPago);
        }

        // POST: formaPagos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("formaPagoID,formaPagoDescripcion")] formaPago formaPago)
        {
            if (id != formaPago.formaPagoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaPago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!formaPagoExists(formaPago.formaPagoID))
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
            return View(formaPago);
        }

        // GET: formaPagos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPago = await _context.formaPagos
                .FirstOrDefaultAsync(m => m.formaPagoID == id);
            if (formaPago == null)
            {
                return NotFound();
            }

            return View(formaPago);
        }

        // POST: formaPagos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaPago = await _context.formaPagos.FindAsync(id);
            _context.formaPagos.Remove(formaPago);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool formaPagoExists(int id)
        {
            return _context.formaPagos.Any(e => e.formaPagoID == id);
        }
    }
}
