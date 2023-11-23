namespace PatternsPractice.StrategyPattern;

public class CreditCardPayment : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Paying {amount} via Credit Card.");
    }
}