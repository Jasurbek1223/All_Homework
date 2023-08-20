using N25_HT1.Interface;
using N25_HT1.Model;

namespace N25_HT1.Service;

public class OrderService : IOrderService
{
    private readonly IProductService _productService;
    private readonly IPaymentService _paymentService;

    public OrderService(IProductService productService, IPaymentService paymentService)
    {
        _productService = productService;
        _paymentService = paymentService;
    }

    public IProduct Order(int id, DebitCard card)
    {
        IProduct product = _productService.Inventory.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            bool paymentSuccessful = _paymentService.Checkout(product.Price, card);

            if (paymentSuccessful)
            {
                product.IsOrdered = true;
                return product;
            }
        }

        return null;
    }

    public List<IProduct> Order(ProductFilterModel filterModel, DebitCard card)
    {
        var filteredProducts = _productService.Inventory
            .Where(p => p.Name.Contains(filterModel.Name) && p.GetType().FullName == filterModel.Type)
            .ToList();

        var orderedProducts = new List<IProduct>();

        foreach (var product in filteredProducts)
        {
            bool paymentSuccessful = _paymentService.Checkout(product.Price, card);

            if (paymentSuccessful)
            {
                product.IsOrdered = true;
                orderedProducts.Add(product);
            }
        }

        return orderedProducts;
    }
}