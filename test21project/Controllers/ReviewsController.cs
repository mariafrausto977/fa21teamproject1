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
    [AllowAnonymous]
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reviews.ToListAsync());
        }


        // GET: Reviews/Details/5
        public async Task<IActionResult> Reviews(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a review to view!" });
            }

            //find the review in the database
            Review review = await _context.Reviews
                .Include(d => d.Property)
                .FirstOrDefaultAsync(m => m.ReviewID == id);

            //if the department is not in the database, show the user an error
            if (review == null)
            {
                return View("Error", new String[] { "This department was not found!" });
            }

            //show the user the details for this department
            return View(review);
        }

        // GET: Reviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewID,IndividualRating,ReviewText,DisputeReview")] Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //user did not specify a review to edit            
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a review to edit!" });
            }

            //find the review in the database
            Review review = await _context.Reviews.FindAsync(id);

            //see if the department exists in the database
            if (review == null)
            {
                return View("Error", new String[] { "This review does not exist in the database!" });
            }

            //send the user to the edit review page
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,IndividualRating,ReviewText,DisputeReview")] Review review)
        {
            if (id != review.ReviewID)
            {
                return View("Error", new String[] { "There was a problem editing this reivew. Try again!" });
            }

            //if the user messed up, send them back to the view to try again
            if (ModelState.IsValid == false)
            {
                return View(review);
            }

            //if code gets this far, make the updates
            try
            {
                _context.Update(review);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this review.", ex.Message });
            }

            //send the user back to the view with all the departments
            return RedirectToAction(nameof(Index));
        }
    }
}
