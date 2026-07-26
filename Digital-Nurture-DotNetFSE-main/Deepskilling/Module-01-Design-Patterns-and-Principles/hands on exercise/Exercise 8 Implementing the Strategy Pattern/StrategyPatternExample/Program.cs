using StrategyPatternExample;

var context = new PaymentContext(new CreditCardPayment());

context.ExecutePayment(2500);

context.SetStrategy(new PayPalPayment());

context.ExecutePayment(1800);
