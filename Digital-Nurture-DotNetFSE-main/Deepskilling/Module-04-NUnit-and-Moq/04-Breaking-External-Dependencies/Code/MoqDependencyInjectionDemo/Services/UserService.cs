using MoqDependencyInjectionDemo.Interfaces;
using MoqDependencyInjectionDemo.Models;

namespace MoqDependencyInjectionDemo.Services;

public class UserService
{
    private readonly IEmailService _email;
    private readonly ILoggerService _logger;

    public UserService(IEmailService email,ILoggerService logger)
    {
        _email=email;
        _logger=logger;
    }

    public void Register(User user)
    {
        _logger.Log($"Registering {user.Name}");
        _email.SendEmail(user.Email,"Welcome","Registration Successful");
    }
}
