using System;

interface IKeyboard
{
    void Type();
}

class Keyboard : IKeyboard
{
    public void Type()
    {
        Console.WriteLine("Typing...");
    }
}

class Computer
{
    private readonly IKeyboard keyboard;

    public Computer(IKeyboard keyboard)
    {
        this.keyboard = keyboard;
    }

    public void Start()
    {
        Console.WriteLine("Computer Created Successfully");
    }
}

class Program
{
    static void Main()
    {
        IKeyboard keyboard = new Keyboard();
        Computer computer = new Computer(keyboard);

        computer.Start();
    }
}
