namespace N44___HT2;

public class Program
{
    static void Main(string[] args)
    {
        // List created
        var nums = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
        };

        // Deffered execution - Kechiktirilgan bajarilish
        nums.Where(x => x > 4).Select(x => x + 1);
        nums.FirstOrDefault(x => x%2 == 0);
        nums.ForEach(x => { Console.WriteLine(x); });

        // Immediate execution - Darxol bajarilish
        nums.Where(n => n > 3).ToList();
        nums.Where(n => n%2 == 0).OrderByDescending(x => x).Take(2).ToList();
        nums.Where(n => n%2 == 1).ToArray();

        // Mixed execution - Aralaash bajarilish
        var nums1 = nums.Where(n => n > 3).ToList();
        foreach(var num  in nums1)
        {
            Console.Write(num + " ");
        };
        Console.WriteLine();

        var nums2 = nums.Where(n => n % 2 == 0).OrderByDescending(x => x).Take(2).ToList();
        foreach(var num in nums2)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        var nums3 = nums.Skip(2).Take(2).ToList();
        foreach(var num in nums3)
        {
            Console.Write(num + " ");
        }

        // Mixedda birinchi quryda darxol bajariladi lekin foreach ishlashi uchun oxirgacha bajarib bolishini kutib turadi 
        // shuning uchun aralash bajarilayabdi
    }
}