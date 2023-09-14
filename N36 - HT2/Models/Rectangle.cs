namespace N36___HT2.Models;

public struct Rectangle
{
    public decimal Width { get; set; }
    public decimal Height { get; set; }

    public Rectangle(decimal width, decimal height)
    {
        Width = width;
        Height = height;
    }
}

