namespace DesignPatterns.Creational.FactoryMethod
{
    // Abstract Product
    public abstract class Queue
    {
        protected Queue(string endpoint)
        {
            Endpoint = endpoint;
        }

        protected string Endpoint { get; set; }
        public abstract void SendToQueue();
    }
}
