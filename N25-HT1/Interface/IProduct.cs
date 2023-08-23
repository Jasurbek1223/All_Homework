namespace N25_HT1.Interface;

public interface IProduct
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public decimal Price { get; set; }
}