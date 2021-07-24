using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portifolio.Data;
using Portifolio.Models;

namespace Portifolio.Controllers
{
    public class NotaFiscalController : Controller
    {
        private readonly IAgendamentoDbContext _context;

        public NotaFiscalController(IAgendamentoDbContext context)
        {
            _context = context;
        }

        // GET: NotaFiscal
        public async Task<IActionResult> Index()
        {
            return View(await _context.NotaFiscal.ToListAsync());
        }

        // GET: NotaFiscal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscal = await _context.NotaFiscal
                .FirstOrDefaultAsync(m => m.ID == id);
            if (notaFiscal == null)
            {
                return NotFound();
            }

            return View(notaFiscal);
        }

        // GET: NotaFiscal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NotaFiscal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NumeroNf,SerieNf,RemetenteNf,DestinatarioNf,DataEmissaoNf,ValorNf,ProdutoNf,PesoNf,QuantidadeNf")] NotaFiscal notaFiscal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notaFiscal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(notaFiscal);
        }

        // GET: NotaFiscal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscal = await _context.NotaFiscal.FindAsync(id);
            if (notaFiscal == null)
            {
                return NotFound();
            }
            return View(notaFiscal);
        }

        // POST: NotaFiscal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NumeroNf,SerieNf,RemetenteNf,DestinatarioNf,DataEmissaoNf,ValorNf,ProdutoNf,PesoNf,QuantidadeNf")] NotaFiscal notaFiscal)
        {
            if (id != notaFiscal.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notaFiscal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaFiscalExists(notaFiscal.ID))
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
            return View(notaFiscal);
        }

        // GET: NotaFiscal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaFiscal = await _context.NotaFiscal
                .FirstOrDefaultAsync(m => m.ID == id);
            if (notaFiscal == null)
            {
                return NotFound();
            }

            return View(notaFiscal);
        }

        // POST: NotaFiscal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notaFiscal = await _context.NotaFiscal.FindAsync(id);
            _context.NotaFiscal.Remove(notaFiscal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaFiscalExists(int id)
        {
            return _context.NotaFiscal.Any(e => e.ID == id);
        }
    }
}
