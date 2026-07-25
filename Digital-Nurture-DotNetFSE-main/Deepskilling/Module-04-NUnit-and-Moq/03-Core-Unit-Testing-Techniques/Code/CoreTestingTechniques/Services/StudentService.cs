using CoreTestingTechniques.Models;
namespace CoreTestingTechniques.Services;
public class StudentService
{
    private readonly List<Student> _students=new();
    public string GetGreeting(string name)=>$"Hello {name}";
    public void AddStudent(Student s)=>_students.Add(s);
    public List<Student> GetStudents()=>_students;
    public Student? FindById(int id)=>_students.FirstOrDefault(x=>x.Id==id);
    public void Validate(Student s){ if(string.IsNullOrWhiteSpace(s.Name)) throw new ArgumentException("Name required");}
    private int Count()=>_students.Count;
}
