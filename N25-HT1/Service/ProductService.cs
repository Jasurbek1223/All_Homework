using N25_HT1.Interface;
using N25_HT1.Model;

namespace N25_HT1.Service;

public class ProductService : IProductService
{
    public ICollection<IProduct> Inventory { get; private set; }

    public ProductService()
    {
        Inventory = new List<IProduct>();
    }

    public void Add(IProduct product)
    {
        Inventory.Add(product);
    }

    public ProductFilterDataModel GetFilterData()
    {
        var productTypes = Inventory.Select(item => item.GetType().FullName).Distinct();
        var filterData = new ProductFilterDataModel { ProductTypes = productTypes };
        return filterData;
    }
}