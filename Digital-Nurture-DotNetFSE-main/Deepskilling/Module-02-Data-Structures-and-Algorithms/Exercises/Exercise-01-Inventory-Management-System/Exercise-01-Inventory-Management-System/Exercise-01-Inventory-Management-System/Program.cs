using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();

            manager.AddProduct(new Product(101, "Laptop", 10, 65000));
            manager.AddProduct(new Product(102, "Mouse", 50, 500));
            manager.AddProduct(new Product(103, "Keyboard", 25, 1200));

            manager.DisplayProducts();

            Console.WriteLine();

            manager.UpdateProduct(102, "Wireless Mouse", 45, 700);
            manager.DisplayProducts();

            Console.WriteLine();

            manager.DeleteProduct(101);
            manager.DisplayProducts();

            if (!Console.IsInputRedirected)
            {
                Console.ReadKey();
            }
        }
    }
}
