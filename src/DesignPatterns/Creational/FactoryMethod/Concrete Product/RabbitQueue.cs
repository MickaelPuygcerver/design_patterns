using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    // Concrete Product
    public class RabbitQueue : Queue
    {
        public RabbitQueue(string endpoint) : base(endpoint) { }

        public override void SendToQueue()
        {
            Console.WriteLine("Message successful sent do queue " + this.Endpoint);
        }
    }

    public static class RabbitQueueCreator
    {
        public static RabbitQueue Create(string endpoint)
        {
            Console.WriteLine("Rabbit queue successfull created " + endpoint);
            return new RabbitQueue(endpoint);
        }
    }
}
