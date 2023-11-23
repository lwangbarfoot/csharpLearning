namespace PatternsPractice.Factory_Pattern;

public class ConsoleLoggerFactory : ILoggerFactory
{
    public ILogger CreateLogger()
    {
        return new ConsoleLogger();
    }
}