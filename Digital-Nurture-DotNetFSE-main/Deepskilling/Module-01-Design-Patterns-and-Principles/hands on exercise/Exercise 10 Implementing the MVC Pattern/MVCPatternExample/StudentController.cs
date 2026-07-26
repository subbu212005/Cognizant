namespace MVCPatternExample;
public class StudentController{
 private readonly Student model;
 private readonly StudentView view;
 public StudentController(Student m,StudentView v){model=m;view=v;}
 public void SetStudentName(string n)=>model.Name=n;
 public void SetStudentGrade(string g)=>model.Grade=g;
 public void UpdateView()=>view.DisplayStudentDetails(model);
}