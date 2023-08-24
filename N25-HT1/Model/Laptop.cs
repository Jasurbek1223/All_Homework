using N25_HT1.Interface;

namespace N25_HT1.Model;

public class Laptop : IProduct
{
    public string cpuBoard { get; set; }

    public string cpuBrend { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }
    decimal IProduct.Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
