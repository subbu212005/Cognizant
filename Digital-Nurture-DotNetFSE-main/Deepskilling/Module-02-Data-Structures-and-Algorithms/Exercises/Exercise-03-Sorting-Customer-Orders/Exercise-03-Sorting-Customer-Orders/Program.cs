using SortingCustomerOrders;
using System;

class Program
{
    static void BubbleSort(Order[] orders)
    {
        for(int i=0;i<orders.Length-1;i++)
            for(int j=0;j<orders.Length-i-1;j++)
                if(orders[j].TotalPrice>orders[j+1].TotalPrice)
                    (orders[j],orders[j+1])=(orders[j+1],orders[j]);
    }

    static void QuickSort(Order[] arr,int low,int high)
    {
        if(low<high)
        {
            int pi=Partition(arr,low,high);
            QuickSort(arr,low,pi-1);
            QuickSort(arr,pi+1,high);
        }
    }

    static int Partition(Order[] arr,int low,int high)
    {
        double pivot=arr[high].TotalPrice;
        int i=low-1;
        for(int j=low;j<high;j++)
        {
            if(arr[j].TotalPrice<pivot)
            {
                i++;
                (arr[i],arr[j])=(arr[j],arr[i]);
            }
        }
        (arr[i+1],arr[high])=(arr[high],arr[i+1]);
        return i+1;
    }

    static void Print(Order[] arr,string title)
    {
        Console.WriteLine(title);
        foreach(var o in arr) Console.WriteLine(o);
        Console.WriteLine();
    }

    static void Main()
    {
        Order[] orders={
            new Order(101,"Alice",2500),
            new Order(102,"Bob",1200),
            new Order(103,"Charlie",4500),
            new Order(104,"David",3000)
        };

        var bubble=(Order[])orders.Clone();
        BubbleSort(bubble);
        Print(bubble,"Bubble Sort:");

        var quick=(Order[])orders.Clone();
        QuickSort(quick,0,quick.Length-1);
        Print(quick,"Quick Sort:");
    }
}
