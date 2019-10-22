using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStoreApp.Data;
using BookStoreApp.Models;

namespace BookStoreApp.Controllers
{
    public class PersonalLibrariesController : Controller
    {
        private readonly AppDbContext _context;

        public PersonalLibrariesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PersonalLibraries
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.PersonalLibraries.
                                Include(p => p.Client)
                                .ThenInclude(c => c.Membership);
            return View(await appDbContext.ToListAsync());
        }

        // GET: PersonalLibraries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalLibrary = await _context.PersonalLibraries
                .Include(p => p.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalLibrary == null)
            {
                return NotFound();
            }

            return View(personalLibrary);
        }

        // GET: PersonalLibraries/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Email");
            return View();
        }

        // POST: PersonalLibraries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreatedAt,ClientId")] PersonalLibrary personalLibrary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalLibrary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Email", personalLibrary.ClientId);
            return View(personalLibrary);
        }

        // GET: PersonalLibraries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalLibrary = await _context.PersonalLibraries.FindAsync(id);
            if (personalLibrary == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Email", personalLibrary.ClientId);
            return View(personalLibrary);
        }

        // POST: PersonalLibraries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CreatedAt,ClientId")] PersonalLibrary personalLibrary)
        {
            if (id != personalLibrary.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalLibrary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalLibraryExists(personalLibrary.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Email", personalLibrary.ClientId);
            return View(personalLibrary);
        }

        // GET: PersonalLibraries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalLibrary = await _context.PersonalLibraries
                .Include(p => p.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalLibrary == null)
            {
                return NotFound();
            }

            return View(personalLibrary);
        }

        // POST: PersonalLibraries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personalLibrary = await _context.PersonalLibraries.FindAsync(id);
            _context.PersonalLibraries.Remove(personalLibrary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalLibraryExists(int id)
        {
            return _context.PersonalLibraries.Any(e => e.Id == id);
        }
    }
}
