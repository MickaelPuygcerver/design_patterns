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

    public static class TransactionCreator
    {
        public static Transaction Create(decimal ammount, TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.Pix:
                    return new TransactionPix(ammount, transactionType);
                case TransactionType.Ted:
                    return new TransactionTed(ammount, transactionType);
                default:
                    throw new ApplicationException("Invalid transaction type.");
            }
        }
    }
}
