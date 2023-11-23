namespace PatternsPractice.StrategyPattern;

public class PaymentContext
{
    private IPaymentStrategy paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStragety(IPaymentStrategy stragety)
    {
        this.paymentStrategy = stragety;
    }

    public void ProcessPayment(double amount)
    {
        paymentStrategy.ProcessPayment(amount);
    }
}