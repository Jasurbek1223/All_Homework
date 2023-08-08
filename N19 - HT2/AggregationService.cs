namespace N19___HT2;

internal static class AggregationService
{
    public static int Sum(params int[] values)
    {
        int sum = 0;
        foreach (int value in values)
            sum += value;
        return sum;
    }

    public static double Average(params int[] values)
    {
        return (double)Sum(values)/values.Length;
    }

    public static int Max(params int[] values)
    {
        int max = values[0];
        foreach (int value in values)
        {
            if(value > max)
                max = value;
        }
        return max;
    }

    public static int Min(params int[] values)
    {
        int min = values[0];
        foreach (int value in values)
        {
            if (value < min)
                min = value;
        }
        return min;
    }

    public static void Increment(ref int value)
    {
        if (value < int.MaxValue) value++;
    }

    public static void Decrement(ref int value)
    {
        if (value > int.MinValue) value--;
    }

}
