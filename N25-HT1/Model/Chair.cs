using N25_HT1.Interface;

namespace N25_HT1.Model;

public class Chair : IProduct
{
    public int maxWeight { get; set; }

    public string material { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }
}
