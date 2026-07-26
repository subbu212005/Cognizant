namespace MVCPatternExample;
public class StudentView{
 public void DisplayStudentDetails(Student s){
  Console.WriteLine($"Student ID: {s.Id}");
  Console.WriteLine($"Name: {s.Name}");
  Console.WriteLine($"Grade: {s.Grade}");
 }
}