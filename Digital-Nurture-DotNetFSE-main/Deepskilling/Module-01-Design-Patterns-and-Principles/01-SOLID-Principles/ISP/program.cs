using System;

interface IPrint
{
    void Print();
}

class Printer : IPrint
{
    public void Print()
    {
        Console.WriteLine("Printing Document...");
    }
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();
        printer.Print();
    }
}
