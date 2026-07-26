using System;
namespace TaskManagementSystem;
public class TaskLinkedList
{
    private TaskNode? head;

    public void Add(Task task)
    {
        var node=new TaskNode(task);
        if(head==null){ head=node; return; }
        var temp=head;
        while(temp.Next!=null) temp=temp.Next;
        temp.Next=node;
    }

    public void Traverse()
    {
        Console.WriteLine("\nTasks:");
        var temp=head;
        while(temp!=null){ Console.WriteLine(temp.Data); temp=temp.Next; }
    }

    public void Search(int id)
    {
        var temp=head;
        while(temp!=null)
        {
            if(temp.Data.TaskId==id){ Console.WriteLine("Found: "+temp.Data); return; }
            temp=temp.Next;
        }
        Console.WriteLine("Task not found.");
    }

    public void Delete(int id)
    {
        if(head==null) return;
        if(head.Data.TaskId==id){ head=head.Next; Console.WriteLine("Task deleted."); return; }
        var temp=head;
        while(temp.Next!=null && temp.Next.Data.TaskId!=id) temp=temp.Next;
        if(temp.Next!=null){ temp.Next=temp.Next.Next; Console.WriteLine("Task deleted."); }
        else Console.WriteLine("Task not found.");
    }
}
