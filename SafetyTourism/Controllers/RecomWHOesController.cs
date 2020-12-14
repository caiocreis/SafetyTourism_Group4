using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SafetyTourism.Data;
using SafetyTourism.Models;

namespace SafetyTourism.Controllers
{
    public class RecomWHOesController : Controller
    {
        private readonly PlatformContext _context;

        public RecomWHOesController(PlatformContext context)
        {
            _context = context;
        }

        // GET: RecomWHOes
        public async Task<IActionResult> Index()
        {
            return View(await _context.RecomendationsWHO.ToListAsync());
        }

        // GET: RecomWHOes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recomWHO = await _context.RecomendationsWHO
                .FirstOrDefaultAsync(m => m.recomID == id);
            if (recomWHO == null)
            {
                return NotFound();
            }

            return View(recomWHO);
        }

        // GET: RecomWHOes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RecomWHOes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("recomID,description")] RecomWHO recomWHO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recomWHO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recomWHO);
        }

        // GET: RecomWHOes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recomWHO = await _context.RecomendationsWHO.FindAsync(id);
            if (recomWHO == null)
            {
                return NotFound();
            }
            return View(recomWHO);
        }

        // POST: RecomWHOes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("recomID,description")] RecomWHO recomWHO)
        {
            if (id != recomWHO.recomID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recomWHO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecomWHOExists(recomWHO.recomID))
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
            return View(recomWHO);
        }

        // GET: RecomWHOes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recomWHO = await _context.RecomendationsWHO
                .FirstOrDefaultAsync(m => m.recomID == id);
            if (recomWHO == null)
            {
                return NotFound();
            }

            return View(recomWHO);
        }

        // POST: RecomWHOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recomWHO = await _context.RecomendationsWHO.FindAsync(id);
            _context.RecomendationsWHO.Remove(recomWHO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecomWHOExists(int id)
        {
            return _context.RecomendationsWHO.Any(e => e.recomID == id);
        }
    }
}
