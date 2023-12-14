namespace Singleton

{
    public static class MySingleton
    {
        private static readonly Lazy<string> lazyInstance = new Lazy<string>(() => "Instance" + GetRandomNumber());

        public static string Instance => lazyInstance.Value;

        private static int GetRandomNumber()
        {
            Random random = new();
            return random.Next(0, 1000);
        }
    }

    public class MySingleton2
    {
        private static readonly Lazy<MySingleton2> lazyInstance = new Lazy<MySingleton2>(() => new MySingleton2());

        public static MySingleton2 Instance2 => lazyInstance.Value;

        public object? Instance { get; set; }

        // Private constructor to prevent instantiation from outside the class.
        private MySingleton2() { }
    }
}