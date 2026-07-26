namespace TaskManagementSystem;
public class Task
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string Status { get; set; }

    public Task(int id,string name,string status)
    {
        TaskId=id; TaskName=name; Status=status;
    }

    public override string ToString() =>
        $"ID: {TaskId}, Task: {TaskName}, Status: {Status}";
}
