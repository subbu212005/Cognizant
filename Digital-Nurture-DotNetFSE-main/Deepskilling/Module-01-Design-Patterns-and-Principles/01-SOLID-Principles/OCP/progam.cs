using System;

class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.Radius = 5;

        Console.WriteLine("Area of Circle: " + circle.Area());
    }
}
