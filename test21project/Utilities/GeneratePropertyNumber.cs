using test21project.DAL;
using System;
using System.Linq;

namespace test21project.Utilities
{
    public static class GeneratePropertyNumber
    {
        public static Int32 GetNextPropertyNumber (AppDbContext _context)
        {
            //Set a number where the Property IDs should start
            const Int32 START_NUMBER = 3000;

            Int32 intMaxPropertyID; //the current maximum Property ID
            Int32 intNextPropertyID; //the Property ID for the next Property

            if (_context.Properties.Count() == 0) //there are no properties in the database yet
            {
                intMaxPropertyID = START_NUMBER; //course numbers start at 3001
            }
            else
            {
                intMaxPropertyID = _context.Properties.Max(p => p.PropertyID); //this is the highest ID number in the database right now
            }

            //You added properties before you realized that you needed this code
            //and now you have some property IDs less than 3000
            if (intMaxPropertyID < START_NUMBER)
            {
                intMaxPropertyID = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextPropertyID = intMaxPropertyID + 1;

            //return the value
            return intNextPropertyID;
        }

    }
}