namespace N44___HT1;

public static class Cancellation
{
    public static async ValueTask Execute(CancellationToken cancellationToken)
    {
        for (var index = 0; index < 100; index++)   
            cancellationToken.ThrowIfCancellationRequested();
    }
}
