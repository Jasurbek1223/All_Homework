namespace N23___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 5, 6, 20, 13, 12, 9, 97, 22, 31 };

        Console.WriteLine("Tub sonlarni kamayish tartibida");

        var son = new Prime();

        //var orderDecendingNumbers = from s in numbers.Where(son.IsPrime) orderby s descending select s;

        foreach(var tub  in from s in numbers.Where(son.IsPrime) orderby s descending select s)
        {
            Console.WriteLine(tub);
        }









    }
}