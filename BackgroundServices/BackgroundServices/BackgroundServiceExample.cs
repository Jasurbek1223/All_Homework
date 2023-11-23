namespace BackgroundServices.BackgroundServices;
public class BackgroundServiceExample : BackgroundService
{ 
    protected override Task ExecuteAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Event Execute Async");
        return Task.CompletedTask;
    }
}
