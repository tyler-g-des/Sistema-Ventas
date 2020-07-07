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
    public class TipoDeDocumentoController : Controller
    {
        private readonly DataContext _context;

        public TipoDeDocumentoController(DataContext context)
        {
            _context = context;
        }

        // GET: TipoDeDocumentoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.tipoDeDocumentos.ToListAsync());
        }

        // GET: TipoDeDocumentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDeDocumento = await _context.tipoDeDocumentos
                .FirstOrDefaultAsync(m => m.idTipoDeDocumento == id);
            if (tipoDeDocumento == null)
            {
                return NotFound();
            }

            return View(tipoDeDocumento);
        }

        // GET: TipoDeDocumentoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoDeDocumentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idTipoDeDocumento,Documento,Numero")] TipoDeDocumento tipoDeDocumento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoDeDocumento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDeDocumento);
        }

        // GET: TipoDeDocumentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDeDocumento = await _context.tipoDeDocumentos.FindAsync(id);
            if (tipoDeDocumento == null)
            {
                return NotFound();
            }
            return View(tipoDeDocumento);
        }

        // POST: TipoDeDocumentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idTipoDeDocumento,Documento,Numero")] TipoDeDocumento tipoDeDocumento)
        {
            if (id != tipoDeDocumento.idTipoDeDocumento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoDeDocumento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoDeDocumentoExists(tipoDeDocumento.idTipoDeDocumento))
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
            return View(tipoDeDocumento);
        }

        // GET: TipoDeDocumentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDeDocumento = await _context.tipoDeDocumentos
                .FirstOrDefaultAsync(m => m.idTipoDeDocumento == id);
            if (tipoDeDocumento == null)
            {
                return NotFound();
            }

            return View(tipoDeDocumento);
        }

        // POST: TipoDeDocumentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoDeDocumento = await _context.tipoDeDocumentos.FindAsync(id);
            _context.tipoDeDocumentos.Remove(tipoDeDocumento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoDeDocumentoExists(int id)
        {
            return _context.tipoDeDocumentos.Any(e => e.idTipoDeDocumento == id);
        }
    }
}
