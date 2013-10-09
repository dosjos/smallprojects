using System;
using System.Linq;

namespace EntityFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new ProductDb2())
            {
                var skriv = db.Categories.Add(new Category { CategoryName = "Skrivesaker" });
                var bil = db.Categories.Add(new Category { CategoryName = "Biler" });
                var drikk = db.Categories.Add(new Category { CategoryName = "Flasker" });

                db.Products.Add(new Product { Name = "Pen", Category = skriv, Price = 12 });
                db.Products.Add(new Product { Name = "Blyant", Category = skriv, Price = 26 });
                db.Products.Add(new Product { Name = "Tusj", Category = skriv, Price = 30 });

                db.Products.Add(new Product { Name = "Porce", Category = bil, Price = 200000 });
                db.Products.Add(new Product { Name = "BMW", Category = bil, Price = 1 });

                db.Products.Add(new Product { Name = "Øl", Category = drikk, Price = 20 });
                db.Products.Add(new Product { Name = "Brus", Category = drikk, Price = 21 });

                db.SaveChanges();

                foreach (var product in db.Products)
                {
                    Console.WriteLine("ProduktID = {0} - Product name = {1}", product.ProductID, product.Name);
                }
                var q = from skrive in db.Products
                        where skrive.Price > 25
                        select skrive;

                foreach (var item in q)
                {
                    Console.WriteLine("ProduktID = {0} - Product name = {1}", item.ProductID, item.Name);
                }

                var ball = db.Products.Where(m => m.Name == "Tusj");
                foreach (var item in ball)
                {
                    db.Products.Remove(item);
                }
                db.SaveChanges();

                Console.WriteLine("press enter...");
                Console.ReadLine();
            }
        }
    }
}
