using N25_HT1.Interface;
using N25_HT1.Model;

namespace N25_HT1.Service;

public class ProductServise : IProductServise
{
    public List<IProduct> Inventory => throw new NotImplementedException();

    public void Add(IProduct product)
    {
        Inventory.Add(product);
    }

    public List<IProduct> Get(ProductFilterDataModel filterModel)
    {
        var filter = Inventory.Where(item => filterModel.ProducTypes.Contains(item.GetType().Name)).ToList();
        var products = new List<IProduct>(filter);
        return products;
    }

    public ProductFilterDataModel GetFilterData(ProductFilterDataModel productFilter)
    {
        return new ProductFilterDataModel(Inventory);
    }

    public IProduct Oreder(Guid productId)
    {
        var order = Inventory.Find(item => item.Id == productId);
        order.IsOrdered = true;
        return order;
    }
    public IProduct Return(Guid productId)
    {
        var order = Inventory.Find(item => item.Id == productId);
        order.IsOrdered = false;
        return order;
    }
}
