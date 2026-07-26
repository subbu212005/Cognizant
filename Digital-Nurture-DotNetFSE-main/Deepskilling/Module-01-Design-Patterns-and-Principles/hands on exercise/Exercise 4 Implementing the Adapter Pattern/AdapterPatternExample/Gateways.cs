namespace AdapterPatternExample;
public class PayPalGateway{ public void MakePayment(double amount)=>Console.WriteLine($"PayPal payment processed: ₹{amount}");}
public class StripeGateway{ public void Pay(double amount)=>Console.WriteLine($"Stripe payment processed: ₹{amount}");}
