using System;

class Program
{
    static void Main()
    {
        string[] products={"Mobile","Headphones","Laptop","Keyboard","Mouse" };

        string target="Laptop";

        for (int i=0;i<products.Length; i++)
        {
            if (products[i]==target)
            {
                Console.WriteLine("Product Found: "+target);
                Console.WriteLine("Position: "+i);
                return;
            }
        }

        Console.WriteLine("Product Not Found");
    }
}
