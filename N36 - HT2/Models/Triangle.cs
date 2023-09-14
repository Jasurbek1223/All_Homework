namespace N36___HT2.Models;

public struct Triangle
{
    public float A { get; set; }
    public float B { get; set; }
    public float C { get; set; }

    public Triangle(float a, float b, float c)
    {
        this.A = a;
        this.B = b;
        this.C = c;
    }
}
