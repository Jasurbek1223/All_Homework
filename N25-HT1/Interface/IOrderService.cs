using N25_HT1.Model;

namespace N25_HT1.Interface;

public interface IOrderService
{
    IProduct Order(int id, DebitCard card);
    List<IProduct> Order(ProductFilterModel filterModel, DebitCard card);
}
