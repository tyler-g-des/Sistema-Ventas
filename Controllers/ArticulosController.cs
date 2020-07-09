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
    public class ArticulosController : Controller
    {
        private readonly DataContext _context;

        public ArticulosController(DataContext context)
        {
            _context = context;
        }

        // GET: Articulos
        public async Task<IActionResult> Index()
        {
           var dataContext = _context.Articulo.Include(a => a.ClasificacionArticulos).Include(a => a.Marca);
            return View(await dataContext.ToListAsync());
        }

        // GET: Articulos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulo
                .Include(a => a.ClasificacionArticulos)
                .Include(a => a.Marca)
              //  .Include(a => a.Suplidor)
                .FirstOrDefaultAsync(m => m.idArticulo == id);
            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        // GET: Articulos/Create
        public IActionResult Create()
        {
            ViewData["idClasificacionArticulos"] = new SelectList(_context.ClasificacionArticulos, "idClasificacionArticulos", "TipoDeArticulos");
            ViewData["idMarca"] = new SelectList(_context.Marca, "idMarca", "Nombre");
            ViewData["idSuplidor"] = new SelectList(_context.Suplidor, "idSuplidor", "nombre");
            return View();
        }

        // POST: Articulos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idArticulo,Nombre,Precio,Cantidad,idMarca,idClasificacionArticulos,idSuplidor")] Articulo articulo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(articulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
          //  ViewData["idClasificacionArticulos"] = new SelectList(_context.ClasificacionArticulos, "idClasificacionArticulos", "TipoDeArticulos", articulo.Suplidor.nombre);
            ViewData["idMarca"] = new SelectList(_context.Marca, "idMarca", "Nombre", articulo.Marca.Nombre);
           // ViewData["idSuplidor"] = new SelectList(_context.Suplidor, "idSuplidor", "nombre", articulo.Suplidor.nombre);
            return View(articulo);
        }

        // GET: Articulos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulo.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }
            ViewData["idClasificacionArticulos"] = new SelectList(_context.ClasificacionArticulos, "idClasificacionArticulos", "TipoDeArticulos", articulo.idClasificacionArticulos);
            ViewData["idMarca"] = new SelectList(_context.Marca, "idMarca", "Nombre", articulo.idMarca);
           // ViewData["idSuplidor"] = new SelectList(_context.Suplidor, "idSuplidor", "nombre", articulo.idSuplidor);
            return View(articulo);
        }

        // POST: Articulos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idArticulo,Nombre,Precio,Cantidad,idMarca,idClasificacionArticulos,idSuplidor")] Articulo articulo)
        {
            if (id != articulo.idArticulo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(articulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticuloExists(articulo.idArticulo))
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
            ViewData["idClasificacionArticulos"] = new SelectList(_context.ClasificacionArticulos, "idClasificacionArticulos", "TipoDeArticulos", articulo.ClasificacionArticulos.TipoDeArticulos);
            ViewData["idMarca"] = new SelectList(_context.Marca, "idMarca", "Nombre", articulo.Marca.Nombre);
           // ViewData["idSuplidor"] = new SelectList(_context.Suplidor, "idSuplidor", "nombre", articulo.Suplidor.nombre);
            return View(articulo);
        }

        // GET: Articulos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulo
                .Include(a => a.ClasificacionArticulos)
                .Include(a => a.Marca)
               // .Include(a => a.Suplidor)
                .FirstOrDefaultAsync(m => m.idArticulo == id);
            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        // POST: Articulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var articulo = await _context.Articulo.FindAsync(id);
            _context.Articulo.Remove(articulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticuloExists(int id)
        {
            return _context.Articulo.Any(e => e.idArticulo == id);
        }
    }
}
