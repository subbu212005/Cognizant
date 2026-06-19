using System;

interface IPaymentStrategy
{
    void Pay();
}

class CreditCardPayment : IPaymentStrategy
{
    public void Pay()
    {
        Console.WriteLine("Payment made using Credit Card");
    }
}

class Program
{
    static void Main()
    {
        IPaymentStrategy payment=new CreditCardPayment();
        payment.Pay();
    }
}
