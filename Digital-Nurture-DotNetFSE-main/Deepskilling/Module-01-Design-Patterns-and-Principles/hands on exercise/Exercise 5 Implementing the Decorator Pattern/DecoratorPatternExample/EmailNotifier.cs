namespace DecoratorPatternExample;
public class EmailNotifier:INotifier{
 public void Send(string message)=>Console.WriteLine($"Email: {message}");
}