using System;

class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
        Console.WriteLine("Singleton Instance Created");
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}

class Program
{
    static void Main()
    {
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        Console.WriteLine(Object.ReferenceEquals(s1, s2));
    }
}
