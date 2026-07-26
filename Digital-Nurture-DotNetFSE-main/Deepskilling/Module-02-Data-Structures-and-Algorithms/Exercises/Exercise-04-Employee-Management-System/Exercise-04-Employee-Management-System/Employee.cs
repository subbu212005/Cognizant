namespace EmployeeManagementSystem;
public class Employee
{
    public int EmployeeId{get;set;}
    public string Name{get;set;}
    public string Position{get;set;}
    public double Salary{get;set;}

    public Employee(int id,string name,string position,double salary)
    {
        EmployeeId=id; Name=name; Position=position; Salary=salary;
    }

    public override string ToString() =>
        $"ID: {EmployeeId}, Name: {Name}, Position: {Position}, Salary: ₹{Salary}";
}
