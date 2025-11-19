using Microsoft.EntityFrameworkCore;
using MyWebApiWithControllers.DatabaseModel;

namespace MyWebApiWithControllers.Repository;



public class TransactionRepository : ITransactionRepository
{
    private readonly Whiyes5oContext context;


    public TransactionRepository(Whiyes5oContext context)
    {
        this.context = context;
    }

    public List<Transaction> GetAllTransactions()
    {
        return context.Transactions.
        Include(t => t.User).
        Include(t => t.TransactionType)
        .ToList();
    }

    public Transaction? GetTransactionById(int id)
    {
        var result = this.context.Transactions
        .Include(t => t.User)
        .Include(t => t.TransactionType)
        .FirstOrDefault(t => t.Id == id);
        return result;
    }

    public void Add(Transaction transaction)
    {
        context.Transactions.Add(transaction);
    }

    public void DeleteById(int id)
    {
        var transaction = context.Transactions.FirstOrDefault(t => t.Id == id);
        if (transaction != null)
        {
            context.Transactions.Remove(transaction);
        }
    }
}