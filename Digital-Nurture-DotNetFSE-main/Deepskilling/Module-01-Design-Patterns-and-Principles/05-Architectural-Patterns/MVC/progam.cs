using System;

class StudentModel
{
    public string Name { get; set; } = "";
}

class StudentView
{
    public void DisplayStudent(string name)
    {
        Console.WriteLine("Displaying Student Information");
        Console.WriteLine("Name: " + name);
    }
}

class StudentController
{
    private StudentModel model;
    private StudentView view;

    public StudentController(StudentModel model, StudentView view)
    {
        this.model=model;
        this.view=view;
    }

    public void UpdateView()
    {
        view.DisplayStudent(model.Name);
    }
}

class Program
{
    static void Main()
    {
        StudentModel model=new StudentModel();
        model.Name="Subrahmanyeswara";

        StudentView view=new StudentView();

        StudentController controller =
            new StudentController(model, view);

        controller.UpdateView();
    }
}
