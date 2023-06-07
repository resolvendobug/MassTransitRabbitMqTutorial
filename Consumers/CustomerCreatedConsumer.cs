
using MassTransit;
using MassTransitTutorial.Domain.Events;
using System;

namespace MassTransitTutorial.Consumers
{

    public class CustomerCreatedConsumer : IConsumer<CustomerCreatedEvent>
    {

        public Task Consume(ConsumeContext<CustomerCreatedEvent> context)
        {
            
            Console.WriteLine($"Customer created: {context.Message.CustomerId} - {context.Message.Name} - {context.Message.BirthDate} - {context.Message.Type} - {context.Message.CreatedAt}");
            return Task.CompletedTask;
            
        }
    }
}