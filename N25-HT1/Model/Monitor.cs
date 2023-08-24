using N25_HT1.Interface;

namespace N25_HT1.Model;

public class Monitor : IProduct
{
    public int DisplaySize { get; set; }

    public int Refreshrate { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }
    decimal IProduct.Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
