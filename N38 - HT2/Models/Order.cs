namespace N38___HT2.Models;

public class Order
{
    public int OrderId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public DateTime OrderDate { get; set; }
}