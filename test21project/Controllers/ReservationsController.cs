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
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index(int checkoutID)
        {
            if (checkoutID == null)
            {
                return NotFound();
            }

            List<Reservation> rs = _context.Reservations
                                        .Include(od => od.Property)
                                        .Where(od => od.Checkout.CheckoutID == checkoutID)
                                        .ToList();

            return View(rs);
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int checkoutID)
        {
            Reservation rs = new Reservation();

            Checkout dbCheckout = _context.Checkouts.Find(checkoutID);

            rs.Checkout = dbCheckout;

            ViewBag.AllProperties = GetAllProperties();

            return View(rs);
        }

        // GET: Reservations/Create
        [Authorize(Roles = "Customer, Admin")]
        public IActionResult Create(int checkoutID)
        {
            Reservation rs = new Reservation();

            Checkout dbCheckout = _context.Checkouts.Find(checkoutID);

            rs.Checkout = dbCheckout;

            ViewBag.AllProperties = GetAllProperties();

            return View(rs);
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Checkout,ReservationID,ReservationCheckIn, ReservationCheckOut")] Reservation reservation, int SelectedProperty, DateTime start, DateTime end, Decimal WeekendTotal, Decimal WeekdayTotal, Decimal DiscountAmount)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.AllProperties = GetAllProperties();
                return View(reservation);
            }

            Property dbProperty = _context.Properties.Find(SelectedProperty);
           
            reservation.Property = dbProperty;

            Checkout dbCheckout = _context.Checkouts.Find(reservation.Checkout.CheckoutID);

            reservation.Checkout = dbCheckout;

            reservation.ReservationCheckIn = dbCheckout.StartDate;
            reservation.ReservationCheckOut = dbCheckout.EndDate;
            reservation.WeekdayPrice = dbProperty.WeekdayPrice;
            reservation.WeekendPrice = dbProperty.WeekendPrice;

            start = reservation.ReservationCheckIn;
            end = reservation.ReservationCheckOut;

            if ((end - start).TotalDays == dbProperty.DiscountDays)
            {
                DiscountAmount = dbProperty.DiscountAmount;
            }

            //enter calculation here
            List<DateTime> WeekendDates = new List<DateTime>();
            List<DateTime> WeekdayDates = new List<DateTime>();

            foreach (DateTime day in EachDay(start,end))
            {

                if (day.DayOfWeek == DayOfWeek.Sunday || day.DayOfWeek == DayOfWeek.Saturday)
                { 
                    WeekendDates.Add(day);              
                }
                else
                {
                    WeekdayDates.Add(day);
                }
            }

            WeekendTotal = reservation.WeekendPrice * WeekendDates.Count();
            WeekdayTotal = reservation.WeekdayPrice * WeekdayDates.Count();

            var IndividualList = new List<Decimal>();

            reservation.IndividualTotal = (WeekdayTotal + WeekendTotal) - (reservation.IndividualTotal * DiscountAmount);

            IndividualList.Add(reservation.IndividualTotal);

            reservation.ReservationSubtotal = IndividualList.Sum();


            _context.Add(reservation);
            await _context.SaveChangesAsync();


            return RedirectToAction("Details", "Checkouts", new { id = reservation.Checkout.CheckoutID });
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //CHECK: check parameters
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationID,Reservation")] Reservation reservation)
        {
            if (id != reservation.ReservationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid == false)
            {
                return View(reservation);
            }

            Reservation dbRS;

            try
            {
                //find the existing registra detail in the database
                //include both registration and course
                dbRS = _context.Reservations
                      .Include(od => od.Property)
                      .Include(od => od.Checkout)
                      .FirstOrDefault(od => od.ReservationID == reservation.ReservationID);

                //update the scalar properties
                //CHECK: make sure you have all of the scalar properties 
                dbRS.ReservationCheckIn = reservation.ReservationCheckIn;
                dbRS.ReservationCheckOut = reservation.ReservationCheckOut;
                dbRS.WeekdayPrice = reservation.WeekdayPrice;
                dbRS.WeekendPrice = reservation.WeekendPrice;
                dbRS.ReservationSubtotal = reservation.ReservationSubtotal;
                dbRS.IndividualTotal = reservation.IndividualTotal;

                //save changes
                _context.Update(dbRS);
                await _context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the registration details index page
            return RedirectToAction("Details", "Checkouts", new { id = dbRS.Checkout.CheckoutID });
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
        }

        private SelectList GetAllProperties()
        {
            //create a list for all the courses
            List<Property> allProperties = _context.Properties.ToList();

            //use the constructor on select list to create a new select list with the options
            //CHECK: would it be in the nameof street?
            SelectList slAllProperties = new SelectList(allProperties, nameof(Property.PropertyID), nameof(Property.Street));

            return slAllProperties;
        }

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

    }
}
