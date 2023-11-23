using System.Security.Cryptography.X509Certificates;

namespace PatternsPractice._04_FactoryPattern;

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}