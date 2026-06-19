using System;

interface ICoffee
{
    string GetDescription();
}

class BasicCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Basic Coffee";
    }
}

class MilkDecorator : ICoffee
{
    private ICoffee coffee;

    public MilkDecorator(ICoffee coffee)
    {
        this.coffee=coffee;
    }

    public string GetDescription()
    {
        return coffee.GetDescription()+" with Milk";
    }
}

class Program
{
    static void Main()
    {
        ICoffee coffee=new BasicCoffee();
        Console.WriteLine(coffee.GetDescription());

        coffee=new MilkDecorator(coffee);
        Console.WriteLine(coffee.GetDescription());
    }
}
