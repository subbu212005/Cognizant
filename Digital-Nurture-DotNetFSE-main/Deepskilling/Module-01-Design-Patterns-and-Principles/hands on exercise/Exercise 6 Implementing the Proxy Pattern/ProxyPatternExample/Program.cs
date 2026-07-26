using ProxyPatternExample;
IImage image=new ProxyImage("sample.jpg");
Console.WriteLine("First call:");
image.Display();
Console.WriteLine();
Console.WriteLine("Second call:");
image.Display();
