using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crud.Models;

namespace Crud.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClienteContext _context;

        public ClientesController(ClienteContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }


        // GET: Employees/Create
        public IActionResult AddOuEditar(int id = 0)
        {
            if (id == 0)
                return View(new Cliente());
            else
                return View(_context.Clientes.Find(id));
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOuEditar([Bind("ClienteId,Nome,Telefone,Cpf")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                if (cliente.ClienteId == 0)
                    _context.Add(cliente);
                else
                    _context.Update(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }


        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            var employee = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
