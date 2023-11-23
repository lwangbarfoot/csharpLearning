namespace PatternsPractice.Factory_Pattern;

public class ConsoleLogger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Logging to console: {message}");
    }
}