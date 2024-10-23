namespace BugExample;

public class SomeRandomService : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        while (true)
        {
            await Task.Delay(10000, cancellationToken);
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}