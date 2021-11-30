using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test21project.Models
{
    public enum Status { Pending, Confirmed, Cancelled }
    public class Checkout
    {
        public Int32 CheckoutID { get; set; }

        [Display(Name = "Checkout Number")]
        public Int32 CheckoutNumber { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start date is required!")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy} hh:mm")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End date is required!")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy} hh:mm")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Checkout Status")]
        public Status CheckoutStatus { get; set; }

        [Display(Name = "Grand Total")]
        public Decimal GrandTotal
        {
            get { return Reservations.Sum(rd => rd.IndividualTotal); }
        }

        public List<Reservation> Reservations { get; set; }
        public AppUser User { get; set; }

        public Checkout()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }

        }
    }
}