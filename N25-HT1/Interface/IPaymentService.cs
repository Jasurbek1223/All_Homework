using N25_HT1.Model;

namespace N25_HT1.Interface;

public interface IPaymentService
{
    bool CheckOut(decimal amount, DebitCard debitCard);
}
