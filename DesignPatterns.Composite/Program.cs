using System;
using DesignPatterns.Composite.Concretes;

namespace DesignPatterns.Composite
{
    // Pode ser usado quando existirem estruturas hierarquicas onde cada elemento filho
    // é do próprio tipo do elemento pai. (auto-referencia)
    class Program
    {
        static void Main(string[] args)
        {
            Product book = new Product { Name = "Book", Price = 20, Category = "Fantasy" };
            Product laptop = new Product { Name = "Laptop", Price = 500, Category = "Hardware" };
            Product monitor = new Product { Name = "Monitor", Price = 80, Category = "Monitors" };

            Combo techCombo = new Combo { Name = "Tech Combo", Category = "Tech", Price = 400 };
            techCombo.AddProduct(book);
            techCombo.AddProduct(laptop);
            techCombo.AddProduct(monitor);

            book.GetProductDetails();
            book.GetProductPrice();

            techCombo.GetProductDetails();
            techCombo.GetProductPrice();

            Console.Read();
        }
    }
}
