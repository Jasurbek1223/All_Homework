using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N41___HT1
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var queue = new ThreadSafeQueue<int>();

            var tasks = new List<Task>()
            {
                new Task(() => queue.Enqueue(1)),
                new Task(() => queue.Enqueue(10)),
                new Task(() => queue.Enqueue(100)),
                new Task(() => queue.Enqueue(11)),
            };

            foreach (var task in tasks)
            {
                task.Start();
            }

            await Task.WhenAll(tasks);

            Console.WriteLine(queue.Dequeue()); //1
            Console.WriteLine(queue.Dequeue()); //10
            Console.WriteLine(queue.Dequeue()); //100
            Console.WriteLine(queue.Dequeue()); //11
            Console.WriteLine(queue.Dequeue()); //0
        }
    }
}
