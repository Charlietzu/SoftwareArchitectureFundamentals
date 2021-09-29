namespace DesignPatterns
{
    public interface ICreditCardPaymentFacade
    {
        bool MakePayment(Order order, Payment payment);
    }
}
