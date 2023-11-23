namespace PatternsPractice.Factory_Pattern;

public class FileLogger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Logging to file: {message}");
    }
}