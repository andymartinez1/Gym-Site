using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSite.Data;
using GymSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GymSite.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GymDBContext _context;

        public CategoryController(GymDBContext context)
        {
            _context = context;
        }

        // GET: Category
        public async Task<IActionResult> Index()
        {
            return View(await _context.EquipmentCategories.ToListAsync());
        }

        // GET: Category/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentCategory = await _context.EquipmentCategories.FirstOrDefaultAsync(m =>
                m.Id == id
            );
            if (equipmentCategory == null)
            {
                return NotFound();
            }

            return View(equipmentCategory);
        }

        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id,Category")] EquipmentCategory equipmentCategory
        )
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipmentCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(equipmentCategory);
        }

        // GET: Category/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentCategory = await _context.EquipmentCategories.FindAsync(id);
            if (equipmentCategory == null)
            {
                return NotFound();
            }

            return View(equipmentCategory);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            [Bind("Id,Category")] EquipmentCategory equipmentCategory
        )
        {
            if (id != equipmentCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipmentCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentCategoryExists(equipmentCategory.Id))
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

            return View(equipmentCategory);
        }

        // GET: Category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentCategory = await _context.EquipmentCategories.FirstOrDefaultAsync(m =>
                m.Id == id
            );
            if (equipmentCategory == null)
            {
                return NotFound();
            }

            return View(equipmentCategory);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipmentCategory = await _context.EquipmentCategories.FindAsync(id);
            if (equipmentCategory != null)
            {
                _context.EquipmentCategories.Remove(equipmentCategory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentCategoryExists(int id)
        {
            return _context.EquipmentCategories.Any(e => e.Id == id);
        }
    }
}
