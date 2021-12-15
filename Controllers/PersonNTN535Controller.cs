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
    public class PersonNTN535Controller : Controller
    {
        private readonly DbContext _context;

        public PersonNTN535Controller(DbContext context)
        {
            _context = context;
        }

        // GET: PersonNTN535
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNTN535.ToListAsync());
        }

        // GET: PersonNTN535/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTN535 = await _context.PersonNTN535
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTN535 == null)
            {
                return NotFound();
            }

            return View(personNTN535);
        }

        // GET: PersonNTN535/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNTN535/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonNTN535 personNTN535)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNTN535);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNTN535);
        }

        // GET: PersonNTN535/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTN535 = await _context.PersonNTN535.FindAsync(id);
            if (personNTN535 == null)
            {
                return NotFound();
            }
            return View(personNTN535);
        }

        // POST: PersonNTN535/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonNTN535 personNTN535)
        {
            if (id != personNTN535.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNTN535);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNTN535Exists(personNTN535.PersonId))
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
            return View(personNTN535);
        }

        // GET: PersonNTN535/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTN535 = await _context.PersonNTN535
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTN535 == null)
            {
                return NotFound();
            }

            return View(personNTN535);
        }

        // POST: PersonNTN535/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personNTN535 = await _context.PersonNTN535.FindAsync(id);
            _context.PersonNTN535.Remove(personNTN535);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNTN535Exists(string id)
        {
            return _context.PersonNTN535.Any(e => e.PersonId == id);
        }
    }
}
