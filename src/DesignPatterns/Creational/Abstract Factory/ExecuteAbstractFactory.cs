using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Abstract_Factory
{
    public class ExecuteAbstractFactory
    {
        public static void Execute()
        {
            var pixTransaction = TransactionCreator.Create(5.50m, TransactionType.Pix);
            var tedTransaction = TransactionCreator.Create(2.20m, TransactionType.Ted);

            Transfer.CreateTransfer(pixTransaction).DoTransfer();
            Transfer.CreateTransfer(tedTransaction).DoTransfer();
        }
    }
}
