using System;

namespace DesignPatterns.Creational.Abstract_Factory
{
    // Concrete Product
    public class ReceiverTed : Receiver
    {
        public ReceiverTed(TransactionType transactionType) : base(transactionType) { }

        public override void Transfer(Transaction transaction)
        {
            Console.WriteLine($"Transfer ${transaction.Ammount} to Ted endpoint.");
        }
    }
}
