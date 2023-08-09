using N21___HT1.Interface;

namespace N21___HT1.Card;

public class MyCard : IDebitCard
{
    public string CardNumber { get; set; }
    public string BankName { get; init; }
    public double Balance { get; set; }

    public MyCard(string cardNumber, string bankName, double balance)
    {
        CardNumber = cardNumber;
        BankName = bankName;
        Balance = balance;
    }
}
