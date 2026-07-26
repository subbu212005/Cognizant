using MVCPatternExample;
var student=new Student("Alice",101,"A");
var view=new StudentView();
var controller=new StudentController(student,view);

Console.WriteLine("Initial Details:");
controller.UpdateView();

controller.SetStudentName("Bob");
controller.SetStudentGrade("A+");

Console.WriteLine();
Console.WriteLine("Updated Details:");
controller.UpdateView();
