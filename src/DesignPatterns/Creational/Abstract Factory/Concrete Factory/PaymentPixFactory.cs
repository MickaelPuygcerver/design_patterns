namespace DesignPatterns.Creational.Abstract_Factory
{
    // Concrete Factory
    public class PaymentPixFactory : PaymentFactory
    {
        public override Receiver CreateReceiver()
        {
            return ReceiverCreator.Create(TransactionType.Pix);
        }

        public override Transaction CreateTransaction(decimal ammount, TransactionType transactionType)
        {
            return TransactionCreator.Create(ammount, transactionType);
        }
    }
}
