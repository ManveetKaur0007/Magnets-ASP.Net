using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ManveetKaurMagnets.Data;
using System;
using System.Linq;

namespace ManveetKaurMagnets.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ManveetKaurMagnetsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ManveetKaurMagnetsContext>>()))
            {
                // Look for any movies.
                if (context.Magnets.Any())
                {
                    return;   // DB has been seeded
                }

                context.Magnets.AddRange(
                    new Magnets
                    {
                        Shape = "Bar",
                        Colour = "Blue",
                        Type = "Iron",
                        Power = 10,
                        CustomerReview = "Satisfied"
                    },

                    new Magnets
                    {
                        Shape = "Sphere",
                        Colour = "Black",
                        Type = "Aluminum",
                        Power = 5,
                        CustomerReview = "Needs Improvment"
                    },

                    new Magnets
                    {
                        Shape = "Balls",
                        Colour = "Pink",
                        Type = "Steel",
                        Power = 7,
                        CustomerReview = "Good"
                    },

                    new Magnets
                    {
                        Shape = "Ring",
                        Colour = "Green",
                        Type = "Plastic",
                        Power = 0,
                        CustomerReview = "Discontinue it!"
                    },
                    
                    new Magnets
                    {
                        Shape = "Cylinder",
                        Colour = "Purple",
                        Type = "Iron",
                        Power = 8,
                        CustomerReview = "Good"
                    },

                    new Magnets
                    {
                        Shape = "Disc",
                        Colour = "Brown",
                        Type = "Silver",
                        Power = 6,
                        CustomerReview = "Excellent"
                    },
                    new Magnets
                    {
                        Shape = "Ring",
                        Colour = "White",
                        Type = "Plastic",
                        Power = 1,
                        CustomerReview = "Discontinue it!"
                    },
                    new Magnets
                    {
                        Shape = "Bar",
                        Colour = "Orange",
                        Type = "Aluminium",
                        Power = 7,
                        CustomerReview = "Good"
                    },
                    new Magnets
                    {
                        Shape = "Horse",
                        Colour = "Dark Green",
                        Type = "Plastic",
                        Power = 0,
                        CustomerReview = "Discontinue it!"
                    },
                    new Magnets
                    {
                        Shape = "Cylinder",
                        Colour = "Blue",
                        Type = "Steel",
                        Power = 7,
                        CustomerReview = "Needs a little improvment"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}