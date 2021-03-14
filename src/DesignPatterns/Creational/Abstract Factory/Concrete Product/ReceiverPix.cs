using System;

namespace DesignPatterns.Creational.Abstract_Factory
{
    // Concrete Product
    public class ReceiverPix : Receiver
    {
        public ReceiverPix(TransactionType transactionType) : base(transactionType) { }

        public override void Transfer(Transaction transaction)
        {
            Console.WriteLine($"Transfer ${transaction.Ammount} to Pix endpoint.");
        }
    }
}
