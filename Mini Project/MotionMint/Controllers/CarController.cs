using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Motion_Mint.Models;

namespace Motion_Mint.Controllers
{
    public class CarController : Controller
    {
        private readonly MotionMintContext _context;

        public CarController(MotionMintContext context)
        {
            _context = context;
        }

        // GET: Car
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carregs.ToListAsync());
        }

        // GET: Car/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carreg = await _context.Carregs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carreg == null)
            {
                return NotFound();
            }

            return View(carreg);
        }

        // GET: Car/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Carno,Make,Model,Available")] Carreg carreg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carreg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carreg);
        }

        // GET: Car/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carreg = await _context.Carregs.FindAsync(id);
            if (carreg == null)
            {
                return NotFound();
            }
            return View(carreg);
        }

        // POST: Car/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Carno,Make,Model,Available")] Carreg carreg)
        {
            if (id != carreg.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carreg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarregExists(carreg.Id))
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
            return View(carreg);
        }

        // GET: Car/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carreg = await _context.Carregs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carreg == null)
            {
                return NotFound();
            }

            return View(carreg);
        }

        // POST: Car/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carreg = await _context.Carregs.FindAsync(id);
            if (carreg != null)
            {
                _context.Carregs.Remove(carreg);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarregExists(int id)
        {
            return _context.Carregs.Any(e => e.Id == id);
        }
    }
}
