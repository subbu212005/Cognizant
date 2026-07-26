using BuilderPatternExample;
var gaming=new Computer.Builder().SetCPU("Intel i9").SetRAM(32).SetStorage(1000).SetGPU("RTX 4080").Build();
var office=new Computer.Builder().SetCPU("Intel i5").SetRAM(16).SetStorage(512).Build();
Console.WriteLine("Gaming PC");
Console.WriteLine(gaming);
Console.WriteLine();
Console.WriteLine("Office PC");
Console.WriteLine(office);
