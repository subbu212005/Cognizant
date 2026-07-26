namespace ObserverPatternExample;
public class MobileApp:IObserver{
 public void Update(string stock,double price)=>Console.WriteLine($"Mobile App: {stock} price updated to ₹{price}");
}
public class WebApp:IObserver{
 public void Update(string stock,double price)=>Console.WriteLine($"Web App: {stock} price updated to ₹{price}");
}