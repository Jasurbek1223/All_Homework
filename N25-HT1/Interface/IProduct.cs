namespace N25_HT1.Interface;

public interface IProduct
{
    int Id { get; }
    string Name { get; }
    string Description { get; }
    bool IsOrdered { get; set; }
    double Price { get; }
}