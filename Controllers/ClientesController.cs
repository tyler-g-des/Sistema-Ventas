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
    public class ClientesController : Controller
    {
        private readonly DataContext _context;
        String[] opciones = { "No_Identicacion", "Pasaporte" };

        public ClientesController(DataContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Clientes.Include(c => c.Ciudad).Include(c => c.clasificacionCliente);
            return View(await dataContext.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .Include(c => c.Ciudad)
                .Include(c => c.clasificacionCliente)
                .FirstOrDefaultAsync(m => m.idCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "nombre");
            ViewData["idClasificacionCliente"] = new SelectList(_context.clasificacionClientes, "idClasificacionCliente", "TipoDeCliente");
            ViewData["idTipoDocumento"] = new SelectList(opciones.ToList());
            ViewData["idTipoDocumento"] = new SelectList(_context.tipoDeDocumentos, "idClasificacionCliente", "Numero");

            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idCliente,nombre,telefono,email,Direccion,idTipoDocumento,idCiudad,idClasificacionCliente,clasificacionCliente,Ciudad")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "nombre", cliente.Ciudad.nombre);
            ViewData["idClasificacionCliente"] = new SelectList(_context.clasificacionClientes, "idClasificacionCliente", "TipoDeCliente", cliente.clasificacionCliente.TipoDeCliente);
            ViewData["Seleccion"] = new SelectList(opciones.ToList());
            ViewData["idTipoDocumento"] = new SelectList(_context.tipoDeDocumentos, "idClasificacionCliente", "Numero", cliente.Documento.Numero);
            return View(cliente);
        }
        
        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "nombre", cliente.idCiudad);
            ViewData["idClasificacionCliente"] = new SelectList(_context.clasificacionClientes, "idClasificacionCliente", "TipoDeCliente", cliente.idClasificacionCliente);
            ViewData["idTipoDocumento"] = new SelectList(_context.tipoDeDocumentos, "idTipoDeDocumento", "Numero", cliente.idTipoDocumento);

            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCliente,nombre,telefono,email,Direccion,idTipoDocumento,idCiudad,idClasificacionCliente,Ciudad,clasificacionCliente,Documento")] Cliente cliente)
        {
            if (id != cliente.idCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.idCliente))
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
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "nombre", cliente.Ciudad.nombre);           
            ViewData["idClasificacionCliente"] = new SelectList(_context.clasificacionClientes, "idClasificacionCliente", "clasificacionCliente", cliente.clasificacionCliente.TipoDeCliente);
            ViewData["idTipoDocumento"] = new SelectList(_context.tipoDeDocumentos, "idTipoDeDocumento", "Numero", cliente.Documento.Numero);

            return View(cliente);                                                                                          
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .Include(c => c.Ciudad)
                .Include(c => c.clasificacionCliente)
                .FirstOrDefaultAsync(m => m.idCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.idCliente == id);
        }
    }
}
