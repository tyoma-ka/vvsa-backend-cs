using MyWebApiWithControllers.DatabaseModel;

namespace MyWebApiWithControllers.Repository;



public class TransactionRepository : ITransactionRepository
{
    private readonly Whiyes5oContext whiyes5OContext;

    private List<Transaction> transactions;

    public TransactionRepository(Whiyes5oContext whiyes5OContext)
    {
        this.whiyes5OContext = whiyes5OContext;
    }

    public List<Transaction> GetAllTransactions()
    {
        return transactions;
    }

    public Transaction GetTransactionById(int id)
    {
        return transactions.FirstOrDefault(t => t.Id == id);
    }

    public void Add(Transaction transaction)
    {
        transactions.Add(transaction);
    }

    public void DeleteById(int id)
    {
        var transaction = transactions.FirstOrDefault(t => t.Id == id);
        if (transaction != null)
        {
            transactions.Remove(transaction);
        }
    }
}