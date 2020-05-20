using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoCompass.Models;

namespace ProjetoCompass.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly Context _context;

        public FuncionarioController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Funcionarios.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Funcionario func)
        {
            if (ModelState.IsValid)
            {
                _context.Add(func);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            else return View(func);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                Funcionario func = _context.Funcionarios.Find(id);
                return View(func);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int? id, Funcionario func)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _context.Update(func);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(func);
            }

            return NotFound();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Funcionario func = _context.Funcionarios.Find(id);
                return View(func);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int? id, Funcionario func)
        {
            if (id != null)
            {
                _context.Remove(func);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }

    }
}
