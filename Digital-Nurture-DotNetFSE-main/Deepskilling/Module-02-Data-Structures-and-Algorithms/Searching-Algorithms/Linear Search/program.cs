using System;

class Program
{
    static void Main()
    {
        int[] arr={10,20,30,40,50};
        int key=30;

        for (int i=0;i<arr.Length;i++)
        {
            if (arr[i]==key)
            {
                Console.WriteLine("Element Found at Index: " + i);
                return;
            }
        }

        Console.WriteLine("Element Not Found");
    }
}
