using System;

class Node
{
    public int Data;
    public Node Prev;
    public Node Next;

    public Node(int data)
    {
        Data=data;
    }
}

class Program
{
    static void Main()
    {
        Node first=new Node(20);
        Node second=new Node(30);
        Node third=new Node(40);

        first.Next=second;
        second.Prev=first;

        second.Next=third;
        third.Prev=second;

        Console.WriteLine("Doubly Linked List:");

        Node temp=first;

        while (temp!=null)
        {
            Console.Write(temp.Data + " ");
            temp=temp.Next;
        }
    }
}
