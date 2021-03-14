namespace DesignPatterns.Creational.Abstract_Factory
{
    // Concrete Product
    public class TransactionPix : Transaction
    {
        public TransactionPix(decimal ammount, TransactionType transactionType) : base(ammount, transactionType) { }
    }
}
