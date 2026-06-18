using System;

class Bird
{
    public virtual void Move()
    {
        Console.WriteLine("Bird moves");
    }
}

class Sparrow : Bird
{
    public override void Move()
    {
        Console.WriteLine("Sparrow flies");
    }
}

class Program
{
    static void Main()
    {
        Bird bird = new Sparrow();
        bird.Move();
    }
}
