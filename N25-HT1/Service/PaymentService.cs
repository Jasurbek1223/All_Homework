using N25_HT1.Interface;
using N25_HT1.Model;

namespace N25_HT1.Service;

internal class PaymentServise : IPaymentServise
{
    public bool CheckOut(decimal amount, DebitCard debitCard)
    {
        if (debitCard.Balance >= amount)
        {
            debitCard.Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}