using MassTransit;
using MassTransitTutorial.Domain.Events;

namespace MassTransitTutorial.Consumers
{
    public class AddToMailListConsumer : IConsumer<CustomerCreatedEvent>
    {
        public Task Consume(ConsumeContext<CustomerCreatedEvent> context)
        {
            Console.WriteLine($"Adding customer {context.Message.Name} to mail list..");
            return Task.CompletedTask;
        }
    }
}