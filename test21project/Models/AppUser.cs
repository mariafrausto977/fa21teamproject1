using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace test21project.Models
{
    public class AppUser:IdentityUser
    {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First Name is required!")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last Name is required!")]
        public String LastName { get; set; }

        [Display(Name = "Middle Initial:")]
        public String MI { get; set; }

        [Display(Name = "Birthday:")]
        [Required(ErrorMessage = "Birthday is required!")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Street Address:")]
        [Required(ErrorMessage = "Street Address is required!")]
        public String Address { get; set; }

        [Display(Name = "Zip Code:")]
        [Required(ErrorMessage = "ZIP Code is required!")]
        public String ZipCode { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid!")]
        public override String Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required!")]
        [Display(Name = "PhoneNumber:")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Phone Number is not valid!")]
        public override String PhoneNumber { get; set; }

        [Display(Name = "User Status:")]
        [Required(ErrorMessage = "User Status is required!")]
        public bool IsActive { get; set; }

        public List<Checkout> Checkouts { get; set; }

        public List<Property> Properties { get; set; }

        public List<Review> Reviews { get; set; }

        public AppUser()
        {
            if (Checkouts == null)
            {
                Checkouts = new List<Checkout>();
            }

            if (Properties == null)
            {
                Properties = new List<Property>();
            }

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }
        }
    }
}
