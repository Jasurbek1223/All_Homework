namespace BackgroundServices.BackgroundService;

public class BackgroundService : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Start");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Stop");
        return Task.CompletedTask;
    }
}
