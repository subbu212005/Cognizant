using DecoratorPatternExample;
INotifier notifier=new EmailNotifier();
notifier=new SMSNotifierDecorator(notifier);
notifier=new SlackNotifierDecorator(notifier);
notifier.Send("Server maintenance at 10 PM");
