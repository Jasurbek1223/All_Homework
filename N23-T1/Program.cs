namespace N23_T1;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>
        { 322, -1, 11, 3, 6, 10 };


        // All- Musbat
        var mus = numbers.All(x => x > 0);
        Console.WriteLine($"Hammasi musbatmi: {mus}");

        // Ichida toq sonlar bormi
        var toq = numbers.Any(x => x % 2 == 1);
        Console.WriteLine($"Bitta bo'lsa ham toq son bormi: {toq}");

        // 3 va 9 bormi ichida
        var uchVaToqqizBormi = numbers.Contains(3) && numbers.Contains(9);
        Console.WriteLine($"Sonlar orasida 3 va 9 bormi : {uchVaToqqizBormi}");



    }
}