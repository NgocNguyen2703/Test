using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Controllers
{
    public class NTN0535Controller : Controller
    {
        private readonly DbContext _context;

        public NTN0535Controller(DbContext context)
        {
            _context = context;
        }

        // GET: NTN0535
        public async Task<IActionResult> Index()
        {
            return View(await _context.NTN0535.ToListAsync());
        }

        // GET: NTN0535/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTN0535 = await _context.NTN0535
                .FirstOrDefaultAsync(m => m.NTNId == id);
            if (nTN0535 == null)
            {
                return NotFound();
            }

            return View(nTN0535);
        }

        // GET: NTN0535/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTN0535/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTNId,NTNName,NTNGender")] NTN0535 nTN0535)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTN0535);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTN0535);
        }

        // GET: NTN0535/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTN0535 = await _context.NTN0535.FindAsync(id);
            if (nTN0535 == null)
            {
                return NotFound();
            }
            return View(nTN0535);
        }

        // POST: NTN0535/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTNId,NTNName,NTNGender")] NTN0535 nTN0535)
        {
            if (id != nTN0535.NTNId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTN0535);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTN0535Exists(nTN0535.NTNId))
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
            return View(nTN0535);
        }

        // GET: NTN0535/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTN0535 = await _context.NTN0535
                .FirstOrDefaultAsync(m => m.NTNId == id);
            if (nTN0535 == null)
            {
                return NotFound();
            }

            return View(nTN0535);
        }

        // POST: NTN0535/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nTN0535 = await _context.NTN0535.FindAsync(id);
            _context.NTN0535.Remove(nTN0535);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTN0535Exists(string id)
        {
            return _context.NTN0535.Any(e => e.NTNId == id);
        }
    }
}
