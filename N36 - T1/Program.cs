namespace N36___T1;

public class Program
{
    static void Main(string[] args)
    {
        int[] hours = new int[] { 0, 1, 2, 3, 4 };
        int target = 2;

        var son = hours.Where(hour => hour>=target).Count();
        Console.WriteLine(son);
    }
}