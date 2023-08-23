using N25_HT1.Model;

namespace N25_HT1.Interface;

public interface IProductServise
{
    List<IProduct> Inventory { get; }
    void Add(IProduct product);
    ProductFilterDataModel GetFilterData(ProductFilterDataModel productFilter);

    List<IProduct> Get(ProductFilterDataModel filterModel);

    IProduct Oreder(Guid productId);

}
