using TaskManagementSystem;
using Task = TaskManagementSystem.Task;

var list=new TaskLinkedList();
list.Add(new Task(1,"Design UI","Pending"));
list.Add(new Task(2,"Develop API","In Progress"));
list.Add(new Task(3,"Testing","Pending"));

list.Traverse();
list.Search(2);
list.Delete(2);
list.Traverse();
