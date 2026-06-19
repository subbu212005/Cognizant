using System;

class DatabaseConnection
{
    private static DatabaseConnection instance;

    private DatabaseConnection()
    {
        Console.WriteLine("Database Connection Created");
    }

    public static DatabaseConnection GetInstance()
    {
        if (instance == null)
        {
            instance = new DatabaseConnection();
        }

        return instance;
    }

    public void Connect()
    {
        Console.WriteLine("Connected to Database");
    }
}

class Program
{
    static void Main()
    {
        DatabaseConnection db1 = DatabaseConnection.GetInstance();
        db1.Connect();

        DatabaseConnection db2 = DatabaseConnection.GetInstance();

        Console.WriteLine("Same Instance: " +
            Object.ReferenceEquals(db1, db2));
    }
}
