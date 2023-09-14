using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await PrintNumbersAsync();
    }

    static async Task PrintNumbersAsync()
    {
        await foreach (var number in GetNumbersAsync())
        {
            Console.WriteLine(number);
        }
    }

    static async IAsyncEnumerable<int> GetNumbersAsync()
    {
        for (int i = 1; i <= 5; i++)
        {
            await Task.Delay(1000); // Asinxron amal
            yield return i;
        }
    }
}
