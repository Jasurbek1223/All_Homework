using N21___HT1.Interface;

namespace N21___HT1.Card;

class KapitalUzcard : IDebitCard
{
    public string CardNumber { get; set; }
    public string BankName { get; init; }
    public double Balance { get; set; }

    public KapitalUzcard(string cardNumber, string bankName, double initialBalance)
    {
        CardNumber = cardNumber;
        BankName = bankName;
        Balance = initialBalance;
    }

}
