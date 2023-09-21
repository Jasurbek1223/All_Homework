namespace N43___T22
{
    internal class Program
    {
        static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            while (true)
            {
                mutex.WaitOne();

                string emailTemplate;
                using (StreamReader reader = new StreamReader(@"D:\.NET_new\fayll\test.txt.txt"))
                {
                    emailTemplate = reader.ReadToEnd();
                }

                string massage = emailTemplate.Replace("{{UserName}}", "Jasurbek");
                Console.WriteLine("Massage :" + massage);

                mutex.ReleaseMutex();

                Thread.Sleep(10_000);
            }
        }
    }
}
