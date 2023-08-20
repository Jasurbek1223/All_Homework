namespace N26___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        Complex a = new Complex(1, 2);
        Complex b = new Complex(3, 4);

        Complex sum = a + b;
        Complex diff = a - b;

        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {diff}");

    }
}