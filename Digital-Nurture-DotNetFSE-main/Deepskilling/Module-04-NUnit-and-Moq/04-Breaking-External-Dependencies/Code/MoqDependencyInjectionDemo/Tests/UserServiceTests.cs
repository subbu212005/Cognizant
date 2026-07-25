using Moq;
using NUnit.Framework;
using MoqDependencyInjectionDemo.Interfaces;
using MoqDependencyInjectionDemo.Models;
using MoqDependencyInjectionDemo.Services;

[TestFixture]
public class UserServiceTests
{
    [Test]
    public void Register_CallsServices()
    {
        var email=new Mock<IEmailService>();
        var logger=new Mock<ILoggerService>();

        var service=new UserService(email.Object,logger.Object);

        service.Register(new User{Name="Alice",Email="alice@test.com"});

        email.Verify(e=>e.SendEmail("alice@test.com","Welcome","Registration Successful"),Times.Once);
        logger.Verify(l=>l.Log(It.IsAny<string>()),Times.Once);
    }
}
