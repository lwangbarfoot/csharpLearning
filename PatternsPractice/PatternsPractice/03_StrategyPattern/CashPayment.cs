namespace PatternsPractice.StrategyPattern;

public class CashPayment : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Payment {amount} via Cash");
    }

}