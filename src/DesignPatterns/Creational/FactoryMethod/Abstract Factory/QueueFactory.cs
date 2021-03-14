using DesignPatterns.Creational.FactoryMethod.Enum;
using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    // Abstract Creator
    public abstract class QueueFactory
    {
        public static QueueFactory QueueFactoryCreator(QueueType queueType)
        {
            switch(queueType)
            {
                case QueueType.Rabbit:
                    return new RabbitQueueFactory();
                case QueueType.Sqs:
                    return new SqsQueueFactory();
                default:
                    throw new ApplicationException("Invalid queue type.");
            }
        }

        // Factory Method
        public abstract Queue CreateQueue(string endpoint);
    }
}
