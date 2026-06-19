using System;

interface ICommand
{
    void Execute();
}

class LightOnCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Light Turned ON");
    }
}

class Program
{
    static void Main()
    {
        ICommand command=new LightOnCommand();
        command.Execute();
    }
}
