using System;

interface IDataService
{
    void GetData();
}

class StudentDataService : IDataService
{
    public void GetData()
    {
        Console.WriteLine("Student Data Retrieved Successfully");
    }
}

class StudentManager
{
    private readonly IDataService dataService;

    public StudentManager(IDataService dataService)
    {
        this.dataService=dataService;
    }

    public void DisplayData()
    {
        dataService.GetData();
    }
}

class Program
{
    static void Main()
    {
        IDataService service=new StudentDataService();

        StudentManager manager =
            new StudentManager(service);

        manager.DisplayData();
    }
}
