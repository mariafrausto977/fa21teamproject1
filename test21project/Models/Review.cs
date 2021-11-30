using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace test21project.Models
{
    public class Review
    {
        public Int32 ReviewID { get; set; }

        [Display(Name = "Individual Rating")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Required(ErrorMessage = "Review Rating is required!")]
        public int IndividualRating { get; set; }

        [Display(Name = "Review:")]
        public String ReviewText { get; set; }

        [Display(Name = "Dispute Review")]
        public String DisputeReview { get; set; }

        public Property Property { get; set; }
        public AppUser User { get; set; }

    }
}