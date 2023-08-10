using N21___HT1.Card;
using N21___HT1.Interface;
using N21___HT1.Model;
using N21___HT1.Provider;

namespace N21___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        // Karta qo'shish jarayoni, payme va Uzumni Bankdagi hisob- raqamlari
        IDebitCard kapitalCard = new KapitalUzcard(cardNumber: "1234 5678 9012 3456", bankName: "Kapital Bank", initialBalance: 25_000);
        IDebitCard milliyCard = new MilliyHumo("6666 1111 2222 0000", "Milliy Bank", 2_000);

        // Xaridorni kartasi yani meniki
        IDebitCard myCard = new MyCard("8600 0609 9054 6468", "Xalq Banki", 100_000);
        Console.WriteLine("Mening kartamdagi dastlabki summa: " + myCard.Balance + "\n");

        // Payme va Uzum uchun % stavkalarini belgilash
        IPaymentProvider paymeProvider = new PaymePaymentProvider { TransferInterest = 1 }; // 1%
        IPaymentProvider uzumProvider = new UzumPaymentProvider { TransferInterest = 5 };   // 5%


        OnlineMarket marketWithPayme = new OnlineMarket(paymeProvider);
        OnlineMarket marketWithUzum = new OnlineMarket(uzumProvider);

        // Product yaratish
        Product laptop = new Product { Name = "Laptop", Price = 20000 };
        Product phone = new Product { Name = "Iphone15", Price = 10000 };

        // Online Marketga product qo'shish jarayoni
        marketWithPayme.Add(laptop);
        marketWithUzum.Add(phone);

        // Online marketdan sotib olish jarayoni
        marketWithPayme.Buy("Laptop", kapitalCard, myCard);
        marketWithUzum.Buy("Iphone15", milliyCard, myCard);

        //Console.WriteLine($"Kapital kartadagi balans: {kapitalCard.Balance}");
        //Console.WriteLine($"Milliy kartadagi balans: {milliyCard.Balance} ");
        Console.WriteLine($"Xalq Banki kartasida qolgan balans: {myCard.Balance} ");



    }
}