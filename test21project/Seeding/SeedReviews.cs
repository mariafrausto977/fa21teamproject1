using test21project.Models;
using test21project.DAL;
using System.Collections.Generic;
using System;
using System.Linq;

namespace test21project.Seeding
{
    public static class SeedReviews
    {
        public static void SeedAllReviews(AppDbContext db)
        {
            if (db.Reviews.Count() == 21)
            {
                throw new NotSupportedException("The database already contains all 21 reviews!");
            }

            Int32 intReviewsAdded = 0;
            String strReviewTitle = "Begin"; //helps to keep track of error on books
            List<Review> Reviews = new List<Review>();

            try
            {

                Review r1 = new Review();
                r1.IndividualRating = 4;

                r1.User = db.Users.FirstOrDefault(r => r.UserName == "father.Ingram@aool.com");
                r1.Property = db.Properties.FirstOrDefault(r => r.Street == "588 Alan Rest");
                Reviews.Add(r1);





                Review r2 = new Review();
                r2.IndividualRating = 3;
                r2.ReviewText = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator.";


                r2.Property = db.Properties.FirstOrDefault(r => r.Street == "1168 Gary Fords");
                r2.User = db.Users.FirstOrDefault(r => r.UserName == "orielly@foxnets.com");

                Reviews.Add(r2);


                Review r3 = new Review();
                r3.IndividualRating = 4;


                r3.Property = db.Properties.FirstOrDefault(r => r.Street == "03541 Ryan Islands ");
                r3.User = db.Users.FirstOrDefault(r => r.UserName == "father.Ingram@aool.com");

                Reviews.Add(r3);


                Review r4 = new Review();
                r4.IndividualRating = 2;



                r4.Property = db.Properties.FirstOrDefault(r => r.Street == "588 Alan Rest");
                r4.User = db.Users.FirstOrDefault(r => r.UserName == "tuck33@puppy.com");

                Reviews.Add(r4);


                Review r5 = new Review();
                r5.IndividualRating = 3;
                r5.ReviewText = "Nebraska was... interesting";


                r5.Property = db.Properties.FirstOrDefault(r => r.Street == "94102 Sims Port");
                r5.User = db.Users.FirstOrDefault(r => r.UserName == "father.Ingram@aool.com");

                Reviews.Add(r5);



                Review r6 = new Review();
                r6.IndividualRating = 1;
                r6.ReviewText = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN";


                r6.Property = db.Properties.FirstOrDefault(r => r.Street == "94102 Sims Port");
                r6.User = db.Users.FirstOrDefault(r => r.UserName == "tfreeley@puppy.com");

                Reviews.Add(r6);


                Review r7 = new Review();
                r7.IndividualRating = 1;
                r7.ReviewText = "Worst. Stay. Ever. Never using BevoBnB again";


                r7.Property = db.Properties.FirstOrDefault(r => r.Street == "94102 Sims Port");
                r7.User = db.Users.FirstOrDefault(r => r.UserName == "ra@aoo.com");

                Reviews.Add(r7);



                Review r8 = new Review();
                r8.IndividualRating = 5;


                r8.User = db.Users.FirstOrDefault(r => r.UserName == "orielly@foxnets.com");
                r8.Property = db.Properties.FirstOrDefault(r => r.Street == "693 Michael Estate");
                Reviews.Add(r8);


                Review r9 = new Review();
                r9.IndividualRating = 2;


                r9.User = db.Users.FirstOrDefault(r => r.UserName == "orielly@foxnets.com");
                r9.Property = db.Properties.FirstOrDefault(r => r.Street == "457 Vargas Island");
                Reviews.Add(r9);



                Review r10 = new Review();
                r10.IndividualRating = 1;
                r10.ReviewText = "It was SO hard to book this place. Who coded this site anyway? ;)";

                r10.User = db.Users.FirstOrDefault(r => r.UserName == "tfreeley@puppy.com");
                r10.Property = db.Properties.FirstOrDefault(r => r.Street == "693 Michael Estate");
                Reviews.Add(r10);



                Review r11 = new Review();
                r11.IndividualRating = 4;

                r11.User = db.Users.FirstOrDefault(r => r.UserName == "tuck33@puppy.com");
                r11.Property = db.Properties.FirstOrDefault(r => r.Street == "71664 Kim Throughway");
                Reviews.Add(r11);



                Review r12 = new Review();
                r12.IndividualRating = 5;
                r12.ReviewText = "This place rocked!";


                r12.User = db.Users.FirstOrDefault(r => r.UserName == "ra@aoo.com");
                r12.Property = db.Properties.FirstOrDefault(r => r.Street == "693 Michael Estate");
                Reviews.Add(r12);




                Review r13 = new Review();
                r13.IndividualRating = 4;

                r13.User = db.Users.FirstOrDefault(r => r.UserName == "fd@puppy.com");
                r13.Property = db.Properties.FirstOrDefault(r => r.Street == "693 Michael Estate");
                Reviews.Add(r13);



                Review r14 = new Review();
                r14.IndividualRating = 4;


                r14.User = db.Users.FirstOrDefault(r => r.UserName == "lamemartin.Martin@aool.com");
                r14.Property = db.Properties.FirstOrDefault(r => r.Street == "457 Vargas Island");
                Reviews.Add(r14);



                Review r15 = new Review();
                r15.IndividualRating = 1;
                r15.ReviewText = "There were 1...5...22 roaches? I lost count.";

                r15.User = db.Users.FirstOrDefault(r => r.UserName == "fd@puppy.com");
                r15.Property = db.Properties.FirstOrDefault(r => r.Street == "94102 Sims Port");
                Reviews.Add(r15);



                Review r16 = new Review();
                r16.IndividualRating = 1;


                r16.User = db.Users.FirstOrDefault(r => r.UserName == "sheff44@puppy.com");
                r16.Property = db.Properties.FirstOrDefault(r => r.Street == "1168 Gary Fords");
                Reviews.Add(r16);



                Review r17 = new Review();
                r17.IndividualRating = 4;
                r17.ReviewText = "I LOVED the place! Had a nice view of the mountains";

                r17.User = db.Users.FirstOrDefault(r => r.UserName == "fd@puppy.com");
                r17.Property = db.Properties.FirstOrDefault(r => r.Street == "1220 Heidi Rue");
                Reviews.Add(r17);




                Review r18 = new Review();
                r18.IndividualRating = 5;
                r18.ReviewText = "nan";


                r18.User = db.Users.FirstOrDefault(r => r.UserName == "tuck33@puppy.com");
                r18.Property = db.Properties.FirstOrDefault(r => r.Street == "1220 Heidi Rue");
                Reviews.Add(r18);



                Review r19 = new Review();
                r19.IndividualRating = 5;
                r19.ReviewText = "My stay was amazing! Saved my marriage";


                r19.User = db.Users.FirstOrDefault(r => r.UserName == "orielly@foxnets.com");
                r19.Property = db.Properties.FirstOrDefault(r => r.Street == "588 Alan Rest");
                Reviews.Add(r19);



                Review r20 = new Review();
                r20.IndividualRating = 2;


                r20.User = db.Users.FirstOrDefault(r => r.UserName == "sheff44@puppy.com");
                r20.Property = db.Properties.FirstOrDefault(r => r.Street == "457 Vargas Island");
                Reviews.Add(r20);




                Review r21 = new Review();
                r21.IndividualRating = 2;
                r21.ReviewText = "My wife's attitude was the only thing rougher than the sand at the nearby beaches";

                r21.User = db.Users.FirstOrDefault(r => r.UserName == "orielly@foxnets.com");
                r21.Property = db.Properties.FirstOrDefault(r => r.Street == "03541 Ryan Islands");
                Reviews.Add(r21);



                try
                {
                    foreach (Review reviewToAdd in Reviews)
                    {
                        strReviewTitle = reviewToAdd.ReviewText;
                        Review dbReview = db.Reviews.FirstOrDefault(r => r.ReviewID == reviewToAdd.ReviewID);
                        if (dbReview == null) //this title doesn't exist
                        {
                            db.Reviews.Add(reviewToAdd);
                            db.SaveChanges();
                            intReviewsAdded += 1;
                        }
                        else //book exists - update values
                        {
                            dbReview.ReviewID = reviewToAdd.ReviewID;
                            dbReview.IndividualRating = reviewToAdd.ReviewID;
                            dbReview.ReviewText = reviewToAdd.ReviewText;
                            db.Update(dbReview);
                            db.SaveChanges();
                            intReviewsAdded += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = "  Repositories added:" + intReviewsAdded + "; Error on " + strReviewTitle;
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





