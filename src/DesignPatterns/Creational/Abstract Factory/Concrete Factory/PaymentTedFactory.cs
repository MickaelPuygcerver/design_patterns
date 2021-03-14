namespace DesignPatterns.Creational.Abstract_Factory
{
    // Concrete Factory
    public class PaymentTedFactory : PaymentFactory
    {
        public override Receiver CreateReceiver()
        {
            return ReceiverCreator.Create(TransactionType.Ted);
        }

        public override Transaction CreateTransaction(decimal ammount, TransactionType transactionType)
        {
            return TransactionCreator.Create(ammount, TransactionType.Ted);
        }
    }
}
