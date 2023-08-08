namespace N20___T1;

public class BubbleSort
{
    public void Sort(ref int[] arr)
    {
        for(int i=0; i < arr.Length; i++)
        {
            for(int j=0; j<arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    public void Area(int a, int b, out int P, out int S)
    {
        P = 2 * (a + b);
        S = a * b;
    }

    public void FindMaxMin(out int max, out int min, params int[] arr)
    {
        Sort(ref arr);
        max = arr[arr.Length - 1];
        min = arr[0];
    }

}

public class Person
{
    public string Name { get; set; }
    public byte Age { get; set; }
    public bool IsMarried { get; set; }

    public Person(string name, byte age, bool isMarried = false)
    {
        Name = name;
        Age = age;
        IsMarried = isMarried;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, IsMarried: {IsMarried}");
    }
}