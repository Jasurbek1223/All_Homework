namespace N23___HT1;

public class Prime
{
    public bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        int limit = (int)Math.Sqrt(n);

        for (int i = 2; i <= limit; i++)
        {
            if (n % i == 0) return false;
        }
        return true;

    }


}
