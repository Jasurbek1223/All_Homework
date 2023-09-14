namespace N36___HT2.Models;

public struct Circle
{
    public float Radius { get; set; }
    public Point Point { get; set; }

    public Circle(float radius, Point point)
    {
        Radius = radius;
        Point = point;

    }
}
