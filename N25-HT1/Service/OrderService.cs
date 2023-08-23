using N25_HT1.Interface;
using N25_HT1.Model;

namespace N25_HT1.Service;

public class OrderServise : IOrderServise // bu implement  qilish deyiladi
{
    private readonly ProductServise _productServise;
    private readonly IPaymentServise _paymentServise; //Composition qilish deyiladi
    public OrderServise(ProductServise productServise, IPaymentServise paymentServise)
    {
        _productServise = productServise;
        _paymentServise = paymentServise;
    }

    public bool Order(Guid id, DebitCard debitCardBalance)
    {
        var product = _productServise.Oreder(id);
        if (product == null)
        {
            _productServise.Return(id);
            return false;
        }
        else
        {
            _paymentServise.CheckOut(product.Price, debitCardBalance);
            return true;
        }
    }

    public bool Order(string orderFilterModel, decimal debitCardBalance)
    {
        throw new NotImplementedException();
    }

    public bool Order(int id, decimal debitCardBalance)
    {
        throw new NotImplementedException();
    }
}