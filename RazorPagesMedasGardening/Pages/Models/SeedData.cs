


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;

namespace RazorPagesGarden.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesGardenContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesGardenContext>>()))
            {
                // Look for any movies.
                if (context.Garden.Any())
                {
                    return;   // DB has been seeded
                }

                context.Garden.AddRange(
                    new Garden
                    {
                        
                        Title = "Flower Dome",
                        plantingDate = DateTime.Parse("1989-2-12"),
                       TypeOfGarden ="flowers",
                        PriceOfSeeds  = 10.99M
                    },

                    new Garden
                    {
                       Title= "Tree Farm ",
                       plantingDate= DateTime.Parse("1984-3-13"),
                      TypeOfGarden= "Fruits,Vegetables",
                       PriceOfSeeds = 8.99M
                    },

                    new Garden
                    {
                        Title = "Gain Green",
                        plantingDate = DateTime.Parse("1986-2-23"),
                      TypeOfGarden = "Herbs",
                        PriceOfSeeds  = 9.99M
                    },

                    new Garden
                    {
                        Title= "Enchant Gardens",
                        plantingDate = DateTime.Parse("1959-4-15"),
                        TypeOfGarden = "Fruit Orchards",
                        PriceOfSeeds  = 10.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
