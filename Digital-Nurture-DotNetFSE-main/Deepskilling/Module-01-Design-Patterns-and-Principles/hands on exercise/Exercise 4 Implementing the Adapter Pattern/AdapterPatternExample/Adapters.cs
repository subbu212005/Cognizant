namespace AdapterPatternExample;
public class PayPalAdapter:IPaymentProcessor{
 private readonly PayPalGateway g=new();
 public void ProcessPayment(double amount)=>g.MakePayment(amount);
}
public class StripeAdapter:IPaymentProcessor{
 private readonly StripeGateway g=new();
 public void ProcessPayment(double amount)=>g.Pay(amount);
}
