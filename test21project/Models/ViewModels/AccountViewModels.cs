using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace test21project.Models
{ 
    //NOTE: This is the view model used to allow the user to login
    //The user only needs teh email and password to login
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //NOTE: This is the view model used to register a user
    //When the user registers, they only need to specify the
    //properties listed in this model
    public class RegisterViewModel
    {   
        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name:")]
        public String FirstName { get; set; }

        [Display(Name = "Middle Initial:")]
        public String MI { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name:")]
        public String LastName { get; set; }

        [Display(Name = "Birthday:")]
        [Required(ErrorMessage = "Birthday is required!")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Phone Number is required!")]
        [Phone]
        [Display(Name = "Phone Number:")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress]
        [Display(Name = "Email:")]
        public string Email { get; set; }

        [Display(Name = "Street Address:")]
        [Required(ErrorMessage = "Street Address is required!")]
        public String Address { get; set; }

        [Display(Name = "Zip Code:")]
        [Required(ErrorMessage = "ZIP Code is required!")]
        public String ZipCode { get; set; }

        //NOTE: Here is the logic for putting in a password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    //NOTE: This is the view model used to allow the user to 
    //change their password
    public class UpdateProfileViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }   

    //NOTE: This is the view model used to display basic user information
    //on the index page
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String UserID { get; set; }
    }
}
