using System;
namespace EmployeeManagementSystem;
public class EmployeeManager
{
    private Employee?[] employees;
    private int count=0;
    public EmployeeManager(int size){ employees=new Employee[size]; }

    public void Add(Employee e){
        if(count<employees.Length){ employees[count++]=e; Console.WriteLine("Employee added.");}
        else Console.WriteLine("Array is full.");
    }

    public void Search(int id){
        for(int i=0;i<count;i++)
            if(employees[i]!.EmployeeId==id){ Console.WriteLine("Found: "+employees[i]); return; }
        Console.WriteLine("Employee not found.");
    }

    public void Traverse(){
        Console.WriteLine("\nEmployees:");
        for(int i=0;i<count;i++) Console.WriteLine(employees[i]);
    }

    public void Delete(int id){
        for(int i=0;i<count;i++)
            if(employees[i]!.EmployeeId==id){
                for(int j=i;j<count-1;j++) employees[j]=employees[j+1];
                employees[count-1]=null; count--;
                Console.WriteLine("Employee deleted.");
                return;
            }
        Console.WriteLine("Employee not found.");
    }
}
