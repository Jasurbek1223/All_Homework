using N25_HT1.Interface;
using N25_HT1.Model;

namespace N25_HT1.Service;

public class PaymentService : IPaymentService
{
    public bool Checkout(double amount, DebitCard debitCard)
    {
        if (debitCard.Balance >= amount)
        {
            debitCard.Balance -= amount;
            return true;
        }
        return false;
    }
}
