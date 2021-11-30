using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using test21project.DAL;

namespace test21project.Models
{
	public enum States
	{
		AL, AK, AZ, AR, CA, CO, CT, DE, FL, GA,
		HI, ID, IL, IN, IA, KS, KY, LA, ME, MD,
		MA, MI, MN, MS, MO, MT, NE, NV, NH, NJ,
		NM, NY, NC, ND, OH, OK, OR, PA, RI, SC,
		SD, TN, TX, UT, VT, VA, WA, WV, WI, WY,
		DC
	}

	public class Property
	{
		public Int32 PropertyID { get; set; }

		[Display(Name = "Property Number:")]
		public String PropertyNumber { get; set; }

		[Required(ErrorMessage = "Street address is required!")]
		[Display(Name = "Street address:")]
		public String Street { get; set; }

		[Display(Name = "Unit Number:")]
		public String UnitNumber { get; set; }

		[Required(ErrorMessage = "City is required!")]
		[Display(Name = "City:")]
		public String City { get; set; }

		[Required(ErrorMessage = "State is required!")]
		[Display(Name = "State:")]
		public States State { get; set; }

		[Required(ErrorMessage = "Zip Code is required!")]
		[Display(Name = "Zip Code:")]
		public String ZipCode { get; set; }

		[Display(Name = "Average Guest Rating")]
		public Decimal AvgRating
		{
			get { return Reviews.Sum(ar => ar.IndividualRating) / (Reviews.Count() * 5); }
		}

		[Required(ErrorMessage = "Host Email is required!")]
		[Display(Name = "Host Email:")]
		[DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid!")]
		public String HostEmail { get; set; }

		[Required(ErrorMessage = "Weekday price is required!")]
		[Display(Name = "Weekday Price:")]
		public Decimal WeekdayPrice { get; set; }

		[Required(ErrorMessage = "Weekend price is required!")]
		[Display(Name = "Weekend Price:")]
		public Decimal WeekendPrice { get; set; }

		[Display(Name = "Discount Amount:")]
		public Decimal DiscountAmount { get; set; }

		[Display(Name = "Discount Days:")]
		public int DiscountDays { get; set; }

		[Required(ErrorMessage = "Number of Bedrooms is required!")]
		[Display(Name = "Number of Bedrooms:")]
		public int Bedrooms { get; set; }

		[Required(ErrorMessage = "Number of Bathrooms is required!")]
		[Display(Name = "Number of Bathrooms:")]
		public int Bathrooms { get; set; }

		[Required(ErrorMessage = "Number of Guests is required!")]
		[Display(Name = "Number of Guests:")]
		public int GuestsAllowed { get; set; }

		[Required(ErrorMessage = "This field is required!")]
		[Display(Name = "Pets Allowed:")]
		public bool PetsAllowed { get; set; }

		[Required(ErrorMessage = "This field is required!")]
		[Display(Name = "Free Parking Included:")]
		public bool ParkingFree { get; set; }

		[Required(ErrorMessage = "Cleaning Fee is required!")]
		[Display(Name = "Cleaning Fee:")]
		[DisplayFormat(DataFormatString = "{0:c}")]
		public Decimal CleaningFee { get; set; }

		public bool Status { get; set; }

		public List<Review> Reviews { get; set; }

		public List<Reservation> Reservations { get; set; }

		public Category Category { get; set; }

		public AppUser User { get; set; }

		public Property()
		{
			if (Reviews == null)
			{
				Reviews = new List<Review>();
			}
			if (Reservations == null)
			{
				Reservations = new List<Reservation>();
			}

		}

		internal static void Add(Property p1)
		{
			throw new NotImplementedException();
		}
	}


}