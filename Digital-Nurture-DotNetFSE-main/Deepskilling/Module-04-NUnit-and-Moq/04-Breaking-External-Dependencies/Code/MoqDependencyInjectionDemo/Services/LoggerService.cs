using MoqDependencyInjectionDemo.Interfaces;
namespace MoqDependencyInjectionDemo.Services;
public class LoggerService:ILoggerService
{
    public void Log(string message)
    {
        Console.WriteLine($"LOG: {message}");
    }
}
