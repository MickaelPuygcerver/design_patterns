using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Abstract_Factory
{
    public class Transfer
    {
        private readonly Transaction _transaction;
        private readonly Receiver _receiver;

        public Transfer(PaymentFactory paymentFactory, Transaction transaction)
        {
            _transaction = paymentFactory.CreateTransaction(transaction.Ammount, transaction.TransactionType);
            _receiver = paymentFactory.CreateReceiver();
        }

        public void DoTransfer()
        {
            _receiver.Transfer(_transaction);
        }

        public static Transfer CreateTransfer(Transaction transaction)
        {
            switch (transaction.TransactionType)
            {
                case TransactionType.Pix:
                    return new Transfer(new PaymentPixFactory(), transaction);
                case TransactionType.Ted:
                    return new Transfer(new PaymentTedFactory(), transaction);
                default:
                    throw new ApplicationException("Invalid transaction type.");
            }
        }
    }
}
