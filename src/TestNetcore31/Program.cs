using System;
using Lykke.RabbitMqBroker.Subscriber;
using TestInvoke.PublishExample;
using TestInvoke.SubscribeExample;

namespace TestNetcore31
{
    class Program
    {
        static void Main(string[] args)
        {
            var rabbitMqSettings = new RabbitMqSubscriptionSettings
            {
                QueueName = Environment.GetEnvironmentVariable("RabbitMqQueue"),
                ConnectionString = Environment.GetEnvironmentVariable("RabbitMqConnectionString"),
                ExchangeName = Environment.GetEnvironmentVariable("RabbitMqExchange"),
                DeadLetterExchangeName = Environment.GetEnvironmentVariable("RabbitMqExchange") + ".dead-letter"
            };

            HowToSubscribe.Example(rabbitMqSettings);
            HowToPublish.Example(rabbitMqSettings);

            Console.WriteLine("Working... Press Enter to stop");
            Console.ReadLine();

            Console.WriteLine("Stopping....");
            HowToSubscribe.Stop();
            Console.WriteLine("Stopped");
            Console.ReadLine();
        }
    }
}
