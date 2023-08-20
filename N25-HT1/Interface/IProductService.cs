using N25_HT1.Model;

namespace N25_HT1.Interface;

public interface IProductService
{
    ICollection<IProduct> Inventory { get; }
    void Add(IProduct product);
    ProductFilterDataModel GetFilterData();
}
