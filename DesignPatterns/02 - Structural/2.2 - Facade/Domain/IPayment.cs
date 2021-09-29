namespace DesignPatterns
{
    public interface IPayment
    {
        Payment MakePayment(Order order, Payment payment);
    }
}
