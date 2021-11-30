using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using test21project.Models;
using test21project.Utilities;
using test21project.DAL;
using System.Threading.Tasks;
using System.Linq;

namespace test21project.Seeding
{
    public static class SeedCategories
    {
        public static void SeedAllCategories(AppDbContext db)
        {

            if (db.Categories.Count() == 5)
            {
                //exit the program - we don't need to do any of this
                NotSupportedException ex = new NotSupportedException("Category record is already 5!");
                throw ex;
            }
            Int32 intCategoriesAdded = 0;
            try
            {
                //Create a list of languages
                List<Category> Categories = new List<Category>();

                Category c1 = new Category() { CategoryType = "House" };
                Categories.Add(c1);

                Category c2 = new Category() { CategoryType = "Cabin" };
                Categories.Add(c2);

                Category c3 = new Category() { CategoryType = "Apartment" };
                Categories.Add(c3);

                Category c4 = new Category() { CategoryType = "Condo" };
                Categories.Add(c4);

                Category c5 = new Category() { CategoryType = "Hotel Room" };
                Categories.Add(c5);

                foreach (Category categoryToAdd in Categories)
                {
                    Category dbCategory = db.Categories.FirstOrDefault(c => c.CategoryType == categoryToAdd.CategoryType);
                    if (dbCategory == null)
                    {
                        db.Categories.Add(categoryToAdd);
                        db.SaveChanges();
                        intCategoriesAdded += 1;
                    }
                }
            }
            catch
            {
                String msg = "Categories Added: " + intCategoriesAdded.ToString();
                throw new InvalidOperationException(msg);
            }
        }
    }
}