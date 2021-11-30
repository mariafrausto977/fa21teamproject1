using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test21project.DAL;
using test21project.Models;
using Microsoft.AspNetCore.Authorization;

namespace test21project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a category to view!" });
            }

            //find the category in the database
            Category category = await _context.Categories
                .Include(c => c.Properties)
                .FirstOrDefaultAsync(c => c.CategoryID == id);

            //if the category is not in the database, show the user an error
            if (category == null)
            {
                return View("Error", new String[] { "This category was not found!" });
            }

            //show the user the details for this category
            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryID,CategoryType")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //the user did not specify a category to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a category to edit!"});
            }

            //find the category in the database
            var category = await _context.Categories.FindAsync(id);

            // see if the category exists in the database
            if (category == null)
            {
                return View("Error", new String[] { "This category does not exist in the database!" });
            }

            //send the user to the edit category page
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryID,CategoryType")] Category category)
        {
            //this is a security measure to make sure they are editing the correct category
            if (id != category.CategoryID)
            {
                return View("Error", new String[] { "There was a problem editing this category. Try again!" });
            }

            //if the user messed up, send them back to the view to try again
            if (ModelState.IsValid == false)
            {
                return View(category);
            }

            //if code gets this far, make the updates
            try
            {
                _context.Update(category);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this category.", ex.Message });
            }

            //send the user back to the view with all the departments
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryID == id);
        }
    }
}
