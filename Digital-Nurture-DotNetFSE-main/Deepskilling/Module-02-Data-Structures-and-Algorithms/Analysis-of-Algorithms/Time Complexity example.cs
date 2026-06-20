using System;

class Program
{
    static void Main()
    {
        int n=5;

        Console.WriteLine("Numbers from 1 to " + n);

        for (int i=1;i<=n;i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Time Complexity: O(n)");
    }
}
