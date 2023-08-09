using N21___HT1.Interface;
using N21___HT1.Model;

namespace N21___HT1.Provider;

public class OnlineMarket
{
    private readonly IPaymentProvider _provider;
    private List<Product> _products;

    public OnlineMarket(IPaymentProvider provider)
    {
        _products = new List<Product>();
        _provider = provider;
    }


    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Buy(string name, IDebitCard card, IDebitCard myCard)
    {
        Product product = _products.Find(x => x.Name == name);
        if (product != null)
        {
            double totalPrice = product.Price;
            _provider.Transfer(myCard, card, totalPrice);
            Console.WriteLine($"Siz {product.Name} ni {totalPrice}$ narxda sotib oldingiz.");
        }
        else
        {
            Console.WriteLine($"{name} nomli product topilmadi.");
        }
    }



}
