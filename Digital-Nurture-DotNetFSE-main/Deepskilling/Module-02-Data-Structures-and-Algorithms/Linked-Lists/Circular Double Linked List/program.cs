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
        Node first=new Node(50);
        Node second=new Node(60);
        Node third=new Node(70);

        first.Next=second;
        second.Prev=first;

        second.Next=third;
        third.Prev=second;

        third.Next=first;
        first.Prev=third;

        Console.WriteLine("Circular Doubly Linked List:");

        Node temp=first;

        do
        {
            Console.Write(temp.Data + " ");
            temp=temp.Next;
        }
        while (temp!=first);
    }
}
