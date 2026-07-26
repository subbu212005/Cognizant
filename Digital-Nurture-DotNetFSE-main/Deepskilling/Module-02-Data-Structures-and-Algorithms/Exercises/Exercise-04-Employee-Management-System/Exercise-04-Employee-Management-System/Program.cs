using EmployeeManagementSystem;
EmployeeManager manager=new EmployeeManager(5);
manager.Add(new Employee(101,"Alice","Manager",60000));
manager.Add(new Employee(102,"Bob","Developer",50000));
manager.Add(new Employee(103,"Charlie","Tester",45000));
manager.Traverse();
manager.Search(102);
manager.Delete(102);
manager.Traverse();
