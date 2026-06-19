using System;

interface IResource
{
    void Access();
}

class RealResource : IResource
{
    public void Access()
    {
        Console.WriteLine("Accessing Secure Resource");
    }
}

class ResourceProxy : IResource
{
    private RealResource resource=new RealResource();

    public void Access()
    {
        resource.Access();
    }
}

class Program
{
    static void Main()
    {
        IResource resource=new ResourceProxy();
        resource.Access();
    }
}
