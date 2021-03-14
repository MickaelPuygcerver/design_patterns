using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    // Concrete Product
    public class SqsQueue : Queue
    {
        public SqsQueue(string endpoint) : base(endpoint) { }

        public override void SendToQueue()
        {
            Console.WriteLine("Message successful sent do queue " + this.Endpoint);
        }
    }

    public static class SqsQueueCreator
    {
        public static SqsQueue Create(string endpoint)
        {
            Console.WriteLine("Sqs queue successfull created " + endpoint);
            return new SqsQueue(endpoint);
        }
    }
}
