using System;

interface IObserver
{
    void Update(string message);
}

class Subscriber : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine("Subscriber received notification: " + message);
    }
}

class Program
{
    static void Main()
    {
        IObserver observer = new Subscriber();
        observer.Update("New Video Uploaded!");
    }
}
