using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N41___HT2.Service; 

namespace N41___HT2
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            EmailSenderService emailSenderService = new EmailSenderService();
            var tasks = new List<Task<bool>>
            {
                emailSenderService.SendEmailAsync("jasurabdulxaev@gmail"),
                emailSenderService.SendEmailAsync("JohnDoe3@gmail"),
                emailSenderService.SendEmailAsync("Gishmatbek1212@gmail")
            };

            Parallel.ForEach(tasks, task => task.Start());
            await Task.WhenAll(tasks);
        }
    }
}
