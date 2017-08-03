using ShoppingCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.Data.EF
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
            {
               new Category {Name = "Coffee", Description="Coffee", Products = new Product[] { new Product { Name = "Dark Roast", Description = "Dark Roast", Price = 2.0M } } },
               new Category {Name = "Tea", Description="Tea", Products = new Product[] { new Product { Name = "Chai", Description = "Chai", Price = 1.5M } } },
               new Category {Name = "Pastry", Description="Pastry", Products = new Product[] { new Product { Name = "Cupcake", Description = "Cupcake", Price = 1.25M } } },
               new Category {Name = "Food", Description = "Food", Products = new Product[] { new Product  { Name = "Hamburger", Description = "Hamburger", Price = 5.0M } } }
            };

            foreach (var c in categories)
            {
                context.Categories.Add(c);

            }
            context.SaveChanges();
        }
    }
}
