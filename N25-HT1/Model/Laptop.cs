namespace N25_HT1.Model;

public class Laptop : IProduct
{
    // Laptop xususiyatlari
    public string CpuBrand { get; set; }
    public string CpuModel { get; set; }

    // IProduct interfeysining implementatsiyasi
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsOrdered { get; set; }
    public double Price { get; set; }
}
