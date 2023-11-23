namespace BackgroundServices.BackgroundService;

public class LifecycleHostedService : IHostedLifecycleService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Start");
        return Task.CompletedTask;
    }

    public Task StartedAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Started");
        return Task.CompletedTask;
    }

    public Task StartingAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Starting");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Stop");
        return Task.CompletedTask;
    }

    public Task StoppedAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Stopped");
        return Task.CompletedTask;
    }

    public Task StoppingAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Stopping");
        return Task.CompletedTask;
    }
}
