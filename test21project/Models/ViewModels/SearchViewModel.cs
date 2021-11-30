using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace test21project.Models
{
    public class SearchViewModel
    {
        [Key]

        [Display(Name = "City:")]
        public String SearchCity { get; set; }

        [Display(Name = "State:")]
        public States? SearchState { get; set; }

        [Display(Name = "Guest Ratings:")]
        [Range(minimum: 1.0, maximum: 5.0, ErrorMessage = "Rating must be between 1 and 5")]
        public Decimal? SearchAvgRating { get; set; }

        [Display(Name = "Number of Guests:")]
        [Range(minimum: 1, maximum: Int32.MaxValue, ErrorMessage = "Number of Guests must be greater than or equal to 1")]
        public Int32? SearchGuestsAllowed { get; set; }

        [Display(Name = "Minimum Weekday Price:")]
        [Range(minimum: 0.0, maximum: double.MaxValue, ErrorMessage = "Minimum Weekday Price must be greater than or equal to 0")]
        public Decimal? SearchMinWeekdayPrice { get; set; }

        [Display(Name = "Maximum Weekday Price:")]
        [Range(minimum: 0.0, maximum: double.MaxValue, ErrorMessage = "Maximum Weekday Price must be greater than or equal to 0")]
        public Decimal? SearchMaxWeekdayPrice { get; set; }

        [Display(Name = "Minimum Weekend Price:")]
        [Range(minimum: 0.0, maximum: double.MaxValue, ErrorMessage = "Minimum Weekend Price must be greater than or equal to 0")]
        public Decimal? SearchMinWeekendPrice { get; set; }

        [Display(Name = "Maximum Weekend Price:")]
        [Range(minimum: 0.0, maximum: double.MaxValue, ErrorMessage = "Maximum Weekend Price must be greater than or equal to 0")]
        public Decimal? SearchMaxWeekendPrice { get; set; }

        [Display(Name = "Category:")]
        public Category? SearchCategory { get; set; }

        [Display(Name = "Number Bedrooms:")]
        [Range(minimum: 1, maximum: Int32.MaxValue, ErrorMessage = "Number of Bedrooms must be greater than or equal to 1")]
        public Int32? SearchBedrooms { get; set; }

        [Display(Name = "Number of Bathrooms:")]
        [Range(minimum: 1, maximum: Int32.MaxValue, ErrorMessage = "Number of Bathrooms must be greater than or equal to 1")]
        public Int32? SearchBathrooms { get; set; }

        [Display(Name = "Pets Allowed:")]
        public bool? SearchPetsAllowed { get; set; }

        [Display(Name = "Free Parking:")]
        public bool? SearchParkingFree { get; set; }

        [Display(Name = "Start Date:")]
        [DataType(DataType.Date)]
        public DateTime? SearchStartDate { get; set; }

        [Display(Name = "End Date:")]
        [DataType(DataType.Date)]
        public DateTime? SearchEndDate { get; set; }
    }
}