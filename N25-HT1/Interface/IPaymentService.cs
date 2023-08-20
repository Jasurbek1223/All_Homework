using N25_HT1.Model;

namespace N25_HT1.Interface;

public interface IPaymentService
{
    bool Checkout(double amount, DebitCard debitCard);
}