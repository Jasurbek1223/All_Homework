using N25_HT1.Interface;
using N25_HT1.Model;
using N25_HT1.Service;
using System.Xml.Linq;

namespace N25_HT1;

class Program
{
    static void Main(string[] args)
    {
        IProductService productService = new ProductService();
        IPaymentService paymentService = new PaymentService();
        IOrderService orderService = new OrderService(productService, paymentService);

        // ProductService orqali 10 ta mahsulot qo'shish
        productService.Add(new Laptop { Id = 1, Name = "Laptop 1", Description = "Powerful laptop", Price = 1000, CpuBrand = "Intel", CpuModel = "i7" });
        productService.Add(new Chair { Id = 2, Name = "Chair 1", Description = "Comfortable chair", Price = 150, MaxWeight = 120, Material = "Wood" });
        // ... Qolgan mahsulotlar

        // Mahsulot turlarini ekranga chiqarish
        var filterData = productService.GetFilterData();
        Console.WriteLine("Available Product Types:");
        foreach (var type in filterData.ProductTypes)
        {
            Console.WriteLine(type);
        }

        // Bitta card yaratish va xarid qilishni sinab ko'rish
        DebitCard card = new DebitCard { CardNumber = "1234567890123456", Balance = 2000 };

        // Mahsulot xarid qilish
        IProduct orderedProduct = orderService.Order(1, card);
        if (orderedProduct != null)
        {
            Console.WriteLine($"Ordered Product: {orderedProduct.Name}");
        }
        else
        {
            Console.WriteLine("Failed to order the product.");
        }

        // Mahsulotlarni filter bo'yicha xarid qilish
        ProductFilterModel filterModel = new ProductFilterModel { Name = "Laptop", Type = typeof(Laptop).FullName };
        List<IProduct> orderedProducts = orderService.Order(filterModel, card);
        if (orderedProducts.Count > 0)
        {
            Console.WriteLine("Ordered Products:");
            foreach (var product in orderedProducts)
            {
                Console.WriteLine(product.Name);
            }
        }
        else
        {
            Console.WriteLine("No products were ordered.");
        }
    }
}
