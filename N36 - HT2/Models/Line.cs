namespace N36___HT2.Models;

public struct Line
{
    public Point Start {  get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }
}
