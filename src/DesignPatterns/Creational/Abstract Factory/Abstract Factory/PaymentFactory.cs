namespace DesignPatterns.Creational.Abstract_Factory
{
    // Abstract Factory
    public abstract class PaymentFactory
    {
        public abstract Receiver CreateReceiver();
        public abstract Transaction CreateTransaction(decimal ammount, TransactionType transactionType);
    }
}
