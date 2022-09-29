using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AzureProjectDB.Models;

namespace AzureProjectDB.Controllers
{
    public class ErrorViewModelsController : Controller
    {
        private readonly DataContext _context;

        public ErrorViewModelsController(DataContext context)
        {
            _context = context;
        }

        // GET: ErrorViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.tableFir.ToListAsync());
        }

        // GET: ErrorViewModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var errorViewModel = await _context.tableFir
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (errorViewModel == null)
            {
                return NotFound();
            }

            return View(errorViewModel);
        }

        // GET: ErrorViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ErrorViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestId,IdProVip")] ErrorViewModel errorViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(errorViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(errorViewModel);
        }

        // GET: ErrorViewModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var errorViewModel = await _context.tableFir.FindAsync(id);
            if (errorViewModel == null)
            {
                return NotFound();
            }
            return View(errorViewModel);
        }

        // POST: ErrorViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("RequestId,IdProVip")] ErrorViewModel errorViewModel)
        {
            if (id != errorViewModel.RequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(errorViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ErrorViewModelExists(errorViewModel.RequestId))
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
            return View(errorViewModel);
        }

        // GET: ErrorViewModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var errorViewModel = await _context.tableFir
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (errorViewModel == null)
            {
                return NotFound();
            }

            return View(errorViewModel);
        }

        // POST: ErrorViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var errorViewModel = await _context.tableFir.FindAsync(id);
            _context.tableFir.Remove(errorViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ErrorViewModelExists(string id)
        {
            return _context.tableFir.Any(e => e.RequestId == id);
        }
    }
}
