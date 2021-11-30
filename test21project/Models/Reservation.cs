using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace test21project.Models
{
    public class Reservation
    {
        private const Decimal TAX_RATE = 0.0825m;
        public Int32 ReservationID { get; set; }

        [Display(Name = "Reservation Check-In Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy} hh:mm")]
        public DateTime ReservationCheckIn { get; set; }

        [Display(Name = "Reservation Check-Out Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy} hh:mm")]
        public DateTime ReservationCheckOut { get; set; }

        [Display(Name = "Weekend Price:")]
        public Decimal WeekendPrice { get; set; }

        [Display(Name = "Weekday Price:")]
        public Decimal WeekdayPrice { get; set; }

        [Display(Name = "Reservation Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ReservationSubtotal { get; set; }

        [Display(Name = "Taxes")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Taxes
        {
            get { return ReservationSubtotal * TAX_RATE;  }
        }

        [Display(Name = "Individual Reservation Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal IndividualTotal { get; set; }

        public Property Property { get; set; }
        public Checkout Checkout { get; set; }
    }
}