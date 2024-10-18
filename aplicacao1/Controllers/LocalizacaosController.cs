using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aplicacao1.Data;
using aplicacao1.Models;

namespace aplicacao1.Controllers
{
    public class LocalizacaosController : Controller
    {
        private readonly aplicacao1Context _context;

        public LocalizacaosController(aplicacao1Context context)
        {
            _context = context;
        }

        // GET: Localizacaos
        public async Task<IActionResult> Index()
        {
              return _context.Localizacao != null ? 
                          View(await _context.Localizacao.ToListAsync()) :
                          Problem("Entity set 'aplicacao1Context.Localizacao'  is null.");
        }

        // GET: Localizacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Localizacao == null)
            {
                return NotFound();
            }

            var localizacao = await _context.Localizacao
                .FirstOrDefaultAsync(m => m.IdEndereco == id);
            if (localizacao == null)
            {
                return NotFound();
            }

            return View(localizacao);
        }

        // GET: Localizacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Localizacaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Destino,Distancia,IdEndereco,rua,numero,logradouro,bairro,latitude,longitude")] Localizacao localizacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localizacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(localizacao);
        }

        // GET: Localizacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Localizacao == null)
            {
                return NotFound();
            }

            var localizacao = await _context.Localizacao.FindAsync(id);
            if (localizacao == null)
            {
                return NotFound();
            }
            return View(localizacao);
        }

        // POST: Localizacaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Destino,Distancia,IdEndereco,rua,numero,logradouro,bairro,latitude,longitude")] Localizacao localizacao)
        {
            if (id != localizacao.IdEndereco)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localizacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalizacaoExists(localizacao.IdEndereco))
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
            return View(localizacao);
        }

        // GET: Localizacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Localizacao == null)
            {
                return NotFound();
            }

            var localizacao = await _context.Localizacao
                .FirstOrDefaultAsync(m => m.IdEndereco == id);
            if (localizacao == null)
            {
                return NotFound();
            }

            return View(localizacao);
        }

        // POST: Localizacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Localizacao == null)
            {
                return Problem("Entity set 'aplicacao1Context.Localizacao'  is null.");
            }
            var localizacao = await _context.Localizacao.FindAsync(id);
            if (localizacao != null)
            {
                _context.Localizacao.Remove(localizacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocalizacaoExists(int id)
        {
          return (_context.Localizacao?.Any(e => e.IdEndereco == id)).GetValueOrDefault();
        }
    }
}
