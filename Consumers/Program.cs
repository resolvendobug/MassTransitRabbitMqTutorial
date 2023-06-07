
using System;
using MassTransit;

namespace MassTransitTutorial.Consumers 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>{
                
                cfg.ReceiveEndpoint("greet-new-customers", e => {
                    e.Consumer<CustomerCreatedConsumer>();
                    e.PrefetchCount = 10;
                });

                cfg.ReceiveEndpoint("add-to-maillist", e => {
                    e.Consumer<AddToMailListConsumer>();
                    e.PrefetchCount = 10;
                });

            });
            busControl.Start();

            Console.WriteLine("Listening for Customer Created events.. Press enter to exit");

            while(true);
        }
    }
}