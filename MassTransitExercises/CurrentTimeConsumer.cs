using MassTransit;

namespace MassTransitExercises;

public class CurrentTimeConsumer(ILogger<CurrentTimeConsumer> logger) : IConsumer<CurrentTime>
{
    public Task Consume(ConsumeContext<CurrentTime> context)
    {
        logger.LogInformation("{Consumer}: {Message}", nameof(CurrentTimeConsumer), context.Message.Value);
        return Task.CompletedTask;
    }
}
