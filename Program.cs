using System;
using System.Linq;
using MyApp.models;

namespace MySqlSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                // Ensure database is created
                db.Database.EnsureCreated();

                // Add a new product
                var product = new Product { Name = "Sample Product", Price = 9.99m };
                db.Products.Add(product);
                db.SaveChanges();

                // Display all products
                var products = db.Products.ToList();
                foreach (var p in products)
                {
                    Console.WriteLine($"Product: {p.Name}, Price: {p.Price}");
                }
            }
        }
    }
}
