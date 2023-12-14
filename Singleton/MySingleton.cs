namespace Singleton;

public static class MySingleton
{
    public static string? Instance { get; set; } = "Instance" + GetRandomNumber();

    //static helper method generating random number from 0 to 1000
    public static int GetRandomNumber()
    {
        Random random = new();
        return random.Next(0, 1000);
    }
}


public class MySingleton2
{
    public object? Instance { get; set; }
    public static object? Instance2 { get; set; }
}