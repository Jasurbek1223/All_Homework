namespace N19___HT2;

internal class Program
{
    static void Main(string[] args)
    {
        var values = new[] { 1, 2, 3, 12, -23, 22, 3, 0, -7, -3, 4 }; //Sum= 14; Average= 1,27; Max= 22; Min= -23
        Console.WriteLine(AggregationService.Sum(values));
        Console.WriteLine(AggregationService.Average(values));
        Console.WriteLine(AggregationService.Max(values));
        Console.WriteLine(AggregationService.Min(values) + "\n");


        var k1 = 6;
        Console.WriteLine($"First: {k1}");
        AggregationService.Increment(ref k1);
        Console.WriteLine($"Increment: {k1}");
        AggregationService.Decrement(ref k1);
        Console.WriteLine($"Decrement: {k1}\n");

        var k2 = int.MaxValue;
        Console.WriteLine($"First: {k2}");
        AggregationService.Increment(ref k2);
        Console.WriteLine($"Increment: {k2}");
        AggregationService.Decrement(ref k2);
        Console.WriteLine($"Decrement: {k2}\n");

        var k3 = int.MinValue;
        Console.WriteLine($"First: {k3}");
        AggregationService.Increment(ref k3);
        Console.WriteLine($"Increment: {k3}");
        AggregationService.Decrement(ref k3);
        Console.WriteLine($"Decrement: {k3}\n");

        var k4 = -10;
        Console.WriteLine($"First: {k4}");
        AggregationService.Increment(ref k4);
        Console.WriteLine($"Increment: {k4}");
        AggregationService.Decrement(ref k4);
        Console.WriteLine($"Decrement: {k4}\n");

    }
}