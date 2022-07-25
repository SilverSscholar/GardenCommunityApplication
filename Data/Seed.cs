using GardenCommunityApplication.Data.Enum;
using GardenCommunityApplication.Models;

namespace GardenCommunityApplication.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.GardeningClubs.Any())
                {
                    context.GardeningClubs.AddRange(new List<GardeningClub>()
                    {
                        new GardeningClub()
                        {
                            Title = "Beginner's Garden",
                            Image = "https://images.pexels.com/photos/2987081/pexels-photo-2987081.jpeg?cs=srgb&dl=pexels-huy-phan-2987081.jpg&fm=jpg",
                            Description = "This Gardening Club focuses on introducing beginners to gardening.",
                            GardeningClubCategory = GardeningClubCategory.Beginner_Gardens,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Louisville",
                                State = "KY"
                            }
                         },
                        new GardeningClub()
                        {
                            Title = "Tiny Terraces",
                            Image = "https://images.pexels.com/photos/2987081/pexels-photo-2987081.jpeg?cs=srgb&dl=pexels-huy-phan-2987081.jpg&fm=jpg",
                            Description = "This club focuses on gardens in small areas, such as rooftop terraces, balconys, apartment windows.",
                            GardeningClubCategory = GardeningClubCategory.Tiny_Terraces,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Louisville",
                                State = "KY"
                            }
                        },
                        new GardeningClub()
                        {
                            Title = "Lay of the Land",
                            Image = "https://images.pexels.com/photos/2987081/pexels-photo-2987081.jpeg?cs=srgb&dl=pexels-huy-phan-2987081.jpg&fm=jpg",
                            Description = "This club focuses on gardens used in day to day consumption, and production",
                            GardeningClubCategory = GardeningClubCategory.Homesteading,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Louisville",
                                State = "KY"
                            }
                        },
                        new GardeningClub()
                        {
                            Title = "Winding Roads Club",
                            Image = "https://images.pexels.com/photos/2987081/pexels-photo-2987081.jpeg?cs=srgb&dl=pexels-huy-phan-2987081.jpg&fm=jpg",
                            Description = "This is a club for flowery alleyways that member's upkeep in their community.",
                            GardeningClubCategory = GardeningClubCategory.Floral_Alleys,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Louisville",
                                State = "KY"
                            }
                        }
                    });
                    context.SaveChanges();
                }

                //Races
                if (!context.GardenContests.Any())
                {
                    context.GardenContests.AddRange(new List<GardenContest>()
                    {
                        new GardenContest()
                        {
                            Title = "Little Green Thumbs",
                            Image = "https://www.foegleylandscape.com/wp-content/uploads/2015/05/Foegley_Landscaping_Ornamental_and_Formal_Gardens3.jpg",
                            Description = "This contest is for gardener's from the ages of 3-12 to show off their gardens, and skills.",
                            GardenContestCategory = GardenContestCategory.Young_Gardeners,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Louisville",
                                State = "KY"
                            }
                        },
                        new GardenContest()
                        {
                            Title = "Down Your Street",
                            Image = "https://www.foegleylandscape.com/wp-content/uploads/2015/05/Foegley_Landscaping_Ornamental_and_Formal_Gardens3.jpg",
                            Description = "This is a contest that focuses on the appearances of gardens you may see down your block.",
                            GardenContestCategory = GardenContestCategory.Best_Blocks,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Louisville",
                                State = "KY"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

