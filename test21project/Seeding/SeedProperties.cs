using test21project.Models;
using test21project.DAL;
using System.Collections.Generic;
using System;
using System.Linq;


namespace test21project.Seeding
{
    public static class SeedProperties
    {
        public static void SeedAllProperties(AppDbContext db)
        {
            Int32 intPropertiesAdded = 0;
            //String strPropertyStreet = "Begin"; //helps to keep track of error on books
            int intPropertyID = 3000;
            List<Property> Properties = new List<Property>();

            try
            {


                Property p1 = new Property();

                p1.ZipCode = "72227";
                p1.State = States.PA;
                p1.Street = "8714 Mann Plaza";
                p1.City = "Lisaside";
                p1.HostEmail = "gonzalez@aol.com";
                p1.WeekendPrice = 171.57m;
                p1.WeekdayPrice = 152.68m;
                p1.PetsAllowed = false;
                p1.ParkingFree = false;
                p1.CleaningFee = 8.88m;
                p1.Bedrooms = 5;
                p1.Bathrooms = 6;
                p1.GuestsAllowed = 9;



                p1.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p1);







                Property p2 = new Property();

                p2.ZipCode = "5565";
                p2.State = States.FL;
                p2.Street = "96593 White View ";
                p2.UnitNumber = "Apt. 094";
                p2.City = "Jonesberg";
                p2.HostEmail = "gonzalez@aol.com";
                p2.WeekendPrice = 148.15m;
                p2.WeekdayPrice = 120.81m;
                p2.PetsAllowed = false;
                p2.ParkingFree = true;
                p2.CleaningFee = 8.02m;
                p2.Bedrooms = 7;
                p2.Bathrooms = 8;
                p2.GuestsAllowed = 8;



                p2.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p2);







                Property p3 = new Property();

                p3.ZipCode = "80819";
                p3.State = States.MD;
                p3.Street = "848 Melissa Springs ";
                p3.UnitNumber = "Suite 947";
                p3.City = "Kellerstad";
                p3.HostEmail = "rankin@yahoo.com";
                p3.WeekendPrice = 132.99m;
                p3.WeekdayPrice = 127.96m;
                p3.PetsAllowed = false;
                p3.ParkingFree = true;
                p3.CleaningFee = 13.37m;
                p3.Bedrooms = 5;
                p3.Bathrooms = 7;
                p3.GuestsAllowed = 8;



                p3.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p3);







                Property p4 = new Property();

                p4.ZipCode = "79428";
                p4.State = States.ND;
                p4.Street = "30413 Norton Isle ";
                p4.UnitNumber = "Suite 012";
                p4.City = "North Lisa";
                p4.HostEmail = "rankin@yahoo.com";
                p4.WeekendPrice = 185.35m;
                p4.WeekdayPrice = 80.2m;
                p4.PetsAllowed = true;
                p4.ParkingFree = true;
                p4.CleaningFee = 5.57m;
                p4.Bedrooms = 1;
                p4.Bathrooms = 3;
                p4.GuestsAllowed = 14;



                p4.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p4);







                Property p5 = new Property();

                p5.ZipCode = "63315";
                p5.State = States.DE;
                p5.Street = "39916 Mitchell Crescent";
                p5.City = "New Andrewburgh";
                p5.HostEmail = "loter@yahoo.com";
                p5.WeekendPrice = 100.37m;
                p5.WeekdayPrice = 170.25m;
                p5.PetsAllowed = true;
                p5.ParkingFree = true;
                p5.CleaningFee = 18.64m;
                p5.Bedrooms = 2;
                p5.Bathrooms = 3;
                p5.GuestsAllowed = 12;



                p5.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p5);







                Property p6 = new Property();

                p6.ZipCode = "24135";
                p6.State = States.NE;
                p6.Street = "086 Mary Cliff";
                p6.City = "North Deborah";
                p6.HostEmail = "rice@yahoo.com";
                p6.WeekendPrice = 162.6m;
                p6.WeekdayPrice = 220.24m;
                p6.PetsAllowed = false;
                p6.ParkingFree = true;
                p6.CleaningFee = 10.83m;
                p6.Bedrooms = 7;
                p6.Bathrooms = 9;
                p6.GuestsAllowed = 2;



                p6.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p6);







                Property p7 = new Property();

                p7.ZipCode = "58475";
                p7.State = States.PA;
                p7.Street = "91634 Strong Mountains ";
                p7.UnitNumber = "Apt. 302";
                p7.City = "West Alyssa";
                p7.HostEmail = "rice@yahoo.com";
                p7.WeekendPrice = 204.87m;
                p7.WeekdayPrice = 213.37m;
                p7.PetsAllowed = true;
                p7.ParkingFree = true;
                p7.CleaningFee = 25.04m;
                p7.Bedrooms = 1;
                p7.Bathrooms = 2;
                p7.GuestsAllowed = 9;



                p7.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p7);







                Property p8 = new Property();

                p8.ZipCode = "10865";
                p8.State = States.WA;
                p8.Street = "6984 Price Shoals";
                p8.City = "Erictown";
                p8.HostEmail = "tanner@utexas.edu";
                p8.WeekendPrice = 140.89m;
                p8.WeekdayPrice = 159.69m;
                p8.PetsAllowed = true;
                p8.ParkingFree = true;
                p8.CleaningFee = 27.13m;
                p8.Bedrooms = 2;
                p8.Bathrooms = 3;
                p8.GuestsAllowed = 8;



                p8.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p8);







                Property p9 = new Property();

                p9.ZipCode = "51359";
                p9.State = States.ME;
                p9.Street = "423 Bell Heights";
                p9.City = "Brittanyberg";
                p9.HostEmail = "rice@yahoo.com";
                p9.WeekendPrice = 295.39m;
                p9.WeekdayPrice = 200.73m;
                p9.PetsAllowed = false;
                p9.ParkingFree = true;
                p9.CleaningFee = 14.91m;
                p9.Bedrooms = 3;
                p9.Bathrooms = 3;
                p9.GuestsAllowed = 4;



                p9.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p9);







                Property p10 = new Property();

                p10.ZipCode = "87296";
                p10.State = States.WI;
                p10.Street = "93523 Dana Lane";
                p10.City = "Johnsonshire";
                p10.HostEmail = "ingram@gmail.com";
                p10.WeekendPrice = 110.8m;
                p10.WeekdayPrice = 170.39m;
                p10.PetsAllowed = false;
                p10.ParkingFree = false;
                p10.CleaningFee = 8.67m;
                p10.Bedrooms = 6;
                p10.Bathrooms = 6;
                p10.GuestsAllowed = 3;



                p10.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p10);







                Property p11 = new Property();

                p11.ZipCode = "7035";
                p11.State = States.NH;
                p11.Street = "1427 Odonnell Rapids";
                p11.City = "North Troyport";
                p11.HostEmail = "jacobs@yahoo.com";
                p11.WeekendPrice = 126.29m;
                p11.WeekdayPrice = 217.15m;
                p11.PetsAllowed = true;
                p11.ParkingFree = true;
                p11.CleaningFee = 26.48m;
                p11.Bedrooms = 3;
                p11.Bathrooms = 3;
                p11.GuestsAllowed = 14;



                p11.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p11);







                Property p12 = new Property();

                p12.ZipCode = "37198";
                p12.State = States.ME;
                p12.Street = "81206 Stewart Forest ";
                p12.UnitNumber = "Apt. 089";
                p12.City = "East Davidborough";
                p12.HostEmail = "martinez@aol.com";
                p12.WeekendPrice = 293.26m;
                p12.WeekdayPrice = 205.21m;
                p12.PetsAllowed = true;
                p12.ParkingFree = false;
                p12.CleaningFee = 28.74m;
                p12.Bedrooms = 3;
                p12.Bathrooms = 5;
                p12.GuestsAllowed = 8;



                p12.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p12);







                Property p13 = new Property();

                p13.ZipCode = "85034";
                p13.State = States.SD;
                p13.Street = "76104 Marsh Crescent";
                p13.City = "Dennishaven";
                p13.HostEmail = "chung@yahoo.com";
                p13.WeekendPrice = 126.99m;
                p13.WeekdayPrice = 123.13m;
                p13.PetsAllowed = false;
                p13.ParkingFree = true;
                p13.CleaningFee = 18.73m;
                p13.Bedrooms = 7;
                p13.Bathrooms = 7;
                p13.GuestsAllowed = 4;



                p13.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p13);







                Property p14 = new Property();

                p14.ZipCode = "60619";
                p14.State = States.SD;
                p14.Street = "0003 Grant Lakes";
                p14.City = "Port Karafort";
                p14.HostEmail = "jacobs@yahoo.com";
                p14.WeekendPrice = 188.81m;
                p14.WeekdayPrice = 89.19m;
                p14.PetsAllowed = false;
                p14.ParkingFree = true;
                p14.CleaningFee = 11.98m;
                p14.Bedrooms = 3;
                p14.Bathrooms = 5;
                p14.GuestsAllowed = 14;



                p14.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p14);







                Property p15 = new Property();

                p15.ZipCode = "21978";
                p15.State = States.KY;
                p15.Street = "236 Smith Drive ";
                p15.UnitNumber = "Suite 555";
                p15.City = "West Kimberlyton";
                p15.HostEmail = "jacobs@yahoo.com";
                p15.WeekendPrice = 132.96m;
                p15.WeekdayPrice = 198.3m;
                p15.PetsAllowed = true;
                p15.ParkingFree = true;
                p15.CleaningFee = 13.96m;
                p15.Bedrooms = 1;
                p15.Bathrooms = 3;
                p15.GuestsAllowed = 11;



                p15.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p15);







                Property p16 = new Property();

                p16.ZipCode = "14742";
                p16.State = States.MT;
                p16.Street = "6824 Timothy Garden";
                p16.UnitNumber = "Apt. 428";
                p16.City = "West Richardmouth";
                p16.HostEmail = "rankin@yahoo.com";
                p16.WeekendPrice = 297.31m;
                p16.WeekdayPrice = 181.5m;
                p16.PetsAllowed = false;
                p16.ParkingFree = false;
                p16.CleaningFee = 10.09m;
                p16.Bedrooms = 6;
                p16.Bathrooms = 6;
                p16.GuestsAllowed = 10;



                p16.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p16);







                Property p17 = new Property();

                p17.ZipCode = "11894";
                p17.State = States.SC;
                p17.Street = "5517 Holly Meadow ";
                p17.UnitNumber = "Apt. 452";
                p17.City = "Lake Anne";
                p17.HostEmail = "gonzalez@aol.com";
                p17.WeekendPrice = 139.22m;
                p17.WeekdayPrice = 134.09m;
                p17.PetsAllowed = false;
                p17.ParkingFree = false;
                p17.CleaningFee = 9.75m;
                p17.Bedrooms = 1;
                p17.Bathrooms = 3;
                p17.GuestsAllowed = 1;



                p17.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p17);







                Property p18 = new Property();

                p18.ZipCode = "28976";
                p18.State = States.TX;
                p18.Street = "30601 Hawkins Highway";
                p18.City = "Morashire";
                p18.HostEmail = "martinez@aol.com";
                p18.WeekendPrice = 160.61m;
                p18.WeekdayPrice = 187.65m;
                p18.PetsAllowed = false;
                p18.ParkingFree = false;
                p18.CleaningFee = 7.5m;
                p18.Bedrooms = 6;
                p18.Bathrooms = 5;
                p18.GuestsAllowed = 9;



                p18.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p18);







                Property p19 = new Property();

                p19.ZipCode = "28798";
                p19.State = States.AZ;
                p19.Street = "49263 Wilson View ";
                p19.UnitNumber = "Apt. 873";
                p19.City = "South Raymondborough";
                p19.HostEmail = "loter@yahoo.com";
                p19.WeekendPrice = 133.25m;
                p19.WeekdayPrice = 206.95m;
                p19.PetsAllowed = false;
                p19.ParkingFree = false;
                p19.CleaningFee = 14.04m;
                p19.Bedrooms = 1;
                p19.Bathrooms = 3;
                p19.GuestsAllowed = 5;



                p19.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p19);







                Property p20 = new Property();

                p20.ZipCode = "68819";
                p20.State = States.NE;
                p20.Street = "76582 Vanessa Oval";
                p20.City = "New Richard";
                p20.HostEmail = "chung@yahoo.com";
                p20.WeekendPrice = 242.89m;
                p20.WeekdayPrice = 99.54m;
                p20.PetsAllowed = true;
                p20.ParkingFree = false;
                p20.CleaningFee = 6.61m;
                p20.Bedrooms = 5;
                p20.Bathrooms = 4;
                p20.GuestsAllowed = 12;



                p20.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p20);







                Property p21 = new Property();

                p21.ZipCode = "50177";
                p21.State = States.FL;
                p21.Street = "7389 Alec Squares ";
                p21.UnitNumber = "Suite 508";
                p21.City = "Port Jonathan";
                p21.HostEmail = "loter@yahoo.com";
                p21.WeekendPrice = 165.32m;
                p21.WeekdayPrice = 112.62m;
                p21.PetsAllowed = true;
                p21.ParkingFree = true;
                p21.CleaningFee = 24.26m;
                p21.Bedrooms = 7;
                p21.Bathrooms = 7;
                p21.GuestsAllowed = 12;



                p21.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p21);







                Property p22 = new Property();

                p22.ZipCode = "66355";
                p22.State = States.NC;
                p22.Street = "18013 Billy Bridge ";
                p22.UnitNumber = "Suite 522";
                p22.City = "Schmitthaven";
                p22.HostEmail = "martinez@aol.com";
                p22.WeekendPrice = 119.02m;
                p22.WeekdayPrice = 199.21m;
                p22.PetsAllowed = false;
                p22.ParkingFree = true;
                p22.CleaningFee = 11.63m;
                p22.Bedrooms = 3;
                p22.Bathrooms = 4;
                p22.GuestsAllowed = 2;



                p22.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room Room");
                Properties.Add(p22);







                Property p23 = new Property();

                p23.ZipCode = "51431";
                p23.State = States.NJ;
                p23.Street = "891 Bullock Ford";
                p23.City = "Amandachester";
                p23.HostEmail = "gonzalez@aol.com";
                p23.WeekendPrice = 244.93m;
                p23.WeekdayPrice = 179.05m;
                p23.PetsAllowed = false;
                p23.ParkingFree = false;
                p23.CleaningFee = 21.78m;
                p23.Bedrooms = 5;
                p23.Bathrooms = 6;
                p23.GuestsAllowed = 11;



                p23.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p23);







                Property p24 = new Property();

                p24.ZipCode = "50853";
                p24.State = States.MT;
                p24.Street = "02489 Cook Park";
                p24.City = "Sherriport";
                p24.HostEmail = "chung@yahoo.com";
                p24.WeekendPrice = 227.35m;
                p24.WeekdayPrice = 207.24m;
                p24.PetsAllowed = false;
                p24.ParkingFree = true;
                p24.CleaningFee = 5.5m;
                p24.Bedrooms = 4;
                p24.Bathrooms = 3;
                p24.GuestsAllowed = 6;



                p24.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p24);







                Property p25 = new Property();

                p25.ZipCode = "20341";
                p25.State = States.UT;
                p25.Street = "23450 Timothy Divide";
                p25.City = "Wuland";
                p25.HostEmail = "jacobs@yahoo.com";
                p25.WeekendPrice = 278.36m;
                p25.WeekdayPrice = 116.01m;
                p25.PetsAllowed = false;
                p25.ParkingFree = true;
                p25.CleaningFee = 24.73m;
                p25.Bedrooms = 3;
                p25.Bathrooms = 4;
                p25.GuestsAllowed = 11;



                p25.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p25);







                Property p26 = new Property();

                p26.ZipCode = "85565";
                p26.State = States.OH;
                p26.Street = "0976 Williams Mountains ";
                p26.UnitNumber = "Apt. 009";
                p26.City = "Lake Mario";
                p26.HostEmail = "chung@yahoo.com";
                p26.WeekendPrice = 293.42m;
                p26.WeekdayPrice = 225.14m;
                p26.PetsAllowed = true;
                p26.ParkingFree = true;
                p26.CleaningFee = 10.42m;
                p26.Bedrooms = 6;
                p26.Bathrooms = 7;
                p26.GuestsAllowed = 7;



                p26.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p26);







                Property p27 = new Property();

                p27.ZipCode = "51884";
                p27.State = States.WY;
                p27.Street = "1097 Santos Springs ";
                p27.UnitNumber = "Suite 264";
                p27.City = "New Michelleborough";
                p27.HostEmail = "loter@yahoo.com";
                p27.WeekendPrice = 126.45m;
                p27.WeekdayPrice = 70.24m;
                p27.PetsAllowed = false;
                p27.ParkingFree = true;
                p27.CleaningFee = 18.69m;
                p27.Bedrooms = 2;
                p27.Bathrooms = 2;
                p27.GuestsAllowed = 4;



                p27.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p27);







                Property p28 = new Property();

                p28.ZipCode = "66353";
                p28.State = States.SC;
                p28.Street = "5100 Scott Burg";
                p28.City = "East Clayton";
                p28.HostEmail = "morales@aol.com";
                p28.WeekendPrice = 224.07m;
                p28.WeekdayPrice = 186.38m;
                p28.PetsAllowed = false;
                p28.ParkingFree = false;
                p28.CleaningFee = 28.24m;
                p28.Bedrooms = 4;
                p28.Bathrooms = 3;
                p28.GuestsAllowed = 3;



                p28.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p28);







                Property p29 = new Property();

                p29.ZipCode = "57004";
                p29.State = States.NV;
                p29.Street = "412 Snow Manors";
                p29.UnitNumber = "Apt. 161";
                p29.City = "South Kimtown";
                p29.HostEmail = "morales@aol.com";
                p29.WeekendPrice = 120.93m;
                p29.WeekdayPrice = 112.47m;
                p29.PetsAllowed = true;
                p29.ParkingFree = false;
                p29.CleaningFee = 23.28m;
                p29.Bedrooms = 5;
                p29.Bathrooms = 7;
                p29.GuestsAllowed = 9;



                p29.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p29);







                Property p30 = new Property();

                p30.ZipCode = "48447";
                p30.State = States.IN;
                p30.Street = "5415 David Square";
                p30.City = "West Michaeltown";
                p30.HostEmail = "gonzalez@aol.com";
                p30.WeekendPrice = 100.02m;
                p30.WeekdayPrice = 214.81m;
                p30.PetsAllowed = false;
                p30.ParkingFree = false;
                p30.CleaningFee = 17.78m;
                p30.Bedrooms = 7;
                p30.Bathrooms = 9;
                p30.GuestsAllowed = 1;



                p30.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p30);







                Property p31 = new Property();

                p31.ZipCode = "62982";
                p31.State = States.DE;
                p31.Street = "03104 Norris Rapids";
                p31.City = "Port Donald";
                p31.HostEmail = "loter@yahoo.com";
                p31.WeekendPrice = 161.6m;
                p31.WeekdayPrice = 159.87m;
                p31.PetsAllowed = true;
                p31.ParkingFree = true;
                p31.CleaningFee = 10.34m;
                p31.Bedrooms = 1;
                p31.Bathrooms = 2;
                p31.GuestsAllowed = 11;



                p31.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p31);







                Property p32 = new Property();

                p32.ZipCode = "16915";
                p32.State = States.FL;
                p32.Street = "03557 Phillips Wells";
                p32.UnitNumber = "Suite 291";
                p32.City = "New Beverlyburgh";
                p32.HostEmail = "loter@yahoo.com";
                p32.WeekendPrice = 203.6m;
                p32.WeekdayPrice = 70.55m;
                p32.PetsAllowed = false;
                p32.ParkingFree = true;
                p32.CleaningFee = 5.09m;
                p32.Bedrooms = 7;
                p32.Bathrooms = 6;
                p32.GuestsAllowed = 4;



                p32.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p32);







                Property p33 = new Property();

                p33.ZipCode = "39742";
                p33.State = States.MT;
                p33.Street = "332 Watson Shore";
                p33.UnitNumber = "Apt. 290";
                p33.City = "Millerland";
                p33.HostEmail = "rice@yahoo.com";
                p33.WeekendPrice = 299.34m;
                p33.WeekdayPrice = 176.37m;
                p33.PetsAllowed = false;
                p33.ParkingFree = true;
                p33.CleaningFee = 17.38m;
                p33.Bedrooms = 3;
                p33.Bathrooms = 3;
                p33.GuestsAllowed = 2;



                p33.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p33);







                Property p34 = new Property();

                p34.ZipCode = "54060";
                p34.State = States.MS;
                p34.Street = "645 John Roads";
                p34.City = "Danahaven";
                p34.HostEmail = "morales@aol.com";
                p34.WeekendPrice = 229.98m;
                p34.WeekdayPrice = 172.83m;
                p34.PetsAllowed = false;
                p34.ParkingFree = false;
                p34.CleaningFee = 23.55m;
                p34.Bedrooms = 7;
                p34.Bathrooms = 6;
                p34.GuestsAllowed = 14;



                p34.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p34);







                Property p35 = new Property();

                p35.ZipCode = "55774";
                p35.State = States.HI;
                p35.Street = "3547 Stephanie Underpass";
                p35.UnitNumber = "Apt. 418";
                p35.City = "Port Jacqueline";
                p35.HostEmail = "tanner@utexas.edu";
                p35.WeekendPrice = 143.71m;
                p35.WeekdayPrice = 177.08m;
                p35.PetsAllowed = true;
                p35.ParkingFree = true;
                p35.CleaningFee = 19.21m;
                p35.Bedrooms = 1;
                p35.Bathrooms = 1;
                p35.GuestsAllowed = 5;



                p35.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p35);







                Property p36 = new Property();

                p36.ZipCode = "59363";
                p36.State = States.UT;
                p36.Street = "5825 Welch Corners";
                p36.City = "Fischerport";
                p36.HostEmail = "jacobs@yahoo.com";
                p36.WeekendPrice = 113.86m;
                p36.WeekdayPrice = 76.66m;
                p36.PetsAllowed = true;
                p36.ParkingFree = false;
                p36.CleaningFee = 27.87m;
                p36.Bedrooms = 3;
                p36.Bathrooms = 4;
                p36.GuestsAllowed = 10;



                p36.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p36);







                Property p37 = new Property();

                p37.ZipCode = "71770";
                p37.State = States.IN;
                p37.Street = "41489 Roger Terrace";
                p37.City = "Davisfort";
                p37.HostEmail = "jacobs@yahoo.com";
                p37.WeekendPrice = 299.09m;
                p37.WeekdayPrice = 177.37m;
                p37.PetsAllowed = true;
                p37.ParkingFree = true;
                p37.CleaningFee = 23.78m;
                p37.Bedrooms = 6;
                p37.Bathrooms = 8;
                p37.GuestsAllowed = 6;



                p37.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p37);







                Property p38 = new Property();

                p38.ZipCode = "5147";
                p38.State = States.CO;
                p38.Street = "014 Aaron Locks";
                p38.UnitNumber = "Suite 714";
                p38.City = "Justinborough";
                p38.HostEmail = "rankin@yahoo.com";
                p38.WeekendPrice = 158.42m;
                p38.WeekdayPrice = 104.05m;
                p38.PetsAllowed = true;
                p38.ParkingFree = false;
                p38.CleaningFee = 5.36m;
                p38.Bedrooms = 2;
                p38.Bathrooms = 2;
                p38.GuestsAllowed = 5;



                p38.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p38);







                Property p39 = new Property();

                p39.ZipCode = "28062";
                p39.State = States.SC;
                p39.Street = "8518 Pamela Track";
                p39.UnitNumber = "Apt. 164";
                p39.City = "Aprilshire";
                p39.HostEmail = "chung@yahoo.com";
                p39.WeekendPrice = 210.59m;
                p39.WeekdayPrice = 199.37m;
                p39.PetsAllowed = false;
                p39.ParkingFree = true;
                p39.CleaningFee = 8.83m;
                p39.Bedrooms = 3;
                p39.Bathrooms = 2;
                p39.GuestsAllowed = 1;



                p39.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p39);







                Property p40 = new Property();

                p40.ZipCode = "88090";
                p40.State = States.OH;
                p40.Street = "864 Ramos Port";
                p40.UnitNumber = "Apt. 211";
                p40.City = "Moralesmouth";
                p40.HostEmail = "tanner@utexas.edu";
                p40.WeekendPrice = 153.69m;
                p40.WeekdayPrice = 94.48m;
                p40.PetsAllowed = true;
                p40.ParkingFree = true;
                p40.CleaningFee = 16.85m;
                p40.Bedrooms = 3;
                p40.Bathrooms = 5;
                p40.GuestsAllowed = 9;



                p40.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p40);







                Property p41 = new Property();

                p41.ZipCode = "28775";
                p41.State = States.RI;
                p41.Street = "637 Neal Island";
                p41.UnitNumber = "Suite 074";
                p41.City = "Lake Tyler";
                p41.HostEmail = "ingram@gmail.com";
                p41.WeekendPrice = 196.14m;
                p41.WeekdayPrice = 88.82m;
                p41.PetsAllowed = true;
                p41.ParkingFree = false;
                p41.CleaningFee = 6.97m;
                p41.Bedrooms = 3;
                p41.Bathrooms = 3;
                p41.GuestsAllowed = 14;



                p41.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p41);







                Property p42 = new Property();

                p42.ZipCode = "75585";
                p42.State = States.WV;
                p42.Street = "0811 Smith Canyon";
                p42.UnitNumber = "Apt. 904";
                p42.City = "Jessicabury";
                p42.HostEmail = "rankin@yahoo.com";
                p42.WeekendPrice = 123.22m;
                p42.WeekdayPrice = 119.58m;
                p42.PetsAllowed = false;
                p42.ParkingFree = true;
                p42.CleaningFee = 18.45m;
                p42.Bedrooms = 3;
                p42.Bathrooms = 5;
                p42.GuestsAllowed = 2;



                p42.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p42);







                Property p43 = new Property();

                p43.ZipCode = "17438";
                p43.State = States.MD;
                p43.Street = "7562 Fisher Spur";
                p43.City = "Hernandezberg";
                p43.HostEmail = "rice@yahoo.com";
                p43.WeekendPrice = 283.77m;
                p43.WeekdayPrice = 218.87m;
                p43.PetsAllowed = false;
                p43.ParkingFree = false;
                p43.CleaningFee = 19.07m;
                p43.Bedrooms = 1;
                p43.Bathrooms = 2;
                p43.GuestsAllowed = 2;



                p43.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p43);







                Property p44 = new Property();

                p44.ZipCode = "7027";
                p44.State = States.VT;
                p44.Street = "5667 Blair Underpass";
                p44.City = "South Shelby";
                p44.HostEmail = "morales@aol.com";
                p44.WeekendPrice = 239.76m;
                p44.WeekdayPrice = 76.19m;
                p44.PetsAllowed = false;
                p44.ParkingFree = true;
                p44.CleaningFee = 11.37m;
                p44.Bedrooms = 2;
                p44.Bathrooms = 4;
                p44.GuestsAllowed = 13;



                p44.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p44);







                Property p45 = new Property();

                p45.ZipCode = "1008";
                p45.State = States.MI;
                p45.Street = "6708 Carpenter Overpass";
                p45.UnitNumber = "Suite 735";
                p45.City = "Bobbyton";
                p45.HostEmail = "rice@yahoo.com";
                p45.WeekendPrice = 229.04m;
                p45.WeekdayPrice = 161.17m;
                p45.PetsAllowed = false;
                p45.ParkingFree = false;
                p45.CleaningFee = 25.01m;
                p45.Bedrooms = 7;
                p45.Bathrooms = 7;
                p45.GuestsAllowed = 7;



                p45.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p45);







                Property p46 = new Property();

                p46.ZipCode = "60236";
                p46.State = States.ND;
                p46.Street = "16396 Shawn Junction";
                p46.City = "New Nicolemouth";
                p46.HostEmail = "rice@yahoo.com";
                p46.WeekendPrice = 220.69m;
                p46.WeekdayPrice = 106.06m;
                p46.PetsAllowed = true;
                p46.ParkingFree = true;
                p46.CleaningFee = 11.82m;
                p46.Bedrooms = 4;
                p46.Bathrooms = 4;
                p46.GuestsAllowed = 6;



                p46.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p46);







                Property p47 = new Property();

                p47.ZipCode = "1707";
                p47.State = States.CA;
                p47.Street = "4486 Olson Well";
                p47.City = "North Kevin";
                p47.HostEmail = "martinez@aol.com";
                p47.WeekendPrice = 138.96m;
                p47.WeekdayPrice = 151.44m;
                p47.PetsAllowed = false;
                p47.ParkingFree = false;
                p47.CleaningFee = 6.72m;
                p47.Bedrooms = 7;
                p47.Bathrooms = 7;
                p47.GuestsAllowed = 10;



                p47.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p47);







                Property p48 = new Property();

                p48.ZipCode = "33233";
                p48.State = States.HI;
                p48.Street = "67771 Christopher Courts";
                p48.UnitNumber = "Apt. 637";
                p48.City = "Port Ronaldfurt";
                p48.HostEmail = "ingram@gmail.com";
                p48.WeekendPrice = 134.28m;
                p48.WeekdayPrice = 102.43m;
                p48.PetsAllowed = false;
                p48.ParkingFree = false;
                p48.CleaningFee = 19.81m;
                p48.Bedrooms = 5;
                p48.Bathrooms = 5;
                p48.GuestsAllowed = 2;



                p48.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p48);







                Property p49 = new Property();

                p49.ZipCode = "79756";
                p49.State = States.NY;
                p49.Street = "5561 Bishop Turnpike";
                p49.City = "Lake Kenneth";
                p49.HostEmail = "gonzalez@aol.com";
                p49.WeekendPrice = 259.87m;
                p49.WeekdayPrice = 94.31m;
                p49.PetsAllowed = true;
                p49.ParkingFree = true;
                p49.CleaningFee = 22.33m;
                p49.Bedrooms = 5;
                p49.Bathrooms = 7;
                p49.GuestsAllowed = 11;



                p49.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p49);







                Property p50 = new Property();

                p50.ZipCode = "36216";
                p50.State = States.SD;
                p50.Street = "3019 Gerald Mall";
                p50.UnitNumber = "Apt. 340";
                p50.City = "Trevinoville";
                p50.HostEmail = "chung@yahoo.com";
                p50.WeekendPrice = 263.32m;
                p50.WeekdayPrice = 151.69m;
                p50.PetsAllowed = true;
                p50.ParkingFree = true;
                p50.CleaningFee = 13.27m;
                p50.Bedrooms = 5;
                p50.Bathrooms = 5;
                p50.GuestsAllowed = 1;



                p50.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p50);







                Property p51 = new Property();

                p51.ZipCode = "43477";
                p51.State = States.NY;
                p51.Street = "84331 Leonard Fort";
                p51.UnitNumber = "Suite 749";
                p51.City = "East Lisa";
                p51.HostEmail = "chung@yahoo.com";
                p51.WeekendPrice = 204.28m;
                p51.WeekdayPrice = 204.04m;
                p51.PetsAllowed = false;
                p51.ParkingFree = true;
                p51.CleaningFee = 11.07m;
                p51.Bedrooms = 7;
                p51.Bathrooms = 8;
                p51.GuestsAllowed = 10;



                p51.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p51);







                Property p52 = new Property();

                p52.ZipCode = "17819";
                p52.State = States.VA;
                p52.Street = "62281 Kathy Tunnel";
                p52.City = "Hudsonborough";
                p52.HostEmail = "ingram@gmail.com";
                p52.WeekendPrice = 224.19m;
                p52.WeekdayPrice = 165.51m;
                p52.PetsAllowed = true;
                p52.ParkingFree = true;
                p52.CleaningFee = 24.26m;
                p52.Bedrooms = 1;
                p52.Bathrooms = 1;
                p52.GuestsAllowed = 9;



                p52.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p52);







                Property p53 = new Property();

                p53.ZipCode = "97149";
                p53.State = States.NM;
                p53.Street = "9927 Christina Burg";
                p53.UnitNumber = "Suite 774";
                p53.City = "East Angelaburgh";
                p53.HostEmail = "jacobs@yahoo.com";
                p53.WeekendPrice = 121.74m;
                p53.WeekdayPrice = 106.87m;
                p53.PetsAllowed = false;
                p53.ParkingFree = false;
                p53.CleaningFee = 5.62m;
                p53.Bedrooms = 7;
                p53.Bathrooms = 9;
                p53.GuestsAllowed = 6;



                p53.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p53);







                Property p54 = new Property();

                p54.ZipCode = "45480";
                p54.State = States.IA;
                p54.Street = "142 Warner View";
                p54.UnitNumber = "Suite 460";
                p54.City = "North Leslie";
                p54.HostEmail = "ingram@gmail.com";
                p54.WeekendPrice = 148.76m;
                p54.WeekdayPrice = 212.32m;
                p54.PetsAllowed = false;
                p54.ParkingFree = true;
                p54.CleaningFee = 20.2m;
                p54.Bedrooms = 5;
                p54.Bathrooms = 7;
                p54.GuestsAllowed = 9;



                p54.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p54);







                Property p55 = new Property();

                p55.ZipCode = "3720";
                p55.State = States.AR;
                p55.Street = "5240 Berry Centers";
                p55.City = "West Andrew";
                p55.HostEmail = "rankin@yahoo.com";
                p55.WeekendPrice = 111.01m;
                p55.WeekdayPrice = 164.02m;
                p55.PetsAllowed = true;
                p55.ParkingFree = true;
                p55.CleaningFee = 26.21m;
                p55.Bedrooms = 7;
                p55.Bathrooms = 6;
                p55.GuestsAllowed = 12;



                p55.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p55);







                Property p56 = new Property();

                p56.ZipCode = "85576";
                p56.State = States.HI;
                p56.Street = "51056 Patricia Forge";
                p56.City = "Grahamstad";
                p56.HostEmail = "loter@yahoo.com";
                p56.WeekendPrice = 167.53m;
                p56.WeekdayPrice = 117.45m;
                p56.PetsAllowed = true;
                p56.ParkingFree = true;
                p56.CleaningFee = 24.75m;
                p56.Bedrooms = 7;
                p56.Bathrooms = 9;
                p56.GuestsAllowed = 10;



                p56.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p56);







                Property p57 = new Property();

                p57.ZipCode = "92199";
                p57.State = States.VA;
                p57.Street = "0648 Malone Port";
                p57.UnitNumber = "Apt. 662";
                p57.City = "New Devonhaven";
                p57.HostEmail = "gonzalez@aol.com";
                p57.WeekendPrice = 176.53m;
                p57.WeekdayPrice = 209.47m;
                p57.PetsAllowed = true;
                p57.ParkingFree = true;
                p57.CleaningFee = 5.83m;
                p57.Bedrooms = 6;
                p57.Bathrooms = 5;
                p57.GuestsAllowed = 12;



                p57.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p57);







                Property p58 = new Property();

                p58.ZipCode = "5261";
                p58.State = States.SC;
                p58.Street = "23028 Jennifer Meadow";
                p58.UnitNumber = "Apt. 972";
                p58.City = "West Matthewfurt";
                p58.HostEmail = "ingram@gmail.com";
                p58.WeekendPrice = 199.1m;
                p58.WeekdayPrice = 153.04m;
                p58.PetsAllowed = true;
                p58.ParkingFree = false;
                p58.CleaningFee = 18.62m;
                p58.Bedrooms = 1;
                p58.Bathrooms = 2;
                p58.GuestsAllowed = 14;



                p58.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p58);







                Property p59 = new Property();

                p59.ZipCode = "72649";
                p59.State = States.LA;
                p59.Street = "2738 Martin Terrace";
                p59.UnitNumber = "Suite 547";
                p59.City = "Smithhaven";
                p59.HostEmail = "tanner@utexas.edu";
                p59.WeekendPrice = 199.22m;
                p59.WeekdayPrice = 196.56m;
                p59.PetsAllowed = false;
                p59.ParkingFree = true;
                p59.CleaningFee = 20.71m;
                p59.Bedrooms = 1;
                p59.Bathrooms = 1;
                p59.GuestsAllowed = 11;



                p59.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p59);







                Property p60 = new Property();

                p60.ZipCode = "97488";
                p60.State = States.KY;
                p60.Street = "984 Stephen Stravenue";
                p60.City = "South Michaelton";
                p60.HostEmail = "ingram@gmail.com";
                p60.WeekendPrice = 178.29m;
                p60.WeekdayPrice = 117.03m;
                p60.PetsAllowed = false;
                p60.ParkingFree = true;
                p60.CleaningFee = 6.47m;
                p60.Bedrooms = 4;
                p60.Bathrooms = 6;
                p60.GuestsAllowed = 3;



                p60.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p60);







                Property p61 = new Property();

                p61.ZipCode = "42837";
                p61.State = States.LA;
                p61.Street = "98522 Mathis Viaduct";
                p61.UnitNumber = "Apt. 909";
                p61.City = "West Michael";
                p61.HostEmail = "jacobs@yahoo.com";
                p61.WeekendPrice = 252.79m;
                p61.WeekdayPrice = 133.35m;
                p61.PetsAllowed = false;
                p61.ParkingFree = false;
                p61.CleaningFee = 9.15m;
                p61.Bedrooms = 4;
                p61.Bathrooms = 4;
                p61.GuestsAllowed = 1;



                p61.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p61);







                Property p62 = new Property();

                p62.ZipCode = "56059";
                p62.State = States.OH;
                p62.Street = "620 Ashley Mills";
                p62.UnitNumber = "Apt. 507";
                p62.City = "Julieborough";
                p62.HostEmail = "jacobs@yahoo.com";
                p62.WeekendPrice = 296.05m;
                p62.WeekdayPrice = 171.15m;
                p62.PetsAllowed = false;
                p62.ParkingFree = true;
                p62.CleaningFee = 18.26m;
                p62.Bedrooms = 1;
                p62.Bathrooms = 3;
                p62.GuestsAllowed = 9;



                p62.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p62);







                Property p63 = new Property();

                p63.ZipCode = "2288";
                p63.State = States.LA;
                p63.Street = "212 Shelly Roads";
                p63.City = "Fischerview";
                p63.HostEmail = "chung@yahoo.com";
                p63.WeekendPrice = 163.88m;
                p63.WeekdayPrice = 132.81m;
                p63.PetsAllowed = false;
                p63.ParkingFree = true;
                p63.CleaningFee = 7.46m;
                p63.Bedrooms = 5;
                p63.Bathrooms = 7;
                p63.GuestsAllowed = 10;



                p63.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p63);







                Property p64 = new Property();

                p64.ZipCode = "50851";
                p64.State = States.OK;
                p64.Street = "8885 Lee Tunnel";
                p64.UnitNumber = "Suite 208";
                p64.City = "Port Donna";
                p64.HostEmail = "chung@yahoo.com";
                p64.WeekendPrice = 140.73m;
                p64.WeekdayPrice = 228.84m;
                p64.PetsAllowed = true;
                p64.ParkingFree = true;
                p64.CleaningFee = 17.13m;
                p64.Bedrooms = 7;
                p64.Bathrooms = 7;
                p64.GuestsAllowed = 7;



                p64.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p64);







                Property p65 = new Property();

                p65.ZipCode = "3009";
                p65.State = States.NM;
                p65.Street = "693 Michael Estate";
                p65.City = "Lake Michael";
                p65.HostEmail = "tanner@utexas.edu";
                p65.WeekendPrice = 139.83m;
                p65.WeekdayPrice = 155.03m;
                p65.PetsAllowed = false;
                p65.ParkingFree = true;
                p65.CleaningFee = 21.05m;
                p65.Bedrooms = 4;
                p65.Bathrooms = 5;
                p65.GuestsAllowed = 13;



                p65.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p65);







                Property p66 = new Property();

                p66.ZipCode = "92905";
                p66.State = States.NY;
                p66.Street = "342 Miller Mission";
                p66.City = "Lake Jennifer";
                p66.HostEmail = "martinez@aol.com";
                p66.WeekendPrice = 249.24m;
                p66.WeekdayPrice = 128.41m;
                p66.PetsAllowed = true;
                p66.ParkingFree = false;
                p66.CleaningFee = 6.63m;
                p66.Bedrooms = 4;
                p66.Bathrooms = 5;
                p66.GuestsAllowed = 1;



                p66.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p66);







                Property p67 = new Property();

                p67.ZipCode = "65056";
                p67.State = States.AK;
                p67.Street = "71664 Kim Throughway";
                p67.City = "Chelsealand";
                p67.HostEmail = "rankin@yahoo.com";
                p67.WeekendPrice = 286.53m;
                p67.WeekdayPrice = 163.68m;
                p67.PetsAllowed = false;
                p67.ParkingFree = false;
                p67.CleaningFee = 25.57m;
                p67.Bedrooms = 6;
                p67.Bathrooms = 8;
                p67.GuestsAllowed = 9;



                p67.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p67);







                Property p68 = new Property();

                p68.ZipCode = "11181";
                p68.State = States.AZ;
                p68.Street = "66660 Gomez Port";
                p68.UnitNumber = "Apt. 945";
                p68.City = "South Thomashaven";
                p68.HostEmail = "tanner@utexas.edu";
                p68.WeekendPrice = 137.17m;
                p68.WeekdayPrice = 93.86m;
                p68.PetsAllowed = false;
                p68.ParkingFree = true;
                p68.CleaningFee = 28.18m;
                p68.Bedrooms = 4;
                p68.Bathrooms = 3;
                p68.GuestsAllowed = 2;



                p68.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p68);







                Property p69 = new Property();

                p69.ZipCode = "53480";
                p69.State = States.FL;
                p69.Street = "0131 Williams Ville";
                p69.UnitNumber = "Apt. 562";
                p69.City = "Richardberg";
                p69.HostEmail = "loter@yahoo.com";
                p69.WeekendPrice = 120.61m;
                p69.WeekdayPrice = 86.25m;
                p69.PetsAllowed = false;
                p69.ParkingFree = true;
                p69.CleaningFee = 11.39m;
                p69.Bedrooms = 6;
                p69.Bathrooms = 5;
                p69.GuestsAllowed = 13;



                p69.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p69);







                Property p70 = new Property();

                p70.ZipCode = "11353";
                p70.State = States.OR;
                p70.Street = "22708 Madison Spurs";
                p70.City = "Herringstad";
                p70.HostEmail = "morales@aol.com";
                p70.WeekendPrice = 241.25m;
                p70.WeekdayPrice = 182.46m;
                p70.PetsAllowed = false;
                p70.ParkingFree = false;
                p70.CleaningFee = 18.29m;
                p70.Bedrooms = 6;
                p70.Bathrooms = 7;
                p70.GuestsAllowed = 2;



                p70.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p70);







                Property p71 = new Property();

                p71.ZipCode = "5560";
                p71.State = States.FL;
                p71.Street = "3454 Holmes Motorway";
                p71.City = "Port Rachel";
                p71.HostEmail = "chung@yahoo.com";
                p71.WeekendPrice = 123.04m;
                p71.WeekdayPrice = 89.88m;
                p71.PetsAllowed = true;
                p71.ParkingFree = false;
                p71.CleaningFee = 19.14m;
                p71.Bedrooms = 3;
                p71.Bathrooms = 3;
                p71.GuestsAllowed = 1;



                p71.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p71);







                Property p72 = new Property();

                p72.ZipCode = "93500";
                p72.State = States.GA;
                p72.Street = "805 James Turnpike";
                p72.City = "Carrmouth";
                p72.HostEmail = "martinez@aol.com";
                p72.WeekendPrice = 219.86m;
                p72.WeekdayPrice = 81.55m;
                p72.PetsAllowed = false;
                p72.ParkingFree = false;
                p72.CleaningFee = 13.38m;
                p72.Bedrooms = 6;
                p72.Bathrooms = 5;
                p72.GuestsAllowed = 12;



                p72.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p72);







                Property p73 = new Property();

                p73.ZipCode = "44515";
                p73.State = States.NV;
                p73.Street = "8081 Smith Trail";
                p73.City = "North Ronaldstad";
                p73.HostEmail = "jacobs@yahoo.com";
                p73.WeekendPrice = 196.09m;
                p73.WeekdayPrice = 130.47m;
                p73.PetsAllowed = true;
                p73.ParkingFree = true;
                p73.CleaningFee = 14.53m;
                p73.Bedrooms = 7;
                p73.Bathrooms = 7;
                p73.GuestsAllowed = 3;



                p73.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p73);







                Property p74 = new Property();

                p74.ZipCode = "7347";
                p74.State = States.MS;
                p74.Street = "125 Ian Crossroad";
                p74.UnitNumber = "Apt. 593";
                p74.City = "South Deannaport";
                p74.HostEmail = "morales@aol.com";
                p74.WeekendPrice = 136.82m;
                p74.WeekdayPrice = 148.1m;
                p74.PetsAllowed = false;
                p74.ParkingFree = true;
                p74.CleaningFee = 15.57m;
                p74.Bedrooms = 2;
                p74.Bathrooms = 1;
                p74.GuestsAllowed = 4;



                p74.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p74);







                Property p75 = new Property();

                p75.ZipCode = "54532";
                p75.State = States.NH;
                p75.Street = "1607 Munoz River";
                p75.City = "Emilyshire";
                p75.HostEmail = "chung@yahoo.com";
                p75.WeekendPrice = 209.77m;
                p75.WeekdayPrice = 147.55m;
                p75.PetsAllowed = false;
                p75.ParkingFree = true;
                p75.CleaningFee = 27.65m;
                p75.Bedrooms = 6;
                p75.Bathrooms = 7;
                p75.GuestsAllowed = 3;



                p75.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p75);







                Property p76 = new Property();

                p76.ZipCode = "65516";
                p76.State = States.UT;
                p76.Street = "3615 David Keys";
                p76.UnitNumber = "Apt. 269";
                p76.City = "West Stephenside";
                p76.HostEmail = "gonzalez@aol.com";
                p76.WeekendPrice = 126.47m;
                p76.WeekdayPrice = 86.8m;
                p76.PetsAllowed = true;
                p76.ParkingFree = true;
                p76.CleaningFee = 17.6m;
                p76.Bedrooms = 2;
                p76.Bathrooms = 4;
                p76.GuestsAllowed = 3;



                p76.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p76);







                Property p77 = new Property();

                p77.ZipCode = "20721";
                p77.State = States.AZ;
                p77.Street = "640 Mary Common";
                p77.City = "Michaelville";
                p77.HostEmail = "ingram@gmail.com";
                p77.WeekendPrice = 173.01m;
                p77.WeekdayPrice = 121.75m;
                p77.PetsAllowed = false;
                p77.ParkingFree = true;
                p77.CleaningFee = 12.53m;
                p77.Bedrooms = 3;
                p77.Bathrooms = 4;
                p77.GuestsAllowed = 7;



                p77.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p77);







                Property p78 = new Property();

                p78.ZipCode = "43567";
                p78.State = States.LA;
                p78.Street = "395 Timothy Road";
                p78.City = "Williamsbury";
                p78.HostEmail = "loter@yahoo.com";
                p78.WeekendPrice = 198.1m;
                p78.WeekdayPrice = 160.23m;
                p78.PetsAllowed = true;
                p78.ParkingFree = true;
                p78.CleaningFee = 10.82m;
                p78.Bedrooms = 5;
                p78.Bathrooms = 7;
                p78.GuestsAllowed = 5;



                p78.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p78);







                Property p79 = new Property();

                p79.ZipCode = "1239";
                p79.State = States.OR;
                p79.Street = "3267 Walter Dam";
                p79.City = "Cunninghamtown";
                p79.HostEmail = "chung@yahoo.com";
                p79.WeekendPrice = 127.7m;
                p79.WeekdayPrice = 110.64m;
                p79.PetsAllowed = true;
                p79.ParkingFree = false;
                p79.CleaningFee = 26.67m;
                p79.Bedrooms = 1;
                p79.Bathrooms = 2;
                p79.GuestsAllowed = 7;



                p79.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p79);







                Property p80 = new Property();

                p80.ZipCode = "3966";
                p80.State = States.MS;
                p80.Street = "00580 Brandon Creek";
                p80.City = "Port Eric";
                p80.HostEmail = "jacobs@yahoo.com";
                p80.WeekendPrice = 236.71m;
                p80.WeekdayPrice = 227.6m;
                p80.PetsAllowed = false;
                p80.ParkingFree = false;
                p80.CleaningFee = 20.22m;
                p80.Bedrooms = 3;
                p80.Bathrooms = 5;
                p80.GuestsAllowed = 2;



                p80.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p80);







                Property p81 = new Property();

                p81.ZipCode = "29996";
                p81.State = States.MS;
                p81.Street = "325 Amanda Cliffs";
                p81.UnitNumber = "Apt. 695";
                p81.City = "South Paulabury";
                p81.HostEmail = "ingram@gmail.com";
                p81.WeekendPrice = 135.59m;
                p81.WeekdayPrice = 115.37m;
                p81.PetsAllowed = false;
                p81.ParkingFree = true;
                p81.CleaningFee = 29.8m;
                p81.Bedrooms = 6;
                p81.Bathrooms = 6;
                p81.GuestsAllowed = 13;



                p81.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p81);







                Property p82 = new Property();

                p82.ZipCode = "93980";
                p82.State = States.CT;
                p82.Street = "40956 Amanda Walk";
                p82.UnitNumber = "Apt. 260";
                p82.City = "Simonfurt";
                p82.HostEmail = "chung@yahoo.com";
                p82.WeekendPrice = 271.49m;
                p82.WeekdayPrice = 93.35m;
                p82.PetsAllowed = false;
                p82.ParkingFree = false;
                p82.CleaningFee = 8.54m;
                p82.Bedrooms = 4;
                p82.Bathrooms = 4;
                p82.GuestsAllowed = 5;



                p82.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p82);







                Property p83 = new Property();

                p83.ZipCode = "23687";
                p83.State = States.KS;
                p83.Street = "25762 Gill Creek";
                p83.UnitNumber = "Suite 525";
                p83.City = "Mccoyton";
                p83.HostEmail = "jacobs@yahoo.com";
                p83.WeekendPrice = 247.15m;
                p83.WeekdayPrice = 171.37m;
                p83.PetsAllowed = false;
                p83.ParkingFree = false;
                p83.CleaningFee = 17.22m;
                p83.Bedrooms = 1;
                p83.Bathrooms = 3;
                p83.GuestsAllowed = 5;



                p83.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p83);







                Property p84 = new Property();

                p84.ZipCode = "4593";
                p84.State = States.GA;
                p84.Street = "6048 Johnson Loop";
                p84.UnitNumber = "Suite 635";
                p84.City = "East Daniel";
                p84.HostEmail = "rankin@yahoo.com";
                p84.WeekendPrice = 299.6m;
                p84.WeekdayPrice = 95.59m;
                p84.PetsAllowed = true;
                p84.ParkingFree = true;
                p84.CleaningFee = 24.3m;
                p84.Bedrooms = 1;
                p84.Bathrooms = 3;
                p84.GuestsAllowed = 8;



                p84.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p84);







                Property p85 = new Property();

                p85.ZipCode = "96954";
                p85.State = States.RI;
                p85.Street = "1168 Gary Fords";
                p85.UnitNumber = "Apt. 308";
                p85.City = "Port Trevor";
                p85.HostEmail = "martinez@aol.com";
                p85.WeekendPrice = 278.17m;
                p85.WeekdayPrice = 194.84m;
                p85.PetsAllowed = false;
                p85.ParkingFree = false;
                p85.CleaningFee = 5.88m;
                p85.Bedrooms = 1;
                p85.Bathrooms = 2;
                p85.GuestsAllowed = 11;



                p85.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p85);







                Property p86 = new Property();

                p86.ZipCode = "62271";
                p86.State = States.MS;
                p86.Street = "164 Matthew Parkway";
                p86.UnitNumber = "Suite 826";
                p86.City = "Jimmyfurt";
                p86.HostEmail = "jacobs@yahoo.com";
                p86.WeekendPrice = 100.08m;
                p86.WeekdayPrice = 112.03m;
                p86.PetsAllowed = true;
                p86.ParkingFree = true;
                p86.CleaningFee = 28.82m;
                p86.Bedrooms = 6;
                p86.Bathrooms = 8;
                p86.GuestsAllowed = 8;



                p86.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p86);







                Property p87 = new Property();

                p87.ZipCode = "5222";
                p87.State = States.CO;
                p87.Street = "1220 Heidi Rue ";
                p87.UnitNumber = "Apt. 998";
                p87.City = "West Haleyburgh";
                p87.HostEmail = "rice@yahoo.com";
                p87.WeekendPrice = 182.77m;
                p87.WeekdayPrice = 127.97m;
                p87.PetsAllowed = false;
                p87.ParkingFree = true;
                p87.CleaningFee = 13.02m;
                p87.Bedrooms = 5;
                p87.Bathrooms = 4;
                p87.GuestsAllowed = 1;



                p87.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p87);







                Property p88 = new Property();

                p88.ZipCode = "22365";
                p88.State = States.SD;
                p88.Street = "751 Wood Square ";
                p88.UnitNumber = "Suite 732";
                p88.City = "Port Melissaburgh";
                p88.HostEmail = "rice@yahoo.com";
                p88.WeekendPrice = 186.01m;
                p88.WeekdayPrice = 120.07m;
                p88.PetsAllowed = false;
                p88.ParkingFree = false;
                p88.CleaningFee = 26.71m;
                p88.Bedrooms = 7;
                p88.Bathrooms = 7;
                p88.GuestsAllowed = 13;



                p88.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p88);







                Property p89 = new Property();

                p89.ZipCode = "53609";
                p89.State = States.OR;
                p89.Street = "376 Smith Dale ";
                p89.UnitNumber = "Suite 279";
                p89.City = "South Sarahland";
                p89.HostEmail = "ingram@gmail.com";
                p89.WeekendPrice = 122.31m;
                p89.WeekdayPrice = 137.96m;
                p89.PetsAllowed = false;
                p89.ParkingFree = false;
                p89.CleaningFee = 26.29m;
                p89.Bedrooms = 2;
                p89.Bathrooms = 2;
                p89.GuestsAllowed = 9;



                p89.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p89);







                Property p90 = new Property();

                p90.ZipCode = "9478";
                p90.State = States.CA;
                p90.Street = "79148 Pierce Lock ";
                p90.UnitNumber = "Suite 423";
                p90.City = "Erikberg";
                p90.HostEmail = "rice@yahoo.com";
                p90.WeekendPrice = 234.61m;
                p90.WeekdayPrice = 226.57m;
                p90.PetsAllowed = true;
                p90.ParkingFree = false;
                p90.CleaningFee = 16.41m;
                p90.Bedrooms = 3;
                p90.Bathrooms = 5;
                p90.GuestsAllowed = 6;



                p90.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p90);







                Property p91 = new Property();

                p91.ZipCode = "1425";
                p91.State = States.ID;
                p91.Street = "147 Lisa Hill ";
                p91.UnitNumber = "Apt. 512";
                p91.City = "Port Elizabethshire";
                p91.HostEmail = "gonzalez@aol.com";
                p91.WeekendPrice = 145.15m;
                p91.WeekdayPrice = 95.73m;
                p91.PetsAllowed = false;
                p91.ParkingFree = true;
                p91.CleaningFee = 9.93m;
                p91.Bedrooms = 4;
                p91.Bathrooms = 6;
                p91.GuestsAllowed = 10;



                p91.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p91);







                Property p92 = new Property();

                p92.ZipCode = "29941";
                p92.State = States.KY;
                p92.Street = "971 Hansen Well ";
                p92.UnitNumber = "Suite 103";
                p92.City = "South Mary";
                p92.HostEmail = "morales@aol.com";
                p92.WeekendPrice = 145.72m;
                p92.WeekdayPrice = 161.68m;
                p92.PetsAllowed = false;
                p92.ParkingFree = false;
                p92.CleaningFee = 24.36m;
                p92.Bedrooms = 6;
                p92.Bathrooms = 8;
                p92.GuestsAllowed = 4;



                p92.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p92);







                Property p93 = new Property();

                p93.ZipCode = "47577";
                p93.State = States.WY;
                p93.Street = "511 Berry Fork";
                p93.UnitNumber = "Suite 623";
                p93.City = "Sharonfort";
                p93.HostEmail = "morales@aol.com";
                p93.WeekendPrice = 260.18m;
                p93.WeekdayPrice = 183.81m;
                p93.PetsAllowed = false;
                p93.ParkingFree = false;
                p93.CleaningFee = 7.46m;
                p93.Bedrooms = 4;
                p93.Bathrooms = 5;
                p93.GuestsAllowed = 3;



                p93.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p93);







                Property p94 = new Property();

                p94.ZipCode = "94134";
                p94.State = States.WI;
                p94.Street = "65873 Chen Knolls";
                p94.City = "Ramirezfurt";
                p94.HostEmail = "morales@aol.com";
                p94.WeekendPrice = 117.17m;
                p94.WeekdayPrice = 215.38m;
                p94.PetsAllowed = false;
                p94.ParkingFree = false;
                p94.CleaningFee = 24.31m;
                p94.Bedrooms = 4;
                p94.Bathrooms = 3;
                p94.GuestsAllowed = 14;



                p94.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p94);







                Property p95 = new Property();

                p95.ZipCode = "57039";
                p95.State = States.IN;
                p95.Street = "8799 Emma Parkway ";
                p95.UnitNumber = "Suite 735";
                p95.City = "North Thomasfurt";
                p95.HostEmail = "rice@yahoo.com";
                p95.WeekendPrice = 242.21m;
                p95.WeekdayPrice = 145.51m;
                p95.PetsAllowed = false;
                p95.ParkingFree = false;
                p95.CleaningFee = 11.89m;
                p95.Bedrooms = 3;
                p95.Bathrooms = 5;
                p95.GuestsAllowed = 11;



                p95.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p95);







                Property p96 = new Property();

                p96.ZipCode = "23718";
                p96.State = States.ND;
                p96.Street = "30068 David View ";
                p96.UnitNumber = "Apt. 173";
                p96.City = "New Peggychester";
                p96.HostEmail = "martinez@aol.com";
                p96.WeekendPrice = 161.21m;
                p96.WeekdayPrice = 142.76m;
                p96.PetsAllowed = false;
                p96.ParkingFree = true;
                p96.CleaningFee = 20.92m;
                p96.Bedrooms = 4;
                p96.Bathrooms = 6;
                p96.GuestsAllowed = 7;



                p96.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p96);







                Property p97 = new Property();

                p97.ZipCode = "26932";
                p97.State = States.MD;
                p97.Street = "298 Johnathan Cove ";
                p97.UnitNumber = "Apt. 402";
                p97.City = "South Jamie";
                p97.HostEmail = "ingram@gmail.com";
                p97.WeekendPrice = 176.37m;
                p97.WeekdayPrice = 170.07m;
                p97.PetsAllowed = false;
                p97.ParkingFree = true;
                p97.CleaningFee = 8.54m;
                p97.Bedrooms = 6;
                p97.Bathrooms = 7;
                p97.GuestsAllowed = 13;



                p97.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p97);







                Property p98 = new Property();

                p98.ZipCode = "74554";
                p98.State = States.CO;
                p98.Street = "171 Harrison Motorway";
                p98.City = "Davidview";
                p98.HostEmail = "chung@yahoo.com";
                p98.WeekendPrice = 234.81m;
                p98.WeekdayPrice = 145.08m;
                p98.PetsAllowed = true;
                p98.ParkingFree = true;
                p98.CleaningFee = 26.14m;
                p98.Bedrooms = 6;
                p98.Bathrooms = 8;
                p98.GuestsAllowed = 10;



                p98.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p98);







                Property p99 = new Property();

                p99.ZipCode = "32097";
                p99.State = States.NE;
                p99.Street = "3576 Sergio Avenue";
                p99.City = "Benjaminmouth";
                p99.HostEmail = "morales@aol.com";
                p99.WeekendPrice = 260.62m;
                p99.WeekdayPrice = 111.73m;
                p99.PetsAllowed = false;
                p99.ParkingFree = false;
                p99.CleaningFee = 15.89m;
                p99.Bedrooms = 1;
                p99.Bathrooms = 1;
                p99.GuestsAllowed = 1;



                p99.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p99);







                Property p100 = new Property();

                p100.ZipCode = "21519";
                p100.State = States.RI;
                p100.Street = "37457 Tanya Pike ";
                p100.UnitNumber = "Apt. 348";
                p100.City = "North Ericton";
                p100.HostEmail = "ingram@gmail.com";
                p100.WeekendPrice = 214.62m;
                p100.WeekdayPrice = 70.63m;
                p100.PetsAllowed = false;
                p100.ParkingFree = true;
                p100.CleaningFee = 5.29m;
                p100.Bedrooms = 2;
                p100.Bathrooms = 1;
                p100.GuestsAllowed = 13;



                p100.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p100);







                Property p101 = new Property();

                p101.ZipCode = "76875";
                p101.State = States.PA;
                p101.Street = "3673 Peter Turnpike";
                p101.UnitNumber = "Suite 835";
                p101.City = "New Sandra";
                p101.HostEmail = "loter@yahoo.com";
                p101.WeekendPrice = 172.79m;
                p101.WeekdayPrice = 229.03m;
                p101.PetsAllowed = false;
                p101.ParkingFree = true;
                p101.CleaningFee = 14.05m;
                p101.Bedrooms = 4;
                p101.Bathrooms = 4;
                p101.GuestsAllowed = 6;



                p101.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p101);







                Property p102 = new Property();

                p102.ZipCode = "80451";
                p102.State = States.TX;
                p102.Street = "939 Johnson Oval";
                p102.UnitNumber = "Suite 830";
                p102.City = "North Dennismouth";
                p102.HostEmail = "gonzalez@aol.com";
                p102.WeekendPrice = 133.53m;
                p102.WeekdayPrice = 169.34m;
                p102.PetsAllowed = false;
                p102.ParkingFree = true;
                p102.CleaningFee = 18.06m;
                p102.Bedrooms = 3;
                p102.Bathrooms = 5;
                p102.GuestsAllowed = 6;



                p102.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p102);







                Property p103 = new Property();

                p103.ZipCode = "51726";
                p103.State = States.NV;
                p103.Street = "645 Jennings Estates";
                p103.City = "Angelastad";
                p103.HostEmail = "tanner@utexas.edu";
                p103.WeekendPrice = 109.44m;
                p103.WeekdayPrice = 155.52m;
                p103.PetsAllowed = false;
                p103.ParkingFree = false;
                p103.CleaningFee = 8.28m;
                p103.Bedrooms = 2;
                p103.Bathrooms = 3;
                p103.GuestsAllowed = 4;



                p103.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p103);







                Property p104 = new Property();

                p104.ZipCode = "77240";
                p104.State = States.MT;
                p104.Street = "1231 Stephanie Lock";
                p104.UnitNumber = "Suite 835";
                p104.City = "North Richardland";
                p104.HostEmail = "martinez@aol.com";
                p104.WeekendPrice = 182.33m;
                p104.WeekdayPrice = 180.2m;
                p104.PetsAllowed = true;
                p104.ParkingFree = false;
                p104.CleaningFee = 17.78m;
                p104.Bedrooms = 5;
                p104.Bathrooms = 7;
                p104.GuestsAllowed = 5;



                p104.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p104);







                Property p105 = new Property();

                p105.ZipCode = "98152";
                p105.State = States.CO;
                p105.Street = "302 Parker Plains";
                p105.UnitNumber = "Apt. 197";
                p105.City = "East Robertstad";
                p105.HostEmail = "morales@aol.com";
                p105.WeekendPrice = 212.7m;
                p105.WeekdayPrice = 212.86m;
                p105.PetsAllowed = true;
                p105.ParkingFree = false;
                p105.CleaningFee = 6.82m;
                p105.Bedrooms = 3;
                p105.Bathrooms = 2;
                p105.GuestsAllowed = 1;



                p105.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p105);







                Property p106 = new Property();

                p106.ZipCode = "98277";
                p106.State = States.MS;
                p106.Street = "098 Hernandez Green";
                p106.City = "New Sergiobury";
                p106.HostEmail = "morales@aol.com";
                p106.WeekendPrice = 262.3m;
                p106.WeekdayPrice = 188.71m;
                p106.PetsAllowed = false;
                p106.ParkingFree = true;
                p106.CleaningFee = 21.88m;
                p106.Bedrooms = 4;
                p106.Bathrooms = 6;
                p106.GuestsAllowed = 8;



                p106.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p106);







                Property p107 = new Property();

                p107.ZipCode = "80082";
                p107.State = States.NE;
                p107.Street = "94102 Sims Port";
                p107.UnitNumber = "Suite 187";
                p107.City = "Florestown";
                p107.HostEmail = "rice@yahoo.com";
                p107.WeekendPrice = 128.05m;
                p107.WeekdayPrice = 83.34m;
                p107.PetsAllowed = false;
                p107.ParkingFree = true;
                p107.CleaningFee = 11.29m;
                p107.Bedrooms = 4;
                p107.Bathrooms = 4;
                p107.GuestsAllowed = 8;



                p107.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p107);







                Property p108 = new Property();

                p108.ZipCode = "71531";
                p108.State = States.ND;
                p108.Street = "01630 Baker Crescent";
                p108.City = "Kellyborough";
                p108.HostEmail = "gonzalez@aol.com";
                p108.WeekendPrice = 125.27m;
                p108.WeekdayPrice = 204.02m;
                p108.PetsAllowed = true;
                p108.ParkingFree = true;
                p108.CleaningFee = 21.15m;
                p108.Bedrooms = 1;
                p108.Bathrooms = 1;
                p108.GuestsAllowed = 4;



                p108.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p108);







                Property p109 = new Property();

                p109.ZipCode = "14157";
                p109.State = States.OK;
                p109.Street = "70452 Forbes Courts";
                p109.City = "Mosesland";
                p109.HostEmail = "morales@aol.com";
                p109.WeekendPrice = 172.1m;
                p109.WeekdayPrice = 90.98m;
                p109.PetsAllowed = true;
                p109.ParkingFree = false;
                p109.CleaningFee = 18.09m;
                p109.Bedrooms = 4;
                p109.Bathrooms = 3;
                p109.GuestsAllowed = 9;



                p109.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p109);







                Property p110 = new Property();

                p110.ZipCode = "26899";
                p110.State = States.MO;
                p110.Street = "0835 Angela Station";
                p110.City = "East Heather";
                p110.HostEmail = "tanner@utexas.edu";
                p110.WeekendPrice = 299.91m;
                p110.WeekdayPrice = 158.64m;
                p110.PetsAllowed = true;
                p110.ParkingFree = false;
                p110.CleaningFee = 23.09m;
                p110.Bedrooms = 5;
                p110.Bathrooms = 7;
                p110.GuestsAllowed = 9;



                p110.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p110);







                Property p111 = new Property();

                p111.ZipCode = "42872";
                p111.State = States.VT;
                p111.Street = "2458 Jason Village";
                p111.UnitNumber = "Suite 248";
                p111.City = "North Donnamouth";
                p111.HostEmail = "tanner@utexas.edu";
                p111.WeekendPrice = 189.3m;
                p111.WeekdayPrice = 107.97m;
                p111.PetsAllowed = false;
                p111.ParkingFree = true;
                p111.CleaningFee = 9.05m;
                p111.Bedrooms = 2;
                p111.Bathrooms = 4;
                p111.GuestsAllowed = 4;



                p111.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p111);







                Property p112 = new Property();

                p112.ZipCode = "78301";
                p112.State = States.CO;
                p112.Street = "1243 Grimes Corners";
                p112.City = "Shawchester";
                p112.HostEmail = "martinez@aol.com";
                p112.WeekendPrice = 193.24m;
                p112.WeekdayPrice = 214.14m;
                p112.PetsAllowed = true;
                p112.ParkingFree = true;
                p112.CleaningFee = 26.1m;
                p112.Bedrooms = 4;
                p112.Bathrooms = 3;
                p112.GuestsAllowed = 2;



                p112.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p112);







                Property p113 = new Property();

                p113.ZipCode = "34523";
                p113.State = States.DC;
                p113.Street = "558 Williams Station";
                p113.City = "Port Pamela";
                p113.HostEmail = "rankin@yahoo.com";
                p113.WeekendPrice = 192.46m;
                p113.WeekdayPrice = 106.3m;
                p113.PetsAllowed = false;
                p113.ParkingFree = true;
                p113.CleaningFee = 17.59m;
                p113.Bedrooms = 6;
                p113.Bathrooms = 7;
                p113.GuestsAllowed = 4;



                p113.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p113);







                Property p114 = new Property();

                p114.ZipCode = "63064";
                p114.State = States.VT;
                p114.Street = "4934 Lozano Place";
                p114.UnitNumber = "Suite 716";
                p114.City = "Gavinton";
                p114.HostEmail = "chung@yahoo.com";
                p114.WeekendPrice = 257.37m;
                p114.WeekdayPrice = 116.99m;
                p114.PetsAllowed = false;
                p114.ParkingFree = false;
                p114.CleaningFee = 5.63m;
                p114.Bedrooms = 5;
                p114.Bathrooms = 6;
                p114.GuestsAllowed = 6;



                p114.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p114);







                Property p115 = new Property();

                p115.ZipCode = "35700";
                p115.State = States.LA;
                p115.Street = "41227 Patricia Lake";
                p115.City = "Martinezbury";
                p115.HostEmail = "gonzalez@aol.com";
                p115.WeekendPrice = 108.28m;
                p115.WeekdayPrice = 203.03m;
                p115.PetsAllowed = true;
                p115.ParkingFree = false;
                p115.CleaningFee = 11.35m;
                p115.Bedrooms = 2;
                p115.Bathrooms = 1;
                p115.GuestsAllowed = 3;



                p115.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p115);







                Property p116 = new Property();

                p116.ZipCode = "55206";
                p116.State = States.VA;
                p116.Street = "028 Harris Drive";
                p116.UnitNumber = "Apt. 422";
                p116.City = "Amyburgh";
                p116.HostEmail = "martinez@aol.com";
                p116.WeekendPrice = 262.77m;
                p116.WeekdayPrice = 163.3m;
                p116.PetsAllowed = true;
                p116.ParkingFree = true;
                p116.CleaningFee = 13.74m;
                p116.Bedrooms = 2;
                p116.Bathrooms = 2;
                p116.GuestsAllowed = 14;



                p116.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p116);







                Property p117 = new Property();

                p117.ZipCode = "98240";
                p117.State = States.IA;
                p117.Street = "06268 Lewis Place";
                p117.UnitNumber = "Suite 121";
                p117.City = "Port Patriciatown";
                p117.HostEmail = "gonzalez@aol.com";
                p117.WeekendPrice = 108.52m;
                p117.WeekdayPrice = 156.25m;
                p117.PetsAllowed = false;
                p117.ParkingFree = false;
                p117.CleaningFee = 23.66m;
                p117.Bedrooms = 3;
                p117.Bathrooms = 2;
                p117.GuestsAllowed = 4;



                p117.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p117);







                Property p118 = new Property();

                p118.ZipCode = "87205";
                p118.State = States.WI;
                p118.Street = "5641 Brenda Streets";
                p118.UnitNumber = "Apt. 008";
                p118.City = "Lake Seanmouth";
                p118.HostEmail = "rankin@yahoo.com";
                p118.WeekendPrice = 153.42m;
                p118.WeekdayPrice = 178.27m;
                p118.PetsAllowed = true;
                p118.ParkingFree = false;
                p118.CleaningFee = 24.69m;
                p118.Bedrooms = 5;
                p118.Bathrooms = 6;
                p118.GuestsAllowed = 12;



                p118.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p118);







                Property p119 = new Property();

                p119.ZipCode = "58221";
                p119.State = States.ME;
                p119.Street = "92555 Shaw Spurs";
                p119.UnitNumber = "Suite 207";
                p119.City = "New Randy";
                p119.HostEmail = "rice@yahoo.com";
                p119.WeekendPrice = 184.92m;
                p119.WeekdayPrice = 92.51m;
                p119.PetsAllowed = false;
                p119.ParkingFree = true;
                p119.CleaningFee = 12.82m;
                p119.Bedrooms = 7;
                p119.Bathrooms = 8;
                p119.GuestsAllowed = 13;



                p119.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p119);







                Property p120 = new Property();

                p120.ZipCode = "18885";
                p120.State = States.NY;
                p120.Street = "559 Foster Locks";
                p120.UnitNumber = "Suite 933";
                p120.City = "Robinsonhaven";
                p120.HostEmail = "tanner@utexas.edu";
                p120.WeekendPrice = 225.85m;
                p120.WeekdayPrice = 224.62m;
                p120.PetsAllowed = false;
                p120.ParkingFree = false;
                p120.CleaningFee = 17.9m;
                p120.Bedrooms = 6;
                p120.Bathrooms = 6;
                p120.GuestsAllowed = 6;



                p120.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p120);







                Property p121 = new Property();

                p121.ZipCode = "638";
                p121.State = States.WY;
                p121.Street = "4647 Kristine Fields";
                p121.UnitNumber = "Suite 710";
                p121.City = "New Dakota";
                p121.HostEmail = "morales@aol.com";
                p121.WeekendPrice = 174.02m;
                p121.WeekdayPrice = 112.61m;
                p121.PetsAllowed = true;
                p121.ParkingFree = false;
                p121.CleaningFee = 17.48m;
                p121.Bedrooms = 1;
                p121.Bathrooms = 2;
                p121.GuestsAllowed = 10;



                p121.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p121);







                Property p122 = new Property();

                p122.ZipCode = "31451";
                p122.State = States.ME;
                p122.Street = "92594 Emily Shoals";
                p122.City = "North Cathyburgh";
                p122.HostEmail = "rankin@yahoo.com";
                p122.WeekendPrice = 119.06m;
                p122.WeekdayPrice = 189.98m;
                p122.PetsAllowed = false;
                p122.ParkingFree = false;
                p122.CleaningFee = 25.11m;
                p122.Bedrooms = 6;
                p122.Bathrooms = 5;
                p122.GuestsAllowed = 1;



                p122.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p122);







                Property p123 = new Property();

                p123.ZipCode = "26297";
                p123.State = States.MS;
                p123.Street = "551 Casey Squares";
                p123.UnitNumber = "Apt. 209";
                p123.City = "Michaelborough";
                p123.HostEmail = "martinez@aol.com";
                p123.WeekendPrice = 114.73m;
                p123.WeekdayPrice = 72.03m;
                p123.PetsAllowed = false;
                p123.ParkingFree = true;
                p123.CleaningFee = 18.38m;
                p123.Bedrooms = 1;
                p123.Bathrooms = 1;
                p123.GuestsAllowed = 6;



                p123.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p123);







                Property p124 = new Property();

                p124.ZipCode = "4610";
                p124.State = States.PA;
                p124.Street = "2998 Willis Wall";
                p124.City = "North Brian";
                p124.HostEmail = "loter@yahoo.com";
                p124.WeekendPrice = 144.51m;
                p124.WeekdayPrice = 216.21m;
                p124.PetsAllowed = false;
                p124.ParkingFree = false;
                p124.CleaningFee = 10.81m;
                p124.Bedrooms = 3;
                p124.Bathrooms = 4;
                p124.GuestsAllowed = 3;



                p124.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p124);







                Property p125 = new Property();

                p125.ZipCode = "86618";
                p125.State = States.MD;
                p125.Street = "164 Schultz Road";
                p125.City = "Lake Bryan";
                p125.HostEmail = "chung@yahoo.com";
                p125.WeekendPrice = 233.9m;
                p125.WeekdayPrice = 132.69m;
                p125.PetsAllowed = false;
                p125.ParkingFree = true;
                p125.CleaningFee = 15.8m;
                p125.Bedrooms = 5;
                p125.Bathrooms = 7;
                p125.GuestsAllowed = 13;



                p125.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p125);







                Property p126 = new Property();

                p126.ZipCode = "80124";
                p126.State = States.GA;
                p126.Street = "9541 Brock Estate";
                p126.UnitNumber = "Apt. 848";
                p126.City = "Franklinchester";
                p126.HostEmail = "jacobs@yahoo.com";
                p126.WeekendPrice = 285.05m;
                p126.WeekdayPrice = 220.97m;
                p126.PetsAllowed = false;
                p126.ParkingFree = false;
                p126.CleaningFee = 20.98m;
                p126.Bedrooms = 2;
                p126.Bathrooms = 1;
                p126.GuestsAllowed = 9;



                p126.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p126);







                Property p127 = new Property();

                p127.ZipCode = "63590";
                p127.State = States.MS;
                p127.Street = "588 Alan Rest";
                p127.City = "Port Stephanieville";
                p127.HostEmail = "ingram@gmail.com";
                p127.WeekendPrice = 180.86m;
                p127.WeekdayPrice = 224.98m;
                p127.PetsAllowed = true;
                p127.ParkingFree = true;
                p127.CleaningFee = 11.91m;
                p127.Bedrooms = 6;
                p127.Bathrooms = 6;
                p127.GuestsAllowed = 12;



                p127.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p127);







                Property p128 = new Property();

                p128.ZipCode = "53548";
                p128.State = States.MT;
                p128.Street = "216 Brandon Loop";
                p128.UnitNumber = "Apt. 096";
                p128.City = "New Jessica";
                p128.HostEmail = "rice@yahoo.com";
                p128.WeekendPrice = 239.97m;
                p128.WeekdayPrice = 221.98m;
                p128.PetsAllowed = true;
                p128.ParkingFree = true;
                p128.CleaningFee = 9.24m;
                p128.Bedrooms = 5;
                p128.Bathrooms = 7;
                p128.GuestsAllowed = 12;



                p128.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p128);







                Property p129 = new Property();

                p129.ZipCode = "35611";
                p129.State = States.LA;
                p129.Street = "782 Dawn Radial";
                p129.City = "Port Christopher";
                p129.HostEmail = "ingram@gmail.com";
                p129.WeekendPrice = 297.25m;
                p129.WeekdayPrice = 76.56m;
                p129.PetsAllowed = false;
                p129.ParkingFree = true;
                p129.CleaningFee = 20.42m;
                p129.Bedrooms = 1;
                p129.Bathrooms = 3;
                p129.GuestsAllowed = 1;



                p129.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p129);







                Property p130 = new Property();

                p130.ZipCode = "42879";
                p130.State = States.WA;
                p130.Street = "008 Nancy Route";
                p130.UnitNumber = "Suite 228";
                p130.City = "North Stephanie";
                p130.HostEmail = "morales@aol.com";
                p130.WeekendPrice = 129.36m;
                p130.WeekdayPrice = 128.71m;
                p130.PetsAllowed = true;
                p130.ParkingFree = false;
                p130.CleaningFee = 23.76m;
                p130.Bedrooms = 2;
                p130.Bathrooms = 3;
                p130.GuestsAllowed = 3;



                p130.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p130);







                Property p131 = new Property();

                p131.ZipCode = "71569";
                p131.State = States.MO;
                p131.Street = "115 Jon Isle";
                p131.UnitNumber = "Suite 788";
                p131.City = "North Lesliefurt";
                p131.HostEmail = "loter@yahoo.com";
                p131.WeekendPrice = 210.63m;
                p131.WeekdayPrice = 114.21m;
                p131.PetsAllowed = false;
                p131.ParkingFree = true;
                p131.CleaningFee = 21.08m;
                p131.Bedrooms = 1;
                p131.Bathrooms = 2;
                p131.GuestsAllowed = 9;



                p131.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p131);







                Property p132 = new Property();

                p132.ZipCode = "87566";
                p132.State = States.DE;
                p132.Street = "132 Poole Pass";
                p132.UnitNumber = "Suite 212";
                p132.City = "North Patrick";
                p132.HostEmail = "tanner@utexas.edu";
                p132.WeekendPrice = 280.37m;
                p132.WeekdayPrice = 146.82m;
                p132.PetsAllowed = false;
                p132.ParkingFree = true;
                p132.CleaningFee = 26.78m;
                p132.Bedrooms = 5;
                p132.Bathrooms = 6;
                p132.GuestsAllowed = 11;



                p132.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p132);







                Property p133 = new Property();

                p133.ZipCode = "67652";
                p133.State = States.WY;
                p133.Street = "457 Vargas Island";
                p133.UnitNumber = "Suite 853";
                p133.City = "Lake Patrickstad";
                p133.HostEmail = "jacobs@yahoo.com";
                p133.WeekendPrice = 249.39m;
                p133.WeekdayPrice = 134.72m;
                p133.PetsAllowed = false;
                p133.ParkingFree = false;
                p133.CleaningFee = 19.19m;
                p133.Bedrooms = 4;
                p133.Bathrooms = 3;
                p133.GuestsAllowed = 1;



                p133.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p133);







                Property p134 = new Property();

                p134.ZipCode = "45184";
                p134.State = States.HI;
                p134.Street = "1569 Amy Path";
                p134.City = "North Ashleyton";
                p134.HostEmail = "tanner@utexas.edu";
                p134.WeekendPrice = 111.23m;
                p134.WeekdayPrice = 111.6m;
                p134.PetsAllowed = true;
                p134.ParkingFree = true;
                p134.CleaningFee = 13.48m;
                p134.Bedrooms = 7;
                p134.Bathrooms = 8;
                p134.GuestsAllowed = 7;



                p134.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p134);







                Property p135 = new Property();

                p135.ZipCode = "4078";
                p135.State = States.IL;
                p135.Street = "0375 Sandra Trace";
                p135.UnitNumber = "Suite 826";
                p135.City = "Gailshire";
                p135.HostEmail = "tanner@utexas.edu";
                p135.WeekendPrice = 168.47m;
                p135.WeekdayPrice = 89.0m;
                p135.PetsAllowed = true;
                p135.ParkingFree = false;
                p135.CleaningFee = 14.93m;
                p135.Bedrooms = 5;
                p135.Bathrooms = 6;
                p135.GuestsAllowed = 3;



                p135.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p135);







                Property p136 = new Property();

                p136.ZipCode = "50437";
                p136.State = States.MN;
                p136.Street = "759 Good Port";
                p136.City = "New Russell";
                p136.HostEmail = "ingram@gmail.com";
                p136.WeekendPrice = 208.35m;
                p136.WeekdayPrice = 208.64m;
                p136.PetsAllowed = true;
                p136.ParkingFree = true;
                p136.CleaningFee = 7.09m;
                p136.Bedrooms = 5;
                p136.Bathrooms = 5;
                p136.GuestsAllowed = 6;



                p136.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p136);







                Property p137 = new Property();

                p137.ZipCode = "34147";
                p137.State = States.WV;
                p137.Street = "3895 Allen Junction";
                p137.City = "West John";
                p137.HostEmail = "chung@yahoo.com";
                p137.WeekendPrice = 195.41m;
                p137.WeekdayPrice = 172.51m;
                p137.PetsAllowed = false;
                p137.ParkingFree = false;
                p137.CleaningFee = 21.53m;
                p137.Bedrooms = 5;
                p137.Bathrooms = 7;
                p137.GuestsAllowed = 3;



                p137.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p137);







                Property p138 = new Property();

                p138.ZipCode = "36340";
                p138.State = States.MS;
                p138.Street = "7329 Jacobs Station";
                p138.City = "New Tylerborough";
                p138.HostEmail = "jacobs@yahoo.com";
                p138.WeekendPrice = 146.12m;
                p138.WeekdayPrice = 163.15m;
                p138.PetsAllowed = false;
                p138.ParkingFree = false;
                p138.CleaningFee = 18.98m;
                p138.Bedrooms = 1;
                p138.Bathrooms = 3;
                p138.GuestsAllowed = 8;



                p138.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p138);







                Property p139 = new Property();

                p139.ZipCode = "88806";
                p139.State = States.MD;
                p139.Street = "5003 Cassandra Estates";
                p139.UnitNumber = "Suite 148";
                p139.City = "Haleychester";
                p139.HostEmail = "tanner@utexas.edu";
                p139.WeekendPrice = 161.49m;
                p139.WeekdayPrice = 81.5m;
                p139.PetsAllowed = true;
                p139.ParkingFree = false;
                p139.CleaningFee = 16.41m;
                p139.Bedrooms = 7;
                p139.Bathrooms = 7;
                p139.GuestsAllowed = 9;



                p139.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p139);







                Property p140 = new Property();

                p140.ZipCode = "76853";
                p140.State = States.TN;
                p140.Street = "10524 Parker Mall";
                p140.UnitNumber = "Suite 531";
                p140.City = "Port Courtneyhaven";
                p140.HostEmail = "ingram@gmail.com";
                p140.WeekendPrice = 120.73m;
                p140.WeekdayPrice = 177.94m;
                p140.PetsAllowed = false;
                p140.ParkingFree = true;
                p140.CleaningFee = 9.5m;
                p140.Bedrooms = 5;
                p140.Bathrooms = 7;
                p140.GuestsAllowed = 13;



                p140.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Hotel Room");
                Properties.Add(p140);







                Property p141 = new Property();

                p141.ZipCode = "93533";
                p141.State = States.MO;
                p141.Street = "300 Madison Stream";
                p141.City = "Christophershire";
                p141.HostEmail = "loter@yahoo.com";
                p141.WeekendPrice = 187.08m;
                p141.WeekdayPrice = 121.01m;
                p141.PetsAllowed = false;
                p141.ParkingFree = false;
                p141.CleaningFee = 16.48m;
                p141.Bedrooms = 3;
                p141.Bathrooms = 4;
                p141.GuestsAllowed = 6;



                p141.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p141);







                Property p142 = new Property();

                p142.ZipCode = "96763";
                p142.State = States.FL;
                p142.Street = "4229 Derrick Wells";
                p142.City = "West Tyler";
                p142.HostEmail = "martinez@aol.com";
                p142.WeekendPrice = 241.45m;
                p142.WeekdayPrice = 199.68m;
                p142.PetsAllowed = true;
                p142.ParkingFree = false;
                p142.CleaningFee = 25.94m;
                p142.Bedrooms = 2;
                p142.Bathrooms = 4;
                p142.GuestsAllowed = 6;



                p142.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p142);







                Property p143 = new Property();

                p143.ZipCode = "92174";
                p143.State = States.VA;
                p143.Street = "26239 Michael Shoals";
                p143.City = "Gregoryview";
                p143.HostEmail = "morales@aol.com";
                p143.WeekendPrice = 111.91m;
                p143.WeekdayPrice = 162.01m;
                p143.PetsAllowed = true;
                p143.ParkingFree = true;
                p143.CleaningFee = 14.35m;
                p143.Bedrooms = 1;
                p143.Bathrooms = 2;
                p143.GuestsAllowed = 9;



                p143.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p143);







                Property p144 = new Property();

                p144.ZipCode = "88294";
                p144.State = States.IN;
                p144.Street = "302 Joy Spring";
                p144.UnitNumber = "Apt. 622";
                p144.City = "Ryanhaven";
                p144.HostEmail = "ingram@gmail.com";
                p144.WeekendPrice = 163.73m;
                p144.WeekdayPrice = 173.36m;
                p144.PetsAllowed = false;
                p144.ParkingFree = true;
                p144.CleaningFee = 25.35m;
                p144.Bedrooms = 1;
                p144.Bathrooms = 3;
                p144.GuestsAllowed = 12;



                p144.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p144);







                Property p145 = new Property();

                p145.ZipCode = "23464";
                p145.State = States.CA;
                p145.Street = "734 Craig Overpass";
                p145.UnitNumber = "Suite 589";
                p145.City = "Jefferyside";
                p145.HostEmail = "martinez@aol.com";
                p145.WeekendPrice = 287.28m;
                p145.WeekdayPrice = 216.1m;
                p145.PetsAllowed = false;
                p145.ParkingFree = false;
                p145.CleaningFee = 22.2m;
                p145.Bedrooms = 1;
                p145.Bathrooms = 3;
                p145.GuestsAllowed = 8;



                p145.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p145);







                Property p146 = new Property();

                p146.ZipCode = "35243";
                p146.State = States.CA;
                p146.Street = "272 Green Street";
                p146.City = "Port Lacey";
                p146.HostEmail = "martinez@aol.com";
                p146.WeekendPrice = 247.34m;
                p146.WeekdayPrice = 211.51m;
                p146.PetsAllowed = true;
                p146.ParkingFree = false;
                p146.CleaningFee = 11.73m;
                p146.Bedrooms = 4;
                p146.Bathrooms = 3;
                p146.GuestsAllowed = 7;



                p146.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p146);







                Property p147 = new Property();

                p147.ZipCode = "61935";
                p147.State = States.IL;
                p147.Street = "8056 Dunn Trail";
                p147.UnitNumber = "Apt. 049";
                p147.City = "Blackshire";
                p147.HostEmail = "loter@yahoo.com";
                p147.WeekendPrice = 189.08m;
                p147.WeekdayPrice = 111.4m;
                p147.PetsAllowed = false;
                p147.ParkingFree = true;
                p147.CleaningFee = 19.58m;
                p147.Bedrooms = 5;
                p147.Bathrooms = 6;
                p147.GuestsAllowed = 2;



                p147.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p147);







                Property p148 = new Property();

                p148.ZipCode = "72324";
                p148.State = States.CA;
                p148.Street = "86187 Antonio Fort";
                p148.City = "North Carmen";
                p148.HostEmail = "tanner@utexas.edu";
                p148.WeekendPrice = 109.87m;
                p148.WeekdayPrice = 150.69m;
                p148.PetsAllowed = true;
                p148.ParkingFree = false;
                p148.CleaningFee = 13.3m;
                p148.Bedrooms = 7;
                p148.Bathrooms = 9;
                p148.GuestsAllowed = 7;



                p148.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p148);







                Property p149 = new Property();

                p149.ZipCode = "84393";
                p149.State = States.NJ;
                p149.Street = "71318 Cassandra Plaza";
                p149.City = "Burkeview";
                p149.HostEmail = "loter@yahoo.com";
                p149.WeekendPrice = 227.55m;
                p149.WeekdayPrice = 184.21m;
                p149.PetsAllowed = true;
                p149.ParkingFree = false;
                p149.CleaningFee = 19.52m;
                p149.Bedrooms = 7;
                p149.Bathrooms = 7;
                p149.GuestsAllowed = 10;



                p149.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p149);







                Property p150 = new Property();

                p150.ZipCode = "62346";
                p150.State = States.NH;
                p150.Street = "5303 Lewis Springs";
                p150.City = "Port Adrian";
                p150.HostEmail = "tanner@utexas.edu";
                p150.WeekendPrice = 207.51m;
                p150.WeekdayPrice = 204.67m;
                p150.PetsAllowed = false;
                p150.ParkingFree = false;
                p150.CleaningFee = 26.36m;
                p150.Bedrooms = 2;
                p150.Bathrooms = 1;
                p150.GuestsAllowed = 2;



                p150.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p150);







                Property p151 = new Property();

                p151.ZipCode = "2837";
                p151.State = States.IA;
                p151.Street = "465 Wiley Corners";
                p151.UnitNumber = "Apt. 759";
                p151.City = "East Michellechester";
                p151.HostEmail = "gonzalez@aol.com";
                p151.WeekendPrice = 213.84m;
                p151.WeekdayPrice = 129.14m;
                p151.PetsAllowed = false;
                p151.ParkingFree = false;
                p151.CleaningFee = 12.81m;
                p151.Bedrooms = 6;
                p151.Bathrooms = 5;
                p151.GuestsAllowed = 11;



                p151.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p151);







                Property p152 = new Property();

                p152.ZipCode = "68847";
                p152.State = States.LA;
                p152.Street = "521 Flores Stream";
                p152.City = "West Rebeccaborough";
                p152.HostEmail = "rankin@yahoo.com";
                p152.WeekendPrice = 254.37m;
                p152.WeekdayPrice = 77.06m;
                p152.PetsAllowed = true;
                p152.ParkingFree = true;
                p152.CleaningFee = 6.03m;
                p152.Bedrooms = 3;
                p152.Bathrooms = 5;
                p152.GuestsAllowed = 3;



                p152.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p152);







                Property p153 = new Property();

                p153.ZipCode = "35218";
                p153.State = States.NE;
                p153.Street = "0271 Soto Drives";
                p153.UnitNumber = "Apt. 975";
                p153.City = "New Edgar";
                p153.HostEmail = "tanner@utexas.edu";
                p153.WeekendPrice = 233.17m;
                p153.WeekdayPrice = 179.91m;
                p153.PetsAllowed = false;
                p153.ParkingFree = true;
                p153.CleaningFee = 11.04m;
                p153.Bedrooms = 4;
                p153.Bathrooms = 5;
                p153.GuestsAllowed = 9;



                p153.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p153);







                Property p154 = new Property();

                p154.ZipCode = "32697";
                p154.State = States.NM;
                p154.Street = "27862 Kent Mountains";
                p154.City = "Lake Michaelville";
                p154.HostEmail = "jacobs@yahoo.com";
                p154.WeekendPrice = 153.38m;
                p154.WeekdayPrice = 90.54m;
                p154.PetsAllowed = true;
                p154.ParkingFree = false;
                p154.CleaningFee = 6.91m;
                p154.Bedrooms = 6;
                p154.Bathrooms = 5;
                p154.GuestsAllowed = 14;



                p154.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p154);







                Property p155 = new Property();

                p155.ZipCode = "95889";
                p155.State = States.OR;
                p155.Street = "917 Mclaughlin Glens";
                p155.City = "Martinville";
                p155.HostEmail = "rankin@yahoo.com";
                p155.WeekendPrice = 226.89m;
                p155.WeekdayPrice = 225.59m;
                p155.PetsAllowed = false;
                p155.ParkingFree = true;
                p155.CleaningFee = 28.99m;
                p155.Bedrooms = 7;
                p155.Bathrooms = 6;
                p155.GuestsAllowed = 2;



                p155.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p155);







                Property p156 = new Property();

                p156.ZipCode = "82153";
                p156.State = States.KY;
                p156.Street = "3032 Michelle Drives";
                p156.City = "North Daniel";
                p156.HostEmail = "rankin@yahoo.com";
                p156.WeekendPrice = 157.15m;
                p156.WeekdayPrice = 203.25m;
                p156.PetsAllowed = false;
                p156.ParkingFree = true;
                p156.CleaningFee = 15.68m;
                p156.Bedrooms = 3;
                p156.Bathrooms = 4;
                p156.GuestsAllowed = 13;



                p156.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p156);







                Property p157 = new Property();

                p157.ZipCode = "32202";
                p157.State = States.SD;
                p157.Street = "601 Maria Mission";
                p157.UnitNumber = "Apt. 554";
                p157.City = "Myerstown";
                p157.HostEmail = "tanner@utexas.edu";
                p157.WeekendPrice = 269.55m;
                p157.WeekdayPrice = 223.27m;
                p157.PetsAllowed = false;
                p157.ParkingFree = true;
                p157.CleaningFee = 11.35m;
                p157.Bedrooms = 7;
                p157.Bathrooms = 9;
                p157.GuestsAllowed = 9;



                p157.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p157);







                Property p158 = new Property();

                p158.ZipCode = "17431";
                p158.State = States.OH;
                p158.Street = "238 Shawn Well";
                p158.City = "Port Johnshire";
                p158.HostEmail = "ingram@gmail.com";
                p158.WeekendPrice = 112.64m;
                p158.WeekdayPrice = 173.63m;
                p158.PetsAllowed = true;
                p158.ParkingFree = true;
                p158.CleaningFee = 6.38m;
                p158.Bedrooms = 7;
                p158.Bathrooms = 8;
                p158.GuestsAllowed = 14;



                p158.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p158);







                Property p159 = new Property();

                p159.ZipCode = "37901";
                p159.State = States.SC;
                p159.Street = "41743 Berger Inlet";
                p159.UnitNumber = "Apt. 527";
                p159.City = "South Tammymouth";
                p159.HostEmail = "rice@yahoo.com";
                p159.WeekendPrice = 163.2m;
                p159.WeekdayPrice = 176.23m;
                p159.PetsAllowed = true;
                p159.ParkingFree = false;
                p159.CleaningFee = 14.77m;
                p159.Bedrooms = 7;
                p159.Bathrooms = 9;
                p159.GuestsAllowed = 9;



                p159.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p159);







                Property p160 = new Property();

                p160.ZipCode = "17895";
                p160.State = States.MO;
                p160.Street = "9983 Mary Grove";
                p160.UnitNumber = "Apt. 643";
                p160.City = "Beardview";
                p160.HostEmail = "ingram@gmail.com";
                p160.WeekendPrice = 209.33m;
                p160.WeekdayPrice = 219.53m;
                p160.PetsAllowed = true;
                p160.ParkingFree = false;
                p160.CleaningFee = 24.51m;
                p160.Bedrooms = 7;
                p160.Bathrooms = 6;
                p160.GuestsAllowed = 9;



                p160.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p160);







                Property p161 = new Property();

                p161.ZipCode = "90576";
                p161.State = States.HI;
                p161.Street = "03541 Ryan Islands";
                p161.UnitNumber = "Apt. 562";
                p161.City = "East Michaelfort";
                p161.HostEmail = "rice@yahoo.com";
                p161.WeekendPrice = 269.63m;
                p161.WeekdayPrice = 126.25m;
                p161.PetsAllowed = false;
                p161.ParkingFree = true;
                p161.CleaningFee = 8.27m;
                p161.Bedrooms = 1;
                p161.Bathrooms = 2;
                p161.GuestsAllowed = 10;



                p161.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p161);







                Property p162 = new Property();

                p162.ZipCode = "94980";
                p162.State = States.SC;
                p162.Street = "6591 Angela Mission";
                p162.UnitNumber = "Apt. 108";
                p162.City = "Penabury";
                p162.HostEmail = "chung@yahoo.com";
                p162.WeekendPrice = 286.86m;
                p162.WeekdayPrice = 143.98m;
                p162.PetsAllowed = false;
                p162.ParkingFree = true;
                p162.CleaningFee = 20.48m;
                p162.Bedrooms = 5;
                p162.Bathrooms = 6;
                p162.GuestsAllowed = 14;



                p162.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p162);







                Property p163 = new Property();

                p163.ZipCode = "44974";
                p163.State = States.CO;
                p163.Street = "492 Ramirez Crossing";
                p163.City = "Aaronberg";
                p163.HostEmail = "rice@yahoo.com";
                p163.WeekendPrice = 144.6m;
                p163.WeekdayPrice = 121.91m;
                p163.PetsAllowed = false;
                p163.ParkingFree = true;
                p163.CleaningFee = 10.12m;
                p163.Bedrooms = 1;
                p163.Bathrooms = 2;
                p163.GuestsAllowed = 10;



                p163.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p163);







                Property p164 = new Property();

                p164.ZipCode = "66170";
                p164.State = States.DE;
                p164.Street = "35974 Sharon Locks";
                p164.UnitNumber = "Apt. 101";
                p164.City = "Jennyport";
                p164.HostEmail = "martinez@aol.com";
                p164.WeekendPrice = 114.46m;
                p164.WeekdayPrice = 137.8m;
                p164.PetsAllowed = true;
                p164.ParkingFree = false;
                p164.CleaningFee = 17.74m;
                p164.Bedrooms = 7;
                p164.Bathrooms = 9;
                p164.GuestsAllowed = 1;



                p164.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p164);







                Property p165 = new Property();

                p165.ZipCode = "22495";
                p165.State = States.UT;
                p165.Street = "89403 Gabriella Mills";
                p165.City = "East Steven";
                p165.HostEmail = "gonzalez@aol.com";
                p165.WeekendPrice = 155.1m;
                p165.WeekdayPrice = 128.63m;
                p165.PetsAllowed = false;
                p165.ParkingFree = false;
                p165.CleaningFee = 23.05m;
                p165.Bedrooms = 3;
                p165.Bathrooms = 4;
                p165.GuestsAllowed = 11;



                p165.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p165);







                Property p166 = new Property();

                p166.ZipCode = "85059";
                p166.State = States.NH;
                p166.Street = "601 Kyle Roads";
                p166.City = "Clarkfurt";
                p166.HostEmail = "tanner@utexas.edu";
                p166.WeekendPrice = 284.39m;
                p166.WeekdayPrice = 209.11m;
                p166.PetsAllowed = false;
                p166.ParkingFree = false;
                p166.CleaningFee = 6.25m;
                p166.Bedrooms = 4;
                p166.Bathrooms = 5;
                p166.GuestsAllowed = 4;



                p166.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p166);







                Property p167 = new Property();

                p167.ZipCode = "61092";
                p167.State = States.IN;
                p167.Street = "60969 Justin Passage";
                p167.UnitNumber = "Suite 774";
                p167.City = "Joshuaburgh";
                p167.HostEmail = "loter@yahoo.com";
                p167.WeekendPrice = 121.0m;
                p167.WeekdayPrice = 128.59m;
                p167.PetsAllowed = false;
                p167.ParkingFree = false;
                p167.CleaningFee = 19.36m;
                p167.Bedrooms = 1;
                p167.Bathrooms = 1;
                p167.GuestsAllowed = 7;



                p167.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p167);







                Property p168 = new Property();

                p168.ZipCode = "43986";
                p168.State = States.PA;
                p168.Street = "7943 Tina Mount";
                p168.City = "East Lisa";
                p168.HostEmail = "gonzalez@aol.com";
                p168.WeekendPrice = 104.47m;
                p168.WeekdayPrice = 122.88m;
                p168.PetsAllowed = true;
                p168.ParkingFree = true;
                p168.CleaningFee = 25.31m;
                p168.Bedrooms = 4;
                p168.Bathrooms = 3;
                p168.GuestsAllowed = 14;



                p168.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p168);







                Property p169 = new Property();

                p169.ZipCode = "91397";
                p169.State = States.NC;
                p169.Street = "6775 James Ford";
                p169.City = "South Victorialand";
                p169.HostEmail = "jacobs@yahoo.com";
                p169.WeekendPrice = 275.5m;
                p169.WeekdayPrice = 211.24m;
                p169.PetsAllowed = true;
                p169.ParkingFree = true;
                p169.CleaningFee = 15.74m;
                p169.Bedrooms = 1;
                p169.Bathrooms = 3;
                p169.GuestsAllowed = 9;



                p169.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p169);







                Property p170 = new Property();

                p170.ZipCode = "67849";
                p170.State = States.VT;
                p170.Street = "431 Johnson Neck";
                p170.UnitNumber = "Suite 039";
                p170.City = "Mariechester";
                p170.HostEmail = "rice@yahoo.com";
                p170.WeekendPrice = 126.24m;
                p170.WeekdayPrice = 124.65m;
                p170.PetsAllowed = true;
                p170.ParkingFree = false;
                p170.CleaningFee = 24.3m;
                p170.Bedrooms = 1;
                p170.Bathrooms = 1;
                p170.GuestsAllowed = 9;



                p170.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p170);







                Property p171 = new Property();

                p171.ZipCode = "20687";
                p171.State = States.NM;
                p171.Street = "15666 Justin Locks";
                p171.City = "Lake Ryanport";
                p171.HostEmail = "tanner@utexas.edu";
                p171.WeekendPrice = 112.05m;
                p171.WeekdayPrice = 70.11m;
                p171.PetsAllowed = false;
                p171.ParkingFree = false;
                p171.CleaningFee = 27.45m;
                p171.Bedrooms = 6;
                p171.Bathrooms = 6;
                p171.GuestsAllowed = 3;



                p171.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p171);







                Property p172 = new Property();

                p172.ZipCode = "30222";
                p172.State = States.TX;
                p172.Street = "9947 Torres Viaduct";
                p172.UnitNumber = "Apt. 506";
                p172.City = "Benjaminport";
                p172.HostEmail = "ingram@gmail.com";
                p172.WeekendPrice = 152.09m;
                p172.WeekdayPrice = 174.87m;
                p172.PetsAllowed = true;
                p172.ParkingFree = false;
                p172.CleaningFee = 18.44m;
                p172.Bedrooms = 1;
                p172.Bathrooms = 2;
                p172.GuestsAllowed = 11;



                p172.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Apartment");
                Properties.Add(p172);







                Property p173 = new Property();

                p173.ZipCode = "21190";
                p173.State = States.NJ;
                p173.Street = "20866 Keith Mill";
                p173.City = "Susanton";
                p173.HostEmail = "chung@yahoo.com";
                p173.WeekendPrice = 174.06m;
                p173.WeekdayPrice = 96.8m;
                p173.PetsAllowed = false;
                p173.ParkingFree = false;
                p173.CleaningFee = 28.15m;
                p173.Bedrooms = 2;
                p173.Bathrooms = 4;
                p173.GuestsAllowed = 10;



                p173.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p173);







                Property p174 = new Property();

                p174.ZipCode = "4838";
                p174.State = States.AL;
                p174.Street = "04374 Nicholas Cliff";
                p174.UnitNumber = "Suite 001";
                p174.City = "Adrianport";
                p174.HostEmail = "jacobs@yahoo.com";
                p174.WeekendPrice = 108.24m;
                p174.WeekdayPrice = 205.01m;
                p174.PetsAllowed = true;
                p174.ParkingFree = false;
                p174.CleaningFee = 6.56m;
                p174.Bedrooms = 1;
                p174.Bathrooms = 1;
                p174.GuestsAllowed = 10;



                p174.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Condo");
                Properties.Add(p174);







                Property p175 = new Property();

                p175.ZipCode = "80130";
                p175.State = States.CA;
                p175.Street = "271 Andrew Summit";
                p175.City = "Port Craig";
                p175.HostEmail = "gonzalez@aol.com";
                p175.WeekendPrice = 148.39m;
                p175.WeekdayPrice = 197.52m;
                p175.PetsAllowed = true;
                p175.ParkingFree = true;
                p175.CleaningFee = 20.55m;
                p175.Bedrooms = 7;
                p175.Bathrooms = 6;
                p175.GuestsAllowed = 7;



                p175.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p175);







                Property p176 = new Property();

                p176.ZipCode = "96166";
                p176.State = States.MN;
                p176.Street = "17611 Robbins Mission";
                p176.City = "New Curtis";
                p176.HostEmail = "loter@yahoo.com";
                p176.WeekendPrice = 286.13m;
                p176.WeekdayPrice = 219.69m;
                p176.PetsAllowed = true;
                p176.ParkingFree = false;
                p176.CleaningFee = 10.64m;
                p176.Bedrooms = 3;
                p176.Bathrooms = 3;
                p176.GuestsAllowed = 9;



                p176.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p176);







                Property p177 = new Property();

                p177.ZipCode = "40702";
                p177.State = States.MO;
                p177.Street = "80831 Kemp Pines";
                p177.City = "Annashire";
                p177.HostEmail = "loter@yahoo.com";
                p177.WeekendPrice = 123.93m;
                p177.WeekdayPrice = 91.26m;
                p177.PetsAllowed = true;
                p177.ParkingFree = true;
                p177.CleaningFee = 19.36m;
                p177.Bedrooms = 1;
                p177.Bathrooms = 2;
                p177.GuestsAllowed = 7;



                p177.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p177);







                Property p178 = new Property();

                p178.ZipCode = "86023";
                p178.State = States.IL;
                p178.Street = "96545 Smith Alley";
                p178.City = "West Joy";
                p178.HostEmail = "martinez@aol.com";
                p178.WeekendPrice = 254.38m;
                p178.WeekdayPrice = 132.54m;
                p178.PetsAllowed = true;
                p178.ParkingFree = false;
                p178.CleaningFee = 14.83m;
                p178.Bedrooms = 6;
                p178.Bathrooms = 8;
                p178.GuestsAllowed = 7;



                p178.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p178);







                Property p179 = new Property();

                p179.ZipCode = "70897";
                p179.State = States.MT;
                p179.Street = "6146 Johnson Isle";
                p179.City = "South Arthur";
                p179.HostEmail = "chung@yahoo.com";
                p179.WeekendPrice = 228.04m;
                p179.WeekdayPrice = 227.96m;
                p179.PetsAllowed = true;
                p179.ParkingFree = true;
                p179.CleaningFee = 6.99m;
                p179.Bedrooms = 2;
                p179.Bathrooms = 4;
                p179.GuestsAllowed = 1;



                p179.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p179);







                Property p180 = new Property();

                p180.ZipCode = "69154";
                p180.State = States.MN;
                p180.Street = "0415 Smith Springs";
                p180.City = "Jeremyburgh";
                p180.HostEmail = "loter@yahoo.com";
                p180.WeekendPrice = 228.81m;
                p180.WeekdayPrice = 140.93m;
                p180.PetsAllowed = true;
                p180.ParkingFree = false;
                p180.CleaningFee = 29.74m;
                p180.Bedrooms = 4;
                p180.Bathrooms = 4;
                p180.GuestsAllowed = 3;



                p180.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p180);







                Property p181 = new Property();

                p181.ZipCode = "53524";
                p181.State = States.HI;
                p181.Street = "3999 Ricky Via";
                p181.City = "West Adamburgh";
                p181.HostEmail = "chung@yahoo.com";
                p181.WeekendPrice = 255.43m;
                p181.WeekdayPrice = 137.35m;
                p181.PetsAllowed = true;
                p181.ParkingFree = true;
                p181.CleaningFee = 16.62m;
                p181.Bedrooms = 7;
                p181.Bathrooms = 6;
                p181.GuestsAllowed = 6;



                p181.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "House");
                Properties.Add(p181);







                Property p182 = new Property();

                p182.ZipCode = "24886";
                p182.State = States.MN;
                p182.Street = "83787 Stuart Key";
                p182.City = "Davetown";
                p182.HostEmail = "chung@yahoo.com";
                p182.WeekendPrice = 146.75m;
                p182.WeekdayPrice = 172.99m;
                p182.PetsAllowed = true;
                p182.ParkingFree = false;
                p182.CleaningFee = 26.24m;
                p182.Bedrooms = 7;
                p182.Bathrooms = 6;
                p182.GuestsAllowed = 4;



                p182.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p182);







                Property p183 = new Property();

                p183.ZipCode = "56713";
                p183.State = States.TX;
                p183.Street = "690 Christina Park";
                p183.City = "Toddburgh";
                p183.HostEmail = "tanner@utexas.edu";
                p183.WeekendPrice = 157.96m;
                p183.WeekdayPrice = 188.53m;
                p183.PetsAllowed = false;
                p183.ParkingFree = false;
                p183.CleaningFee = 6.69m;
                p183.Bedrooms = 3;
                p183.Bathrooms = 5;
                p183.GuestsAllowed = 1;



                p183.Category = db.Categories.FirstOrDefault(c => c.CategoryType == "Cabin");
                Properties.Add(p183);

                try
                {
                    foreach (Property propertyToAdd in Properties)
                    {
                        /*strPropertyStreet = propertyToAdd.Street;
                        Property dbProperty = db.Properties.FirstOrDefault(b => b.Street == propertyToAdd.Street);
                        */
                        intPropertyID = propertyToAdd.PropertyID;
                        Property dbProperty = db.Properties.FirstOrDefault(b => b.PropertyID == propertyToAdd.PropertyID);

                        if (dbProperty == null) //this title doesn't exist
                        {
                            db.Properties.Add(propertyToAdd);
                            db.SaveChanges();
                            intPropertiesAdded += 1;
                        }
                        else //book exists - update values
                        {
                            dbProperty.Street = propertyToAdd.Street;
                            dbProperty.ZipCode = propertyToAdd.ZipCode;
                            dbProperty.State = propertyToAdd.State;
                            dbProperty.UnitNumber = propertyToAdd.UnitNumber;
                            dbProperty.City = propertyToAdd.City;
                            dbProperty.HostEmail = propertyToAdd.HostEmail;
                            dbProperty.WeekdayPrice = propertyToAdd.WeekdayPrice;
                            dbProperty.WeekendPrice = propertyToAdd.WeekendPrice;
                            dbProperty.PetsAllowed = propertyToAdd.PetsAllowed;
                            dbProperty.ParkingFree = propertyToAdd.ParkingFree;
                            dbProperty.CleaningFee = propertyToAdd.CleaningFee;
                            dbProperty.Bedrooms = propertyToAdd.Bedrooms;
                            dbProperty.Bathrooms = propertyToAdd.Bathrooms;
                            dbProperty.GuestsAllowed = propertyToAdd.GuestsAllowed;
                            db.Update(dbProperty);
                            db.SaveChanges();
                            intPropertiesAdded += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = "  Repositories added:" + intPropertiesAdded + "; Error on " + intPropertyID;
                    throw new InvalidOperationException(ex.Message + msg);
                }
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}