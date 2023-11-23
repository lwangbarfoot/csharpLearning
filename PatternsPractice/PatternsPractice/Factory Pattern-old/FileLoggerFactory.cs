namespace PatternsPractice.Factory_Pattern;

public class FileLoggerFactory : ILoggerFactory
{
    public ILogger CreateLogger()
    {
        return new FileLogger();
    }
}