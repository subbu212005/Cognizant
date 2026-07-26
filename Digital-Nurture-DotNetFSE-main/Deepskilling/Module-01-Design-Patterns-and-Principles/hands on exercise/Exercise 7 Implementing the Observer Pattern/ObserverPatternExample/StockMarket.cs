using System.Collections.Generic;
namespace ObserverPatternExample;
public class StockMarket:IStock{
 private readonly List<IObserver> observers=new();
 private string stock=""; private double price;
 public void Register(IObserver o)=>observers.Add(o);
 public void Deregister(IObserver o)=>observers.Remove(o);
 public void SetStock(string s,double p){stock=s;price=p;NotifyObservers();}
 public void NotifyObservers(){foreach(var o in observers)o.Update(stock,price);}
}