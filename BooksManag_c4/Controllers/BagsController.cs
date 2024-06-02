using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BooksManag_c4.Data;
using BooksManag_c4.Models;

namespace BooksManag_c4.Controllers
{
    public class BagsController : Controller
    {
        private readonly BagsContext _context;

        public BagsController(BagsContext context)
        {
            _context = context;
        }

        // GET: Bags
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bags.ToListAsync());
        }

        // GET: Bags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bags = await _context.Bags
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bags == null)
            {
                return NotFound();
            }

            return View(bags);
        }

        // GET: Bags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Brand,Price,Date")] Bags bags)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bags);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bags);
        }

        // GET: Bags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bags = await _context.Bags.FindAsync(id);
            if (bags == null)
            {
                return NotFound();
            }
            return View(bags);
        }

        // POST: Bags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Brand,Price,Date")] Bags bags)
        {
            if (id != bags.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bags);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BagsExists(bags.ID))
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
            return View(bags);
        }

        // GET: Bags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bags = await _context.Bags
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bags == null)
            {
                return NotFound();
            }

            return View(bags);
        }

        // POST: Bags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bags = await _context.Bags.FindAsync(id);
            _context.Bags.Remove(bags);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BagsExists(int id)
        {
            return _context.Bags.Any(e => e.ID == id);
        }
        [HttpPost]
        public IActionResult UpdatePrice()
        {
            var bagsToUpdate = _context.Bags.Where(b => b.Date.Year == 2022);
            foreach (var bag in bagsToUpdate)
            {
                bag.Price = 2000;
            }
            _context.SaveChanges();

            return Ok("Prices updated.");
        }

        // Delete the Bags which are published in 1981
        [HttpPost]
        public IActionResult DeleteBags()
        {
            var bagsToDelete = _context.Bags.Where(b => b.Date.Year == 1981);
            _context.Bags.RemoveRange(bagsToDelete);
            _context.SaveChanges();

            return Ok("Bags deleted.");
        }

        // Retrieve the Brand of the Bags having a price greater than 500
        [HttpGet]
        public IActionResult GetBrands()
        {
            var brands = _context.Bags
                                 .Where(b => b.Price > 500)
                                 .Select(b => b.Brand)
                                 .ToList();

            return Ok(brands);
        }
    }
}
