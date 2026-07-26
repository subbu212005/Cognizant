using SingletonPatternExample;

Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

logger1.Log("Application Started");
logger2.Log("Processing Request");

Console.WriteLine();
Console.WriteLine($"Same Instance: {ReferenceEquals(logger1, logger2)}");
