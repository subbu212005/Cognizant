using System;

class Computer
{
    public string Processor { get; set; } = "";
    public string RAM { get; set; } = "";
    public string Storage { get; set; } = "";

    public void ShowDetails()
    {
        Console.WriteLine("Computer Configuration");
        Console.WriteLine("Processor: " + Processor);
        Console.WriteLine("RAM: " + RAM);
        Console.WriteLine("Storage: " + Storage);
    }
}

class ComputerBuilder
{
    private Computer computer=new Computer();

    public ComputerBuilder SetProcessor(string processor)
    {
        computer.Processor=processor;
        return this;
    }

    public ComputerBuilder SetRAM(string ram)
    {
        computer.RAM=ram;
        return this;
    }

    public ComputerBuilder SetStorage(string storage)
    {
        computer.Storage=storage;
        return this;
    }

    public Computer Build()
    {
        return computer;
    }
}

class Program
{
    static void Main()
    {
        Computer computer=new ComputerBuilder()
            .SetProcessor("Intel i7")
            .SetRAM("16GB")
            .SetStorage("512GB SSD")
            .Build();

        computer.ShowDetails();
    }
}
