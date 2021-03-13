using System;

namespace DesignPatterns.Creational.Abstract_Factory
{
    // Abstract Product
    public abstract class Transaction
    {
        protected Transaction(decimal ammount, TransactionType transactionType)
        {
            TransactionType = transactionType;
            Ammount = ammount;
        }

        public TransactionType TransactionType { get; set; }
        public decimal Ammount { get; set; }
    }

    // Concrete Product
    public class TransactionPix : Transaction
    {
        public TransactionPix(decimal ammount, TransactionType transactionType) : base(ammount, transactionType) { }
    }

    // Concrete Product
    public class TransactionTed : Transaction
    {
        public TransactionTed(decimal ammount, TransactionType transactionType) : base(ammount, transactionType) { }
    }

    public static class TransactionCreator
    {
        public static Transaction Create(decimal ammount, TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.Pix:
                    return new TransactionPix(ammount, transactionType);
                case TransactionType.Ted:
                    return new TransactionPix(ammount, transactionType);
                default:
                    throw new ApplicationException("Invalid transaction type.");
            }
        }
    }
}
