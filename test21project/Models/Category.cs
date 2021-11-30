using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace test21project.Models
{
	public class Category
	{
		public Int32 CategoryID { get; set; }

		[Required(ErrorMessage = "Property Category is required!")]
		[Display(Name = "Property Category:")]
		public String CategoryType { get; set; }

		public List<Property> Properties { get; set; }

		public Category()
        {
			if (Properties == null)
            {
				Properties = new List<Property>();
            }
        }

        internal static void Add(Category c1)
        {
            throw new NotImplementedException();
        }
    }
}