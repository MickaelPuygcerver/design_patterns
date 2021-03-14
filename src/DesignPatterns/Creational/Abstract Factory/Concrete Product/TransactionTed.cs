namespace DesignPatterns.Creational.Abstract_Factory
{
    // Concrete Product
    public class TransactionTed : Transaction
    {
        public TransactionTed(decimal ammount, TransactionType transactionType) : base(ammount, transactionType) { }
    }
}
