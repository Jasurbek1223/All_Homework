using System;
using System.Threading;
using System.Threading.Tasks;

namespace N44___HT1;

public class Program
{
    static async Task Main(string[] args)
    {
        var cancellationTokenSource = new CancellationTokenSource(5000);

        try
        {
            await Cancellation.Execute(cancellationTokenSource.Token);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception bo'ldi: " + ex.Message);
        }
    }
}