using AdapterPatternExample;
IPaymentProcessor paypal=new PayPalAdapter();
IPaymentProcessor stripe=new StripeAdapter();
paypal.ProcessPayment(1500);
stripe.ProcessPayment(2750);
