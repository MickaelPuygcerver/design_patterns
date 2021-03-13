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

    // Concrete Product
    public class TransferPix : Receiver
    {
        public TransferPix(TransactionType transactionType) : base(transactionType) { }

        public override void Transfer(Transaction transaction)
        {
            Console.WriteLine($"Transfer ${transaction.Ammount} to Pix endpoint.");
        }
    }

    // Concrete Product
    public class TransferTed : Receiver
    {
        public TransferTed(TransactionType transactionType) : base(transactionType) { }

        public override void Transfer(Transaction transaction)
        {
            Console.WriteLine($"Transfer ${transaction.Ammount} to Ted endpoint.");
        }
    }

    public static class ReceiverCreator
    {
        public static Receiver Create(TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.Pix:
                    return new TransferPix(transactionType);
                case TransactionType.Ted:
                    return new TransferTed(transactionType);
                default:
                    throw new ApplicationException("Invalid transaction type.");
            }
        }
    }
}
