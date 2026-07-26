namespace DecoratorPatternExample;
public abstract class NotifierDecorator:INotifier{
 protected INotifier notifier;
 protected NotifierDecorator(INotifier n){notifier=n;}
 public virtual void Send(string message)=>notifier.Send(message);
}
public class SMSNotifierDecorator:NotifierDecorator{
 public SMSNotifierDecorator(INotifier n):base(n){}
 public override void Send(string message){base.Send(message);Console.WriteLine($"SMS: {message}");}
}
public class SlackNotifierDecorator:NotifierDecorator{
 public SlackNotifierDecorator(INotifier n):base(n){}
 public override void Send(string message){base.Send(message);Console.WriteLine($"Slack: {message}");}
}