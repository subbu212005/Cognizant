using System;
using RetailInventory.Data;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("Retail Inventory Database Context Configured Successfully.");

            Console.WriteLine();

            Console.WriteLine("Database Ready for Migrations.");
        }
    }
}
