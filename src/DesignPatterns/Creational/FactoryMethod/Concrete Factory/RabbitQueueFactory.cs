namespace DesignPatterns.Creational.FactoryMethod
{
    // Concrete Creator
    public class RabbitQueueFactory : QueueFactory
    {
        public override Queue CreateQueue(string endpoint)
        {
            return RabbitQueueCreator.Create(endpoint);
        }
    }
}
