namespace DesignPatterns.Creational.FactoryMethod
{
    public static class ExecuteFactoryMethod
    {
        public static void Execute()
        {
            QueueFactory.QueueFactoryCreator(Enum.QueueType.Sqs).CreateQueue("arn:sqs.payments").SendToQueue();
            QueueFactory.QueueFactoryCreator(Enum.QueueType.Rabbit).CreateQueue("rabbit:payments").SendToQueue();
        }
    }
}
