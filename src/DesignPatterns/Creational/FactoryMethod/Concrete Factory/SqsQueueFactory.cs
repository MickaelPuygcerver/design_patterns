namespace DesignPatterns.Creational.FactoryMethod
{
    // Concrete Creator
    public class SqsQueueFactory : QueueFactory
    {
        public override Queue CreateQueue(string endpoint)
        {
            return SqsQueueCreator.Create(endpoint);
        }
    }
}
