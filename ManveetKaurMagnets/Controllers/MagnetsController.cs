using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManveetKaurMagnets.Data;
using ManveetKaurMagnets.Models;

namespace ManveetKaurMagnets.Controllers
{
    public class MagnetsController : Controller
    {
        private readonly ManveetKaurMagnetsContext _context;

        public MagnetsController(ManveetKaurMagnetsContext context)
        {
            _context = context;
        }

        // GET: Magnets
        public async Task<IActionResult> Index(string searchString)
        {
            var magnets = from m in _context.Magnets
                          select m;
            if (!String.IsNullOrEmpty(searchString))

            {
                magnets = magnets.Where(s => s.Shape.Contains(searchString));
            }
            return View(await magnets.ToListAsync());
        }

        // GET: Magnets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magnets = await _context.Magnets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (magnets == null)
            {
                return NotFound();
            }

            return View(magnets);
        }

        // GET: Magnets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Magnets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Shape,Colour,Type,Power,CustomerReview")] Magnets magnets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(magnets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(magnets);
        }

        // GET: Magnets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magnets = await _context.Magnets.FindAsync(id);
            if (magnets == null)
            {
                return NotFound();
            }
            return View(magnets);
        }

        // POST: Magnets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Shape,Colour,Type,Power,CustomerReview")] Magnets magnets)
        {
            if (id != magnets.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(magnets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MagnetsExists(magnets.Id))
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
            return View(magnets);
        }

        // GET: Magnets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magnets = await _context.Magnets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (magnets == null)
            {
                return NotFound();
            }

            return View(magnets);
        }

        // POST: Magnets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var magnets = await _context.Magnets.FindAsync(id);
            _context.Magnets.Remove(magnets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MagnetsExists(int id)
        {
            return _context.Magnets.Any(e => e.Id == id);
        }
    }
}
