using Microsoft.EntityFrameworkCore;
using RazorPagesNars.Data;

namespace RazorPagesNars.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesNarsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesNarsContext>>()))
            {
                if (context == null || context.Food == null)
                {
                    throw new ArgumentNullException("Null RazorPagesNarsContext");
                }
                if (context.Food.Any())
                {
                    return;
                }
                context.Food.AddRange(
                    new Food
                    {
                        Name = "Burger",
                        DateofAvailability = DateTime.Parse("2022-03-13"),
                        Price = 1.99M
                    },
                    new Food
                    {
                        Name = "Pizza",
                        DateofAvailability = DateTime.Parse("2022-03-14"),
                        Price = 3.99M
                    },
                    new Food
                    {
                        Name = "Sphagetti",
                        DateofAvailability = DateTime.Parse("2022-03-15"),
                        Price = 2.99M
                    },
                    new Food
                    {
                        Name = "Fried Chicken",
                        DateofAvailability = DateTime.Parse("2022-03-16"),
                        Price = 2.99M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}

