using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    public class InventoryManager
    {
        private Dictionary<int, Product> inventory = new Dictionary<int, Product>();

        public void AddProduct(Product product)
        {
            inventory[product.ProductId] = product;
            Console.WriteLine("Product added successfully.");
        }

        public void UpdateProduct(int id, string name, int quantity, double price)
        {
            if (inventory.ContainsKey(id))
            {
                inventory[id].ProductName = name;
                inventory[id].Quantity = quantity;
                inventory[id].Price = price;
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void DeleteProduct(int id)
        {
            if (inventory.Remove(id))
                Console.WriteLine("Product deleted successfully.");
            else
                Console.WriteLine("Product not found.");
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\nCurrent Inventory:");
            foreach (Product product in inventory.Values)
                Console.WriteLine(product);
        }
    }
}
