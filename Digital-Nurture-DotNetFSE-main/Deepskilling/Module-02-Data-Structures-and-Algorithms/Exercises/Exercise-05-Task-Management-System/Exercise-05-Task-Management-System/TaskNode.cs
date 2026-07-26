namespace TaskManagementSystem;
public class TaskNode
{
    public Task Data;
    public TaskNode? Next;
    public TaskNode(Task task){ Data=task; }
}
