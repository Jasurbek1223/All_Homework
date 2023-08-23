using N25_HT1.Interface;

namespace N25_HT1.Model;

public class ProductFilterDataModel
{
    public IEnumerable<string> ProducTypes { get; }

    public ProductFilterDataModel(IEnumerable<IProduct> products)
    {

        ProducTypes = (IEnumerable<string>?)products.Select(product => product.GetType()).Distinct().ToList();
    }
}