using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test21project.DAL;
using test21project.Models;
using test21project.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace test21project.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        // GET: Properties
        public async Task<IActionResult> Index()
        {
            var query = from p in _context.Properties
                        select p;

            // Populate the view bag with a count of all properties
            ViewBag.AllProperties = _context.Properties.Count();

            // Default count of SelectedProperties is equal to AllProperties
            ViewBag.SelectedProperties = ViewBag.AllProperties;

            List<Property> AllProperties = query.Include(p => p.Category).Include(p => p.Reviews).ToList();
            // TODO: order by what property? also not sure if this is right
            return View(AllProperties);
        }

        [AllowAnonymous]
        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) // PropertyID not specified
            {
                // user did not specify a PropertyID - take them to the error view
                return View("Error", new String[] { "PropertyID not specified - which property do you want to view?" });
            }

            //find the Property in the database
            //be sure to include the relevant navigational data
            Property property = _context.Properties.Include(p => p.Category).Include(p => p.Reviews).FirstOrDefault(p => p.PropertyID == id);

            //property was not found in the database
            if (property == null)
            {
                return View("Error", new String[] { "This property is not found in the database." });
            }

            // if code gets this far, display the details 
            return View(property);
        }

        [Authorize(Roles = "Host")]
        // GET: Properties/Create
        public IActionResult Create()
        {
            ViewBag.AllCategories = GetAllCategories();
            return View();
        }

        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.S
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Host")]
        public async Task<IActionResult> Create([Bind("PropertyID,Street,UnitNumber,City,State,ZipCode,HostEmail,WeekdayPrice,WeekendPrice,DiscountAmount,DiscountDays,Bedrooms,Bathrooms,GuestsAllowed,PetsAllowed,ParkingFree,CleaningFee,Status")] Property property, int SelectedCategoryID)
        {
            //Set the value for the PropertyID
            property.PropertyID = Utilities.GeneratePropertyNumber.GetNextPropertyNumber(_context);

            //This code has been modified so that if the model state is not valid
            //we immediately go to the "sad path" and give the user a chance to try again
            if (ModelState.IsValid == false)
            {
                //re-populate the view bag with the categories
                ViewBag.AllCategories = GetAllCategories();
                //go back to the Create view to try again
                return View(property);
            }

            //if code gets to this point, we know the model is valid and
            //we can add the property to the database

            //add the property to the database and save changes
            _context.Add(property);
            await _context.SaveChangesAsync();

            //add the associated category to the property
            //check the category id selected by the user
            Category dbCategory = _context.Categories.Find(SelectedCategoryID);

            //add the category to the property's category and save changes
            property.Category = dbCategory;
            _context.SaveChanges();

            //Send the user to the page with all the categories
            return RedirectToAction(nameof(Index));
        }

        // GET: Properties/Edit/5
        [Authorize(Roles = "Host")]
        public async Task<IActionResult> Edit(int? id)
        {
            //if the user didn't specify a property id, we can't show them 
            //the data, so show an error instead
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a property to edit!" });
            }

            //find the property in the database
            Property property = await _context.Properties.Include(p => p.Category)
                                           .FirstOrDefaultAsync(p => p.PropertyID == id);

            //if the property does not exist in the database, then show the useran error message
            if (property == null)
            {
                return View("Error", new string[] { "This property was not found!" });
            }

            //populate the viewbag with existing categories
            ViewBag.AllCategories = GetAllCategories(property);
            return View(property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Host")]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyID,Street,UnitNumber,City,State,ZipCode,HostEmail,WeekdayPrice,WeekendPrice,DiscountAmount,DiscountDays,Bedrooms,Bathrooms,GuestsAllowed,PetsAllowed,ParkingFree,CleaningFee,Status")] Property property, int SelectedCategoryID)
        {
            //this is a security check to see if the user is trying to modify
            //a different record.  Show an error message
            if (id != property.PropertyID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            if (ModelState.IsValid == false) //there is something wrong
            {
                ViewBag.AllCategories = GetAllCategories(property);
                return View(property);
            }

            //if code gets this far, attempt to edit the property
            try
            {
                //Find the property to edit in the database and include relevant 
                //navigational properties
                Property dbProperty = _context.Properties
                    .Include(p => p.Category)
                    .FirstOrDefault(p => p.PropertyID == property.PropertyID);

                //create category object that need to be removed
                Category CategoryToRemove = new Category();

                //find the category that should no longer be selected because the user removed them
                //see if the new id matches the old category id 
                var dbPropCategory = dbProperty.Category;
                if (SelectedCategoryID != dbPropCategory.CategoryID)
                {
                    CategoryToRemove = dbPropCategory;
                }

                //remove the category you found above
                //this has to be 2 separate steps because you can't iterate (loop)
                //over a list that you are removing things from
                CategoryToRemove = new Category();
                dbProperty.Category = CategoryToRemove;
                _context.SaveChanges();

                //add the category that isn't already there
                if (dbProperty.Category.CategoryID != SelectedCategoryID) // this category is NOT already associated with this property
                {
                    // find the associated category in the database 
                    Category dbCategory = _context.Categories.Find(SelectedCategoryID);

                    // add this category to the property
                    dbProperty.Category = dbCategory;
                    _context.SaveChanges();
                }

                //update the property's scalar properties
                dbProperty.Street = property.Street;
                dbProperty.UnitNumber = property.UnitNumber;
                dbProperty.City = property.City;
                dbProperty.State = property.State;
                dbProperty.ZipCode = property.ZipCode;
                dbProperty.HostEmail = property.HostEmail;
                dbProperty.WeekdayPrice = property.WeekdayPrice;
                dbProperty.WeekendPrice = property.WeekendPrice;
                dbProperty.DiscountAmount = property.DiscountAmount;
                dbProperty.DiscountDays = property.DiscountDays;
                dbProperty.Bedrooms = property.Bedrooms;
                dbProperty.Bathrooms = property.Bathrooms;
                dbProperty.GuestsAllowed = property.GuestsAllowed;
                dbProperty.PetsAllowed = property.PetsAllowed;
                dbProperty.ParkingFree = property.ParkingFree;
                dbProperty.CleaningFee = property.CleaningFee;

                //save the changes
                _context.Properties.Update(dbProperty);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this course.", ex.Message });
            }

            //if code gets this far, everything is okay
            //send the user back to the page with all the courses
            return RedirectToAction(nameof(Index));
        }

        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }

        private SelectList GetAllCategories()
        {
            // Create a new list of categories and get the list of the categories from the database
            List<Category> categoryList = _context.Categories.ToList();

            // add a dummy record like you do for select lists
            // TODO: maybe remove if we want to show everything without selecting AllCategories?
            Category SelectNone = new Category() { CategoryID = 0, CategoryType = "All Property Categories" };
            categoryList.Add(SelectNone);

            //use the SelectList constructor method to get a new SelectList
            SelectList SelectList = new SelectList(categoryList.OrderBy(c => c.CategoryType), "CategoryID", "CategoryType");

            //return the SelectList
            return SelectList;
        }

        // TODO: SelectList function with Property parameter may be wrong?
        private SelectList GetAllCategories(Property property)
        {
            // Create a new list of categories and get the list of the categories from the database
            List<Category> categoryList = _context.Categories.ToList();

            //store property's CategoryID into selectedCategoryID
            int selectedCategoryID = new int();
            selectedCategoryID = property.Category.CategoryID;

            //use the SelectList constructor method to get a new SelectList
            SelectList SelectList = new SelectList(categoryList.OrderBy(c => c.CategoryType), "CategoryID", "CategoryType", selectedCategoryID);

            //return the SelectList
            return SelectList;
        }


        public IActionResult DetailedSearch()
        {
            // populate the view bag with a list of categories
            ViewBag.AllCategories = GetAllCategories();

            // set default properties
            // TODO: add additional default properties???
            SearchViewModel svm = new SearchViewModel();

            return View(svm);
        }

        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            // Initial query 
            var query = from p in _context.Properties
                        select p;

            // Search City field if SearchCity is not null or empty
            if (String.IsNullOrEmpty(svm.SearchCity) == false)
            {
                query = query.Where(p => p.City.Contains(svm.SearchCity));
            }

            // Search State field if SearchState is not null
            if (svm.SearchState != null)
            {
                query = query.Where(p => p.State == svm.SearchState);
            }

            // Search AvgRating field if SearchAvgRating is not null
            if (svm.SearchAvgRating != null)
            {
                query = query.Where(p => p.AvgRating >= svm.SearchAvgRating);
            }

            // Search GuestsAllowed field if SearchGuestsAllowed is not null
            if (svm.SearchGuestsAllowed != null)
            {
                query = query.Where(p => p.GuestsAllowed >= svm.SearchGuestsAllowed);
            }

            // Search WeekdayPrice field
            if (svm.SearchMinWeekdayPrice != null && svm.SearchMaxWeekdayPrice == null)
            {
                query = query.Where(p => p.WeekdayPrice >= svm.SearchMinWeekdayPrice);
            }
            else if (svm.SearchMinWeekdayPrice == null && svm.SearchMaxWeekdayPrice != null)
            {
                query = query.Where(p => p.WeekdayPrice <= svm.SearchMaxWeekdayPrice);
            }
            else if (svm.SearchMinWeekdayPrice != null && svm.SearchMaxWeekdayPrice != null)
            {
                query = query.Where(p => p.WeekdayPrice >= svm.SearchMinWeekdayPrice && p.WeekdayPrice <= svm.SearchMaxWeekdayPrice);
            }

            // Search WeekendPrice field
            if (svm.SearchMinWeekendPrice != null && svm.SearchMaxWeekendPrice == null)
            {
                query = query.Where(p => p.WeekendPrice >= svm.SearchMinWeekendPrice);
            }
            else if (svm.SearchMinWeekendPrice == null && svm.SearchMaxWeekendPrice != null)
            {
                query = query.Where(p => p.WeekendPrice <= svm.SearchMaxWeekendPrice);
            }
            else if (svm.SearchMinWeekendPrice != null && svm.SearchMaxWeekendPrice != null)
            {
                query = query.Where(p => p.WeekendPrice >= svm.SearchMinWeekendPrice && p.WeekendPrice <= svm.SearchMaxWeekendPrice);
            }

            // Search Category field if SearchCategory is not null
            if (svm.SearchCategory != null)
            {
                query = query.Where(p => p.Category == svm.SearchCategory);
            }

            // Search Bedrooms field if SearchBedrooms is not null
            if (svm.SearchBedrooms != null)
            {
                query = query.Where(p => p.Bedrooms == svm.SearchBedrooms);
            }

            // Search Bathrooms field if SearchBathrooms is not null
            if (svm.SearchBathrooms != null)
            {
                query = query.Where(p => p.Bathrooms == svm.SearchBathrooms);
            }

            // Search PetsAllowed field if SearchPetsAllowed is not null
            if (svm.SearchPetsAllowed != null)
            {
                query = query.Where(p => p.PetsAllowed == svm.SearchPetsAllowed);
            }

            // Search ParkingFree field if SearchParkingFree is not null
            if (svm.SearchParkingFree != null)
            {
                query = query.Where(p => p.ParkingFree == svm.SearchParkingFree);
            }

            // Search ReservationCheckIn field if SearchStarteDate is not null
            //if (svm.SearchStartDate != null)
            //{
            //query = query.Where(p => p.Reservations.ReservationCheckIn >= svm.SearchStartDate);
            //}

            // Search ReservationCheckOut field if SearchStarteDate is not null
            //if (svm.SearchEndDate != null)
            //{
            //query = query.Where(p => p.Reservation.ReservationCheckOut <= svm.SearchEndDate);
            //}

            // Execute the query 
            List<Property> SelectedProperties = query.Include(p => p.Reviews).Include(p => p.Reservations).ToList();

            // Populate the view bag with a count of all properties 
            ViewBag.AllProperties = _context.Properties.Count();

            // Populate the view bag with a count of selected properties
            ViewBag.SelectedProperties = SelectedProperties.Count();

            // Pass SelectedProperties back to the View
            return View("Index", SelectedProperties.OrderBy(p => new { p.WeekdayPrice, p.WeekendPrice }));
        }
    }
}