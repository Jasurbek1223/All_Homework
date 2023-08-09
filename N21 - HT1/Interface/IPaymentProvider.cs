namespace N21___HT1.Interface;

public interface IPaymentProvider
{   
    double TransferInterest { get; init; }
    void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount);


}
