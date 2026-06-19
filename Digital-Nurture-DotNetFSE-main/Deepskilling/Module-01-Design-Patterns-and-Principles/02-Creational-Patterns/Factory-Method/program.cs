using System;

interface IVehicle
{
    void Create();
}

class Car : IVehicle
{
    public void Create()
    {
        Console.WriteLine("Car Created");
    }
}

class Bike : IVehicle
{
    public void Create()
    {
        Console.WriteLine("Bike Created");
    }
}

class VehicleFactory
{
    public static IVehicle GetVehicle(string type)
    {
        if (type=="Car")
            return new Car();

        return new Bike();
    }
}

class Program
{
    static void Main()
    {
        IVehicle car=VehicleFactory.GetVehicle("Car");
        car.Create();

        IVehicle bike=VehicleFactory.GetVehicle("Bike");
        bike.Create();
    }
}
