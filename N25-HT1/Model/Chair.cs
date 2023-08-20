namespace N25_HT1.Model;

public class Chair : IProduct
{
    // Chair xususiyatlari
    public int MaxWeight { get; set; }
    public string Material { get; set; }

    // IProduct interfeysining implementatsiyasi
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }
}
