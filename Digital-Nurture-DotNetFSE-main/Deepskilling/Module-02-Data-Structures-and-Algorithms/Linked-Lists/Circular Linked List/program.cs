using System;

class Node
{
    public int Data;
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
        Node first=new Node(10);
        Node second=new Node(20);
        Node third=new Node(30);

        first.Next=second;
        second.Next=third;
        third.Next=first;

        Console.WriteLine("Circular Linked List:");

        Node temp=first;

        do
        {
            Console.Write(temp.Data + " ");
            temp=temp.Next;
        }
        while (temp!=first);
    }
}
