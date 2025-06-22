using System;

public sealed class Logger
{
    private static readonly Logger instance = new Logger();

    // Private constructor prevents instantiation from other classes
    private Logger() { }

    public static Logger Instance
    {
        get { return instance; }
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

public class SingletonTest
{
    public static void Main(string[] args)
    {
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;

        if (object.ReferenceEquals(logger1, logger2))
        {
            Console.WriteLine("Logger is a singleton. Both variables hold the same instance.");
        }
        else
        {
            Console.WriteLine("Logger is not a singleton. Different instances exist.");
        }

        logger1.Log("This is the first log message.");
        logger2.Log("This is the second log message.");
    }
}
