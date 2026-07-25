using MoqDependencyInjectionDemo.Interfaces;
namespace MoqDependencyInjectionDemo.Services;
public class EmailService:IEmailService
{
    public void SendEmail(string to,string subject,string body)
    {
        Console.WriteLine($"Email sent to {to}");
    }
}
