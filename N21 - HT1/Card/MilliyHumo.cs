using N21___HT1.Interface;
namespace N21___HT1.Card;

class MilliyHumo : IDebitCard
{
    public string CardNumber { get; set; }
    public string BankName { get; init; }
    public double Balance { get; set; }

    public MilliyHumo(string cardNumber, string bankName, double balance)
    {
        CardNumber = cardNumber;
        BankName = bankName;
        Balance = balance;
    }
}