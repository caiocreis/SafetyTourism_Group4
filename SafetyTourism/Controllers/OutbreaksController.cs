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
    public class OutbreaksController : Controller
    {
        private readonly PlatformContext _context;

        public OutbreaksController(PlatformContext context)
        {
            _context = context;
        }

        // GET: Outbreaks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Outbreaks.ToListAsync());
        }

        // GET: Outbreaks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outbreak = await _context.Outbreaks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (outbreak == null)
            {
                return NotFound();
            }

            return View(outbreak);
        }

        // GET: Outbreaks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Outbreaks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("outbreakID,ID,startDate")] Outbreak outbreak)
        {
            if (ModelState.IsValid)
            {
                _context.Add(outbreak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(outbreak);
        }

        // GET: Outbreaks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outbreak = await _context.Outbreaks.FindAsync(id);
            if (outbreak == null)
            {
                return NotFound();
            }
            return View(outbreak);
        }

        // POST: Outbreaks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("outbreakID,ID,startDate")] Outbreak outbreak)
        {
            if (id != outbreak.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(outbreak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OutbreakExists(outbreak.ID))
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
            return View(outbreak);
        }

        // GET: Outbreaks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outbreak = await _context.Outbreaks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (outbreak == null)
            {
                return NotFound();
            }

            return View(outbreak);
        }

        // POST: Outbreaks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var outbreak = await _context.Outbreaks.FindAsync(id);
            _context.Outbreaks.Remove(outbreak);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OutbreakExists(long id)
        {
            return _context.Outbreaks.Any(e => e.ID == id);
        }
    }
}
