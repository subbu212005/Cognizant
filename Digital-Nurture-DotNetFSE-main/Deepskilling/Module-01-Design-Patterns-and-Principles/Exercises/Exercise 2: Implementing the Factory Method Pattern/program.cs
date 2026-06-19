using System;

interface IEmployee
{
    void GetRole();
}

class Manager : IEmployee
{
    public void GetRole()
    {
        Console.WriteLine("Employee Role: Manager");
    }
}

class Developer : IEmployee
{
    public void GetRole()
    {
        Console.WriteLine("Employee Role: Developer");
    }
}

class EmployeeFactory
{
    public static IEmployee CreateEmployee(string type)
    {
        if (type == "Manager")
            return new Manager();

        return new Developer();
    }
}

class Program
{
    static void Main()
    {
        IEmployee emp1 =
            EmployeeFactory.CreateEmployee("Manager");
        emp1.GetRole();

        IEmployee emp2 =
            EmployeeFactory.CreateEmployee("Developer");
        emp2.GetRole();
    }
}
