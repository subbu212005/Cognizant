using System;

class Book
{
    public string Title { get; set; } = "";
}

class BookPrinter
{
    public void Print(Book book)
    {
        Console.WriteLine(book.Title);
    }
}

class Program
{
    static void Main()
    {
        Book b = new Book();
        b.Title = "C# Programming is very helpful for learning design principles.";

        BookPrinter printer = new BookPrinter();
        printer.Print(b);
    }
}
