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
    public class EmpleadosController : Controller
    {
        private readonly DataContext _context;

        public EmpleadosController(DataContext context)
        {
            _context = context;
        }

        // GET: Empleados
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Empleados.Include(e => e.Ciudad).Include(e => e.Empresa);
            return View(await dataContext.ToListAsync());
        }

        // GET: Empleados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados
                .Include(e => e.Ciudad)
                .Include(e => e.Empresa)
                .FirstOrDefaultAsync(m => m.idEmpleado == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // GET: Empleados/Create
        public IActionResult Create()
        {
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "idCiudad");
            ViewData["idEmpresa"] = new SelectList(_context.Empresas, "idEmpresa", "idEmpresa");
            return View();
        }

        // POST: Empleados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idEmpleado,nombre,telefono,email,Direccion,idEmpresa,idCiudad,idTipoDocumento")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "idCiudad", empleado.idCiudad);
            ViewData["idEmpresa"] = new SelectList(_context.Empresas, "idEmpresa", "idEmpresa", empleado.idEmpresa);
            return View(empleado);
        }

        // GET: Empleados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "idCiudad", empleado.idCiudad);
            ViewData["idEmpresa"] = new SelectList(_context.Empresas, "idEmpresa", "idEmpresa", empleado.idEmpresa);
            return View(empleado);
        }

        // POST: Empleados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idEmpleado,nombre,telefono,email,Direccion,idEmpresa,idCiudad,idTipoDocumento")] Empleado empleado)
        {
            if (id != empleado.idEmpleado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpleadoExists(empleado.idEmpleado))
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
            ViewData["idCiudad"] = new SelectList(_context.Ciudades, "idCiudad", "idCiudad", empleado.idCiudad);
            ViewData["idEmpresa"] = new SelectList(_context.Empresas, "idEmpresa", "idEmpresa", empleado.idEmpresa);
            return View(empleado);
        }

        // GET: Empleados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados
                .Include(e => e.Ciudad)
                .Include(e => e.Empresa)
                .FirstOrDefaultAsync(m => m.idEmpleado == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // POST: Empleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleados.Any(e => e.idEmpleado == id);
        }
    }
}
