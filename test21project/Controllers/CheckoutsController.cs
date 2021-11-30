using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test21project.DAL;
using test21project.Models;

namespace test21project.Controllers
{
    public class CheckoutsController : Controller
    {
        private readonly AppDbContext _context;

        public string UserName { get; private set; }

        public CheckoutsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Checkouts
        public IActionResult Index()
        {
            //Set up a list of registrations to display
            List<Checkout> checkouts = new List<Checkout>();
            if (User.IsInRole("Admin"))
            {
                checkouts = _context.Checkouts
                                .Include(c => c.Reservations)
                                .ToList();
            }
            else //user is a customer, so only display their records
            {
                checkouts = _context.Checkouts
                                .Include(c => c.Reservations)
                                .Where(o => o.User.UserName == User.Identity.Name)
                                .ToList();
            }
            //
            return View(checkouts);
        }

        // GET: Checkouts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a Checkout to view!" });
            }

            Checkout checkout = await _context.Checkouts
                                              .Include(c => c.Reservations)
                                              .ThenInclude(c => c.Property)
                                              .Include(c => c.User)
                                              .FirstOrDefaultAsync(c => c.CheckoutID == id);
            if (checkout == null)
            {
                return View("Error", new String[] { "This checkout was not found!" });
            }

            if (User.IsInRole("Customer") && checkout.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your checkout!  Don't be such a snoop!" });
            }

            return View(checkout);
        }

        // GET: Checkouts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Checkouts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CheckoutID,StartDate,EndDate,CheckoutStatus")] Checkout checkout)
        {
            checkout.CheckoutNumber = Utilities.GenerateConfirmationNumber.GetNextConfirmationNumber(_context);

            checkout.User = _context.Users.FirstOrDefault(o => o.UserName == User.Identity.Name);
            if (ModelState.IsValid == false)
            {
                return View(checkout);
            }

            _context.Add(checkout);
            await _context.SaveChangesAsync();

            return RedirectToAction("Create", "Reservations", new { checkoutID = checkout.CheckoutID });
        }

        // GET: Checkouts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a checkout to view!" });
            }

            Checkout checkout = await _context.Checkouts
                                              .Include(c => c.Reservations)
                                              .ThenInclude(c => c.Property)
                                              .Include(c => c.User)
                                              .FirstOrDefaultAsync(m => m.CheckoutID == id);

            if (checkout == null)
            {
                return View("Error", new String[] { "This checkout was not found!" });
            }

            if (User.IsInRole("Customer") && checkout.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your checkout!  Don't be such a snoop!" });
            }


            return View(checkout);
        }


        // POST: Checkouts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CheckoutID,StartDate,EndDate,CheckoutStatus")] Checkout checkout)
        {
            if (id != checkout.CheckoutID)
            {
                return View("Error", new String[] { "There was a problem editing this checkout. Try again!" });
            }

            if (ModelState.IsValid == false)
            {
                return View(checkout);
            }
            try
            {
                Checkout dbCheckout = _context.Checkouts.Find(checkout.CheckoutID);

                //update the notes
                dbCheckout.StartDate = checkout.StartDate;
                dbCheckout.EndDate = checkout.EndDate;


                _context.Update(dbCheckout);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this checkout!", ex.Message });

            }
            return RedirectToAction(nameof(Index));

        }

        // GET: Checkouts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkout = await _context.Checkouts
                .FirstOrDefaultAsync(m => m.CheckoutID == id);
            if (checkout == null)
            {
                return NotFound();
            }

            return View(checkout);
        }

        // POST: Checkouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var checkout = await _context.Checkouts.FindAsync(id);
            _context.Checkouts.Remove(checkout);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CheckoutExists(int id)
        {
            return _context.Checkouts.Any(e => e.CheckoutID == id);
        }
    }
}