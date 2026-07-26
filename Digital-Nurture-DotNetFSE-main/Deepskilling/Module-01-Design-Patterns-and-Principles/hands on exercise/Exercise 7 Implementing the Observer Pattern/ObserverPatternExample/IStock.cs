namespace ObserverPatternExample;
public interface IStock{
 void Register(IObserver o);
 void Deregister(IObserver o);
 void NotifyObservers();
}