namespace N22___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        CustomList<int> numbers = new CustomList<int>();

        //Add
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(9);
        numbers.Add(10);
        numbers.Add(7);
       


        //AddRange
        int[] newNumbers = {20, 30};
        numbers.AddRange(newNumbers);

        //Contains
        bool contains7 = numbers.Contains(7); // True
        bool contains8 = numbers.Contains(8); //False

        Console.WriteLine($"Contains 7: {contains7}");
        Console.WriteLine($"Contains 8: {contains8}");

        //Copy to
        int[] copiedArray = new int[10];
        numbers.CopyTo(copiedArray);

        Console.WriteLine("Copied Array:");
        foreach (int num in copiedArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine() ;


        //Index of
        int indexOff100 = numbers.IndexOf(100);
        int indexOff1 = numbers.IndexOf(1);

        Console.WriteLine($"Index of 100: {indexOff100}");
        Console.WriteLine($"Index of 1: {indexOff1}");

        //Insert
        numbers.Insert(index: 1, item: 777);

        // Insert range
        int[] insertRangeNumbers = { 400, 401 };
        numbers.InsertRange(4, insertRangeNumbers);

        //Remove
        bool removed = numbers.Remove(9); //true

        //RemoveAt
        bool removeAt = numbers.RemoveAt(5);  //true

        Console.WriteLine("Updated list:");
        foreach(int num in numbers.ToArray())
            Console.Write($"{num} ");
        
        Console.WriteLine();

        Console.WriteLine($"Removed 9: {removed}");
        Console.WriteLine($"Removed at index 5: {removeAt}");



    }
}