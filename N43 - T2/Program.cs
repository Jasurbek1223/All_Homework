namespace N43___T2
{
    internal class Program
    {
        static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            mutex.WaitOne();
            using (StreamWriter writer = new StreamWriter(@"D:\.NET_new\fayll\test.txt.txt"))
            {
                writer.WriteLine("Hello {{UserName}}. Welcome our platform");
            }

            mutex.ReleaseMutex();

            Thread.Sleep(10_000);
        }
    }
}