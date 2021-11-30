using test21project.DAL;
using System;
using System.Linq;

namespace test21project.Utilities
{
    public static class GenerateConfirmationNumber
    {
        public static Int32 GetNextConfirmationNumber(AppDbContext _context)
        {
            //Set a number where the Confirmation Numbers should start
            const Int32 START_NUMBER = 21900;

            Int32 intMaxConNum; //the current maximum Confirmation Number
            Int32 intNextConNum; //the Confirmation Number for the next Checkout

            if (_context.Checkouts.Count() == 0) //there are no properties in the database yet
            {
                intMaxConNum = START_NUMBER; //course numbers start at 3001
            }
            else
            {
                intMaxConNum = _context.Checkouts.Max(c => c.CheckoutID); //this is the highest Confirmation Number in the database right now
            }

            //You added checkouts before you realized that you needed this code
            //and now you have some checkout IDs less than 3000
            if (intMaxConNum < START_NUMBER)
            {
                intMaxConNum = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextConNum = intMaxConNum+ 1;

            //return the value
            return intNextConNum;
        }
    }
}