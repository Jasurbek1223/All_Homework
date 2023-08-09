using N21___HT1.Interface;

namespace N21___HT1.Provider;

public class PaymePaymentProvider : IPaymentProvider
{
    public double TransferInterest { get; init; }
    public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
    {
        double transferAmount = amount * (1 + TransferInterest / 100);
        if (sourceCard.Balance >= transferAmount && amount > 0 && sourceCard.Balance > 0)
        {
            sourceCard.Balance -= transferAmount;
            destinationCard.Balance += amount;
            Console.WriteLine($"{sourceCard.BankName} kartasidan {destinationCard.BankName} nomerli kartaga {amount}$ pul o'tkazildi.");
        }
        else
        {
            Console.WriteLine("Hisobda yetarli mablag' mavjud emas.");
        }

    }
}