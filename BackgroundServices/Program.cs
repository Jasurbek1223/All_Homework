using BackgroundServices.BackgroundService;

namespace BackgroundServices;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder();
        {
            builder.Services.AddHostedService<BackgroundService>();
            builder.Services.AddHostedService<LifecycleHostedService>();
        }
        IHost host = builder.Build();

        host.Run();
    }
}