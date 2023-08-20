namespace N25_HT1.Model;

public class Monitor : IProduct
{
    // Monitor xususiyatlari
    public double DisplaySize { get; set; }
    public int RefreshRate { get; set; }

    // IProduct interfeysining implementatsiyasi
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }
}
