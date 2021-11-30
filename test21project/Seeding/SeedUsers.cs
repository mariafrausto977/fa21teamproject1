using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using test21project.Models;
using test21project.Utilities;
using test21project.DAL;
using System.Threading.Tasks;

namespace test21project.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "cbaker@freezing.co.uk",
                    Email = "cbaker@freezing.co.uk",
                    LastName = "Baker",
                    FirstName = "Christopher",
                    MI = "L",
                    Address = "1245 Lake America Blvd.",
                    ZipCode = "78733",
                    PhoneNumber = "5125595133",
                    Birthday = new DateTime(1968, 11, 28),
                    IsActive = true,
                },

                Password = "hellothere",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "mb@puppy.com",
                    Email = "mb@puppy.com",
                    LastName = "Bradicus",
                    FirstName = "Michelle",
                    MI = "Q",
                    Address = "1300 Small Pine Lane",
                    ZipCode = "78261",
                    PhoneNumber = "2102702860",
                    Birthday = new DateTime(1988, 2, 7),
                    IsActive = true,
                },

                Password = "555533",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "fd@puppy.com",
                    Email = "fd@puppy.com",
                    LastName = "Broccoli",
                    FirstName = "Franco",
                    MI = "V",
                    Address = "62 Cookie Rd",
                    ZipCode = "77019",
                    PhoneNumber = "8175683686",
                    Birthday = new DateTime(1999, 11, 7),
                    IsActive = true,
                },

                Password = "666645",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "wendy@puppy.com",
                    Email = "wendy@puppy.com",
                    LastName = "Charile",
                    FirstName = "Wendy",
                    MI = "L",
                    Address = "202 Bellmoth Hall",
                    ZipCode = "78713",
                    PhoneNumber = "5125967209",
                    Birthday = new DateTime(1992, 10, 27),
                    IsActive = true,
                },

                Password = "Kansas",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "limchou@puppy.com",
                    Email = "limchou@puppy.com",
                    LastName = "Chou",
                    FirstName = "Lim",
                    MI = "Q",
                    Address = "1600 Barbara Lane",
                    ZipCode = "78266",
                    PhoneNumber = "2107748586",
                    Birthday = new DateTime(1961, 11, 11),
                    IsActive = true,
                },

                Password = "Rockwall",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "444444.Dave@aool.com",
                    Email = "444444.Dave@aool.com",
                    LastName = "Dave",
                    FirstName = "Shan",
                    MI = "D",
                    Address = "234 Puppy Circle",
                    ZipCode = "75208",
                    PhoneNumber = "2142667242",
                    Birthday = new DateTime(1972, 12, 19),
                    IsActive = true,
                },

                Password = "444444",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "louann@puppy.com",
                    Email = "louann@puppy.com",
                    LastName = "Feeley",
                    FirstName = "Lou Ann",
                    MI = "K",
                    Address = "700 S 9th Street W",
                    ZipCode = "77010",
                    PhoneNumber = "8172580736",
                    Birthday = new DateTime(1958, 8, 1),
                    IsActive = true,
                },

                Password = "longhorns",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "tfreeley@puppy.com",
                    Email = "tfreeley@puppy.com",
                    LastName = "Freeley",
                    FirstName = "Tesa",
                    MI = "P",
                    Address = "4334 Meanview Ave.",
                    ZipCode = "77009",
                    PhoneNumber = "8173279674",
                    Birthday = new DateTime(2001, 7, 12),
                    IsActive = true,
                },

                Password = "puppies",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "mgar@puppy.com",
                    Email = "mgar@puppy.com",
                    LastName = "Garcia",
                    FirstName = "Margaret",
                    MI = "L",
                    Address = "594 Puppyview",
                    ZipCode = "77003",
                    PhoneNumber = "8176617531",
                    Birthday = new DateTime(1956, 11, 17),
                    IsActive = true,
                },

                Password = "horses",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    LastName = "Harley",
                    FirstName = "Charles",
                    MI = "E",
                    Address = "One Ranger Pkwy",
                    ZipCode = "75261",
                    PhoneNumber = "2148499570",
                    Birthday = new DateTime(1998, 5, 29),
                    IsActive = true,
                },

                Password = "mycats",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "jeff@puppy.com",
                    Email = "jeff@puppy.com",
                    LastName = "Stark",
                    FirstName = "Jeffrey",
                    MI = "T",
                    Address = "337 40th St.",
                    ZipCode = "78705",
                    PhoneNumber = "5127002600",
                    Birthday = new DateTime(1974, 5, 2),
                    IsActive = true,
                },

                Password = "jeffery",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "wjhearniii@umch.edu",
                    Email = "wjhearniii@umch.edu",
                    LastName = "Hearn",
                    FirstName = "John",
                    MI = "B",
                    Address = "4445 South First",
                    ZipCode = "75237",
                    PhoneNumber = "2148989608",
                    Birthday = new DateTime(1983, 12, 29),
                    IsActive = true,
                },

                Password = "posicles",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "hicks43@puppy.com",
                    Email = "hicks43@puppy.com",
                    LastName = "Hicks",
                    FirstName = "Mark",
                    MI = "J",
                    Address = "32 NE Mark Ln., Ste 910",
                    ZipCode = "78239",
                    PhoneNumber = "2105812952",
                    Birthday = new DateTime(1989, 12, 16),
                    IsActive = true,
                },

                Password = "guac45",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "bradsingram@mall.utexas.edu",
                    Email = "bradsingram@mall.utexas.edu",
                    LastName = "Ingram",
                    FirstName = "Brad",
                    MI = "S",
                    Address = "6548 La Chess St.",
                    ZipCode = "78736",
                    PhoneNumber = "5124702808",
                    Birthday = new DateTime(1958, 9, 18),
                    IsActive = true,
                },

                Password = "father",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "father.Ingram@aool.com",
                    Email = "father.Ingram@aool.com",
                    LastName = "Jacobs",
                    FirstName = "Todd",
                    MI = "L",
                    Address = "4564 Palm St.",
                    ZipCode = "78731",
                    PhoneNumber = "5124677352",
                    Birthday = new DateTime(1975, 12, 9),
                    IsActive = true,
                },

                Password = "555897",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "victoria@puppy.com",
                    Email = "victoria@puppy.com",
                    LastName = "Lawrence",
                    FirstName = "Victoria",
                    MI = "M",
                    Address = "6639 Butterfly Ln.",
                    ZipCode = "78761",
                    PhoneNumber = "5129481386",
                    Birthday = new DateTime(1981, 5, 29),
                    IsActive = true,
                },

                Password = "something",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "lineback@flush.net",
                    Email = "lineback@flush.net",
                    LastName = "Lineback",
                    FirstName = "Brad",
                    MI = "W",
                    Address = "1300 Pirateland St",
                    ZipCode = "78293",
                    PhoneNumber = "2102473963",
                    Birthday = new DateTime(1973, 5, 19),
                    IsActive = true,
                },

                Password = "treelover",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",
                    LastName = "Lowe",
                    FirstName = "Evan",
                    MI = "S",
                    Address = "3201 Pineapple Drive",
                    ZipCode = "78279",
                    PhoneNumber = "2105368614",
                    Birthday = new DateTime(1993, 6, 7),
                    IsActive = true,
                },

                Password = "headear",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "luce_chuck@puppy.com",
                    Email = "luce_chuck@puppy.com",
                    LastName = "Luce",
                    FirstName = "Chuck",
                    MI = "B",
                    Address = "2345 Silent Clouds",
                    ZipCode = "78268",
                    PhoneNumber = "2107007535",
                    Birthday = new DateTime(1995, 6, 11),
                    IsActive = true,
                },

                Password = "gooseyloosey",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "mackcloud@pimpdaddy.com",
                    Email = "mackcloud@pimpdaddy.com",
                    LastName = "MacLeod",
                    FirstName = "Jennifer",
                    MI = "D",
                    Address = "2504 Far East Blvd.",
                    ZipCode = "78731",
                    PhoneNumber = "5124772125",
                    Birthday = new DateTime(1965, 10, 11),
                    IsActive = true,
                },

                Password = "rainyday",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "liz@puppy.com",
                    Email = "liz@puppy.com",
                    LastName = "Markham",
                    FirstName = "Elizabeth",
                    MI = "P",
                    Address = "7861 Chevy Mace Rd",
                    ZipCode = "78732",
                    PhoneNumber = "5124603832",
                    Birthday = new DateTime(1989, 6, 18),
                    IsActive = true,
                },

                Password = "ember22",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "mclarence@puppy.com",
                    Email = "mclarence@puppy.com",
                    LastName = "Martin",
                    FirstName = "Clarence",
                    MI = "A",
                    Address = "87 Alcedo St.",
                    ZipCode = "77045",
                    PhoneNumber = "8174979188",
                    Birthday = new DateTime(1984, 4, 28),
                    IsActive = true,
                },

                Password = "lamemartin",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "lamemartin.Martin@aool.com",
                    Email = "lamemartin.Martin@aool.com",
                    LastName = "Martinez",
                    FirstName = "Gregory",
                    MI = "R",
                    Address = "8295 Moon Blvd.",
                    ZipCode = "77030",
                    PhoneNumber = "8178770705",
                    Birthday = new DateTime(1981, 12, 27),
                    IsActive = true,
                },

                Password = "gregory",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "cmiller@mapster.com",
                    Email = "cmiller@mapster.com",
                    LastName = "Miller",
                    FirstName = "Charles",
                    MI = "R",
                    Address = "8962 Side St.",
                    ZipCode = "77031",
                    PhoneNumber = "8177482602",
                    Birthday = new DateTime(1987, 5, 5),
                    IsActive = true,
                },

                Password = "mucky44",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "nelson.Kelly@puppy.com",
                    Email = "nelson.Kelly@puppy.com",
                    LastName = "Nelson",
                    FirstName = "Kelly",
                    MI = "T",
                    Address = "2601 Green River",
                    ZipCode = "78703",
                    PhoneNumber = "5122950953",
                    Birthday = new DateTime(1969, 8, 3),
                    IsActive = true,
                },

                Password = "Tree34",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "jojoe@puppy.com",
                    Email = "jojoe@puppy.com",
                    LastName = "Nguyen",
                    FirstName = "Joe",
                    MI = "C",
                    Address = "1249 4th NW St.",
                    ZipCode = "75238",
                    PhoneNumber = "2143149884",
                    Birthday = new DateTime(1956, 2, 6),
                    IsActive = true,
                },

                Password = "jvb485bg",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",
                    LastName = "O'Reilly",
                    FirstName = "Bill",
                    MI = "T",
                    Address = "8800 Gringo Drive",
                    ZipCode = "78260",
                    PhoneNumber = "2103474912",
                    Birthday = new DateTime(1989, 3, 14),
                    IsActive = true,
                },

                Password = "Bobbygirl",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "or@puppy.com",
                    Email = "or@puppy.com",
                    LastName = "Radkovich",
                    FirstName = "Anka",
                    MI = "L",
                    Address = "1300 Freaky",
                    ZipCode = "75260",
                    PhoneNumber = "2142369553",
                    Birthday = new DateTime(1952, 10, 26),
                    IsActive = true,
                },

                Password = "radioactive",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",
                    LastName = "Rhodes",
                    FirstName = "Megan",
                    MI = "C",
                    Address = "4587 Rightfield Rd.",
                    ZipCode = "78707",
                    PhoneNumber = "5123768733",
                    Birthday = new DateTime(1958, 3, 18),
                    IsActive = true,
                },

                Password = "gopigs",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "erynrice@puppy.com",
                    Email = "erynrice@puppy.com",
                    LastName = "Rice",
                    FirstName = "Eryn",
                    MI = "M",
                    Address = "3405 Rio Small",
                    ZipCode = "78705",
                    PhoneNumber = "5123900644",
                    Birthday = new DateTime(2000, 11, 2),
                    IsActive = true,
                },

                Password = "iloveme",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "jorge@hootmail.com",
                    Email = "jorge@hootmail.com",
                    LastName = "Rodriguez",
                    FirstName = "Jorge",
                    MI = "nan",
                    Address = "6788 Cotten Street",
                    ZipCode = "77057",
                    PhoneNumber = "8178928361",
                    Birthday = new DateTime(1979, 1, 1),
                    IsActive = true,
                },

                Password = "565656",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",
                    LastName = "Rogers",
                    FirstName = "Allen",
                    MI = "B",
                    Address = "4965 Rabbit Hill",
                    ZipCode = "78732",
                    PhoneNumber = "5128776930",
                    Birthday = new DateTime(2000, 3, 12),
                    IsActive = true,
                },

                Password = "treeman",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "o_st-jean@home.com",
                    Email = "o_st-jean@home.com",
                    LastName = "Saint-Jean",
                    FirstName = "Olivier",
                    MI = "M",
                    Address = "255 Slap Dr.",
                    ZipCode = "78292",
                    PhoneNumber = "2104169665",
                    Birthday = new DateTime(1997, 5, 1),
                    IsActive = true,
                },

                Password = "55htrq",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "ss34@puppy.com",
                    Email = "ss34@puppy.com",
                    LastName = "Saunders",
                    FirstName = "Sarah",
                    MI = "J",
                    Address = "332 Fish C",
                    ZipCode = "78705",
                    PhoneNumber = "5123521797",
                    Birthday = new DateTime(1994, 5, 31),
                    IsActive = true,
                },

                Password = "leaves",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "willsheff@email.com",
                    Email = "willsheff@email.com",
                    LastName = "Sewell",
                    FirstName = "William",
                    MI = "T",
                    Address = "2365 34st St.",
                    ZipCode = "78709",
                    PhoneNumber = "5124534071",
                    Birthday = new DateTime(1951, 12, 10),
                    IsActive = true,
                },

                Password = "borbj44",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "sheff44@puppy.com",
                    Email = "sheff44@puppy.com",
                    LastName = "Sheffield",
                    FirstName = "Martin",
                    MI = "J",
                    Address = "3886 Road A",
                    ZipCode = "78705",
                    PhoneNumber = "5125503154",
                    Birthday = new DateTime(1993, 7, 2),
                    IsActive = true,
                },

                Password = "ldiul485",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "johnsmith187@puppy.com",
                    Email = "johnsmith187@puppy.com",
                    LastName = "Smith",
                    FirstName = "John",
                    MI = "A",
                    Address = "23 Known Forge Dr.",
                    ZipCode = "78280",
                    PhoneNumber = "2108345875",
                    Birthday = new DateTime(1985, 6, 13),
                    IsActive = true,
                },

                Password = "kribv75",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "dustroud@mail.com",
                    Email = "dustroud@mail.com",
                    LastName = "Stroud",
                    FirstName = "Dustin",
                    MI = "P",
                    Address = "1212 Henrietta Rd",
                    ZipCode = "75221",
                    PhoneNumber = "2142370654",
                    Birthday = new DateTime(1974, 7, 14),
                    IsActive = true,
                },

                Password = "klavjkb48",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "eric_stuart@puppy.com",
                    Email = "eric_stuart@puppy.com",
                    LastName = "Stuart",
                    FirstName = "Eric",
                    MI = "D",
                    Address = "5576 Big Ring",
                    ZipCode = "78746",
                    PhoneNumber = "5128202322",
                    Birthday = new DateTime(1968, 6, 17),
                    IsActive = true,
                },

                Password = "vkb451",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",
                    LastName = "Stump",
                    FirstName = "Peter",
                    MI = "L",
                    Address = "1300 Kellen Square",
                    ZipCode = "77018",
                    PhoneNumber = "8174584890",
                    Birthday = new DateTime(2001, 7, 23),
                    IsActive = true,
                },

                Password = "kdsiu4",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "tanner@puppy.com",
                    Email = "tanner@puppy.com",
                    LastName = "Tanner",
                    FirstName = "Jeremy",
                    MI = "S",
                    Address = "4347 Palmstead",
                    ZipCode = "77044",
                    PhoneNumber = "8174614916",
                    Birthday = new DateTime(1973, 12, 28),
                    IsActive = true,
                },

                Password = "klrfbj45",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "taylordjay@puppy.com",
                    Email = "taylordjay@puppy.com",
                    LastName = "Taylor",
                    FirstName = "Allison",
                    MI = "R",
                    Address = "467 Nueces St.",
                    ZipCode = "78705",
                    PhoneNumber = "5124772439",
                    Birthday = new DateTime(1999, 9, 30),
                    IsActive = true,
                },

                Password = "lraggrhb854",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "lraggrhb854.Taylor@aool.com",
                    Email = "lraggrhb854.Taylor@aool.com",
                    LastName = "Taylor",
                    FirstName = "Rachel",
                    MI = "K",
                    Address = "345 Shortview Dr.",
                    ZipCode = "78705",
                    PhoneNumber = "5124536618",
                    Birthday = new DateTime(1956, 2, 24),
                    IsActive = true,
                },

                Password = "alsuib95",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "tee_frank@hootmail.com",
                    Email = "tee_frank@hootmail.com",
                    LastName = "Tee",
                    FirstName = "Frank",
                    MI = "J",
                    Address = "5590 Big Dr.",
                    ZipCode = "77004",
                    PhoneNumber = "8178789530",
                    Birthday = new DateTime(1964, 11, 11),
                    IsActive = true,
                },

                Password = "kd1734",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "tuck33@puppy.com",
                    Email = "tuck33@puppy.com",
                    LastName = "Tucker",
                    FirstName = "Clent",
                    MI = "J",
                    Address = "3132 Main St.",
                    ZipCode = "75315",
                    PhoneNumber = "2148495141",
                    Birthday = new DateTime(1990, 6, 25),
                    IsActive = true,
                },

                Password = "kjdb983",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "avelasco@puppy.com",
                    Email = "avelasco@puppy.com",
                    LastName = "Velasco",
                    FirstName = "Allen",
                    MI = "G",
                    Address = "634 W. 4th",
                    ZipCode = "75207",
                    PhoneNumber = "2144009625",
                    Birthday = new DateTime(1966, 12, 13),
                    IsActive = true,
                },

                Password = "odrb02",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "westj@pioneer.net",
                    Email = "westj@pioneer.net",
                    LastName = "West",
                    FirstName = "Jake",
                    MI = "T",
                    Address = "RR 3244",
                    ZipCode = "75323",
                    PhoneNumber = "2148499231",
                    Birthday = new DateTime(1968, 2, 6),
                    IsActive = true,
                },

                Password = "kndl847",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "louielouie@puppy.com",
                    Email = "louielouie@puppy.com",
                    LastName = "Winthorpe",
                    FirstName = "Louis",
                    MI = "L",
                    Address = "2500 Madre Blvd",
                    ZipCode = "78746",
                    PhoneNumber = "2145674085",
                    Birthday = new DateTime(1961, 7, 23),
                    IsActive = true,
                },

                Password = "lb2394",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "rwood@voyager.net",
                    Email = "rwood@voyager.net",
                    LastName = "Wood",
                    FirstName = "Reagan",
                    MI = "B",
                    Address = "447 Westlake Dr.",
                    ZipCode = "78746",
                    PhoneNumber = "5124569229",
                    Birthday = new DateTime(1988, 10, 24),
                    IsActive = true,
                },

                Password = "drai494",
                RoleName = "Customer",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "taylor@bevobnb.com",
                    Email = "taylor@bevobnb.com",
                    LastName = "Taylor",
                    FirstName = "Albert",
                    MI = "F",
                    Address = "467 Nueces St.",
                    ZipCode = "75237",
                    PhoneNumber = "2149036025",
                    Birthday = new DateTime(1954, 8, 14),
                    IsActive = true,
                },

                Password = "TRY563",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "sheffield@bevobnb.com",
                    Email = "sheffield@bevobnb.com",
                    LastName = "Sheffield",
                    FirstName = "Molly",
                    MI = "R",
                    Address = "3886 Avenue A",
                    ZipCode = "78736",
                    PhoneNumber = "5124749225",
                    Birthday = new DateTime(1986, 8, 27),
                    IsActive = true,
                },

                Password = "longsnores",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "macleod@bevobnb.com",
                    Email = "macleod@bevobnb.com",
                    LastName = "MacLeod",
                    FirstName = "Jenny",
                    MI = "I",
                    Address = "2504 Far West Blvd.",
                    ZipCode = "78731",
                    PhoneNumber = "5124723769",
                    Birthday = new DateTime(1984, 12, 5),
                    IsActive = true,
                },

                Password = "kittys",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "rhodes@bevobnb.com",
                    Email = "rhodes@bevobnb.com",
                    LastName = "Rhodes",
                    FirstName = "Michelle",
                    MI = "N",
                    Address = "4587 Enfield Rd.",
                    ZipCode = "78293",
                    PhoneNumber = "2102520380",
                    Birthday = new DateTime(1972, 7, 2),
                    IsActive = true,
                },

                Password = "puppies",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "stuart@bevobnb.com",
                    Email = "stuart@bevobnb.com",
                    LastName = "Stuart",
                    FirstName = "Evan",
                    MI = "Q",
                    Address = "5576 Toro Ring",
                    ZipCode = "78279",
                    PhoneNumber = "2105415031",
                    Birthday = new DateTime(1984, 4, 17),
                    IsActive = true,
                },

                Password = "coolboi",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "swanson@bevobnb.com",
                    Email = "swanson@bevobnb.com",
                    LastName = "Swanson",
                    FirstName = "Ron",
                    MI = "P",
                    Address = "245 River Rd",
                    ZipCode = "78731",
                    PhoneNumber = "5124818542",
                    Birthday = new DateTime(1991, 7, 25),
                    IsActive = true,
                },

                Password = "swanbong",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "white@bevobnb.com",
                    Email = "white@bevobnb.com",
                    LastName = "White",
                    FirstName = "Jabriel",
                    MI = "M",
                    Address = "12 Valley View",
                    ZipCode = "77045",
                    PhoneNumber = "8175025605",
                    Birthday = new DateTime(1986, 3, 17),
                    IsActive = true,
                },

                Password = "456789",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "montgomery@bevobnb.com",
                    Email = "montgomery@bevobnb.com",
                    LastName = "Montgomery",
                    FirstName = "Washington",
                    MI = "X",
                    Address = "210 Blanco Dr",
                    ZipCode = "77030",
                    PhoneNumber = "8178817122",
                    Birthday = new DateTime(1961, 5, 4),
                    IsActive = true,
                },

                Password = "python4",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "walker@bevobnb.com",
                    Email = "walker@bevobnb.com",
                    LastName = "Walker",
                    FirstName = "Lisa",
                    MI = "O",
                    Address = "9 Bison Circle",
                    ZipCode = "75238",
                    PhoneNumber = "2143196301",
                    Birthday = new DateTime(2003, 4, 18),
                    IsActive = true,
                },

                Password = "walkameter",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "chang@bevobnb.com",
                    Email = "chang@bevobnb.com",
                    LastName = "Chang",
                    FirstName = "Gregory",
                    MI = "J",
                    Address = "9003 Joshua St",
                    ZipCode = "78260",
                    PhoneNumber = "2103521329",
                    Birthday = new DateTime(1958, 4, 26),
                    IsActive = true,
                },

                Password = "pupgang",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "derek@bevobnb.com",
                    Email = "derek@bevobnb.com",
                    LastName = "Dreibrodt",
                    FirstName = "Derek",
                    MI = "X",
                    Address = "4 Privet Dr",
                    ZipCode = "78705",
                    PhoneNumber = "5125556789",
                    Birthday = new DateTime(2001, 1, 1),
                    IsActive = true,
                },

                Password = "2cool4u",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "rester@bevobnb.com",
                    Email = "rester@bevobnb.com",
                    LastName = "Rester",
                    FirstName = "Amy",
                    MI = "K",
                    Address = "2110 Speedway",
                    ZipCode = "78705",
                    PhoneNumber = "2103521329",
                    Birthday = new DateTime(2000, 1, 1),
                    IsActive = true,
                },

                Password = "KIzGreat",
                RoleName = "Admin",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "jacobs@yahoo.com",
                    Email = "jacobs@yahoo.com",
                    LastName = "Jacobs",
                    FirstName = "Todd",
                    MI = "L",
                    Address = "4564 Elm St.",
                    ZipCode = "77003",
                    PhoneNumber = "8176663948",
                    Birthday = new DateTime(1978, 1, 29),
                    IsActive = true,
                },

                Password = "tj2245",
                RoleName = "Host",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "rice@yahoo.com",
                    Email = "rice@yahoo.com",
                    LastName = "Rice",
                    FirstName = "Eryn",
                    MI = "M",
                    Address = "3405 Rio Grande",
                    ZipCode = "75261",
                    PhoneNumber = "2148545987",
                    Birthday = new DateTime(2003, 6, 11),
                    IsActive = true,
                },

                Password = "ricearoni",
                RoleName = "Host",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "ingram@gmail.com",
                    Email = "ingram@gmail.com",
                    LastName = "Ingram",
                    FirstName = "John",
                    MI = "R",
                    Address = "6548 La Posada Ct.",
                    ZipCode = "78705",
                    PhoneNumber = "5127049017",
                    Birthday = new DateTime(1980, 6, 25),
                    IsActive = true,
                },

                Password = "ingram68",
                RoleName = "Host",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "martinez@aol.com",
                    Email = "martinez@aol.com",
                    LastName = "Martinez",
                    FirstName = "Paul",
                    MI = "G",
                    Address = "8295 Sunset Blvd.",
                    ZipCode = "78239",
                    PhoneNumber = "2105859369",
                    Birthday = new DateTime(1969, 6, 25),
                    IsActive = true,
                },

                Password = "party1",
                RoleName = "Host",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "tanner@utexas.edu",
                    Email = "tanner@utexas.edu",
                    LastName = "Tanner",
                    FirstName = "Jared",
                    MI = "F",
                    Address = "4347 Almstead",
                    ZipCode = "78761",
                    PhoneNumber = "5129527803",
                    Birthday = new DateTime(1979, 6, 2),
                    IsActive = true,
                },

                Password = "sandman",
                RoleName = "Host",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "chung@yahoo.com",
                    Email = "chung@yahoo.com",
                    LastName = "Chung",
                    FirstName = "Lauren",
                    MI = "R",
                    Address = "234 RR 12",
                    ZipCode = "78268",
                    PhoneNumber = "2107053952",
                    Birthday = new DateTime(1976, 3, 24),
                    IsActive = true,
                },

                Password = "listen",
                RoleName = "Host",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "loter@yahoo.com",
                    Email = "loter@yahoo.com",
                    LastName = "Loter",
                    FirstName = "Wandavison",
                    MI = "T",
                    Address = "3453 RR 3235",
                    ZipCode = "78732",
                    PhoneNumber = "5124650249",
                    Birthday = new DateTime(1966, 9, 23),
                    IsActive = true,
                },

                Password = "pottery",
                RoleName = "Host",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "morales@aol.com",
                    Email = "morales@aol.com",
                    LastName = "Morales",
                    FirstName = "Heather",
                    MI = "R",
                    Address = "4501 RR 140",
                    ZipCode = "77031",
                    PhoneNumber = "8177529019",
                    Birthday = new DateTime(1971, 1, 16),
                    IsActive = true,
                },

                Password = "heckin",
                RoleName = "Host",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "rankin@yahoo.com",
                    Email = "rankin@yahoo.com",
                    LastName = "Rankin",
                    FirstName = "Martin",
                    MI = "P",
                    Address = "340 Second St",
                    ZipCode = "78703",
                    PhoneNumber = "5122997370",
                    Birthday = new DateTime(1961, 5, 16),
                    IsActive = true,
                },

                Password = "rankmark",
                RoleName = "Host",

            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser
                {
                    UserName = "gonzalez@aol.com",
                    Email = "gonzalez@aol.com",
                    LastName = "Gonzalez",
                    FirstName = "Garth",
                    MI = "R",
                    Address = "103 Manor Rd",
                    ZipCode = "75260",
                    PhoneNumber = "2142415970",
                    Birthday = new DateTime(1993, 12, 10),
                    IsActive = true,
                },

                Password = "gg2017",
                RoleName = "Host",

            });
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + errorFlag, ex);
            }

            return result;
        }
    }
}