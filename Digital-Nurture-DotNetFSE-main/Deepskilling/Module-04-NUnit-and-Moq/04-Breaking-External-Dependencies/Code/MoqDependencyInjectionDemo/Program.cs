using MoqDependencyInjectionDemo.Models;
using MoqDependencyInjectionDemo.Services;

var service=new UserService(new EmailService(),new LoggerService());
service.Register(new User{Name="Alice",Email="alice@test.com"});
