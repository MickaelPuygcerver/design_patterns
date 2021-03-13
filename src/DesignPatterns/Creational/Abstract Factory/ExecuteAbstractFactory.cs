using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Abstract_Factory
{
    public class ExecuteAbstractFactory
    {
        public static void Execute()
        {
            var transactions = new List<Transaction>()
            {
                TransactionCreator.Create(5.50m, TransactionType.Pix),
                TransactionCreator.Create(2.20m, TransactionType.Ted)
            };

            transactions.ForEach(transfer => Transfer.CreateTransfer(transfer).DoTransfer());
        }
    }
}
