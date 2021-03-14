using System;

namespace DesignPatterns.Creational.Abstract_Factory
{
    // Abstract Product
    public abstract class Receiver
    {
        protected Receiver(TransactionType transactionType)
        {
            TransactionType = transactionType;
        }

        public string Endpoint { get; set; }
        public TransactionType TransactionType { get; set; }
        public abstract void Transfer(Transaction transaction);
    }

    public static class ReceiverCreator
    {
        public static Receiver Create(TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.Pix:
                    return new ReceiverPix(transactionType);
                case TransactionType.Ted:
                    return new ReceiverTed(transactionType);
                default:
                    throw new ApplicationException("Invalid transaction type.");
            }
        }
    }
}
