using System;

class Program
{
    static void Main()
    {
        int[] arr={20,30,40,50,60 };
        int key=50;

        int left=0;
        int right=arr.Length-1;

        while (left<=right)
        {
            int mid=(left+right)/2;

            if (arr[mid]==key)
            {
                Console.WriteLine("Element Found at Index: " + mid);
                return;
            }

            if (key<arr[mid])
                right=mid-1;
            else
                left=mid+1;
        }

        Console.WriteLine("Element Not Found");
    }
}
