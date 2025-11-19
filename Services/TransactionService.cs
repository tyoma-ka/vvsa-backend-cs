using MyWebApiWithControllers.DatabaseModel;
using MyWebApiWithControllers.Repository;

namespace MyWebApiWithControllers.Services;

public class TransactionService : ITransactionService {
    private readonly ITransactionRepository _transactionRepository;

    public TransactionService(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }

    public List<TransactionViewModel> GetAllTransactions()
    {
        var TransactionViewModels = new List<TransactionViewModel>();
        var transactions = _transactionRepository.GetAllTransactions();
        foreach (var transaction in transactions)
        {
            var transactionViewModel = new TransactionViewModel
            {
                TransactionId = transaction.Id,
                Amount = transaction.Amount,
                IssueDate = transaction.IssueDate,
                FullName = transaction.User.Name,
                TransactionType = transaction.TransactionType.Name,
                AccountNumber = transaction.AccountNumber,
                BankCode = transaction.BankCode
            };
            TransactionViewModels.Add(transactionViewModel);
        }
        return TransactionViewModels;
    }
    
    public TransactionViewModel? GetTransactionById(int id)
    {
        var transaction = _transactionRepository.GetTransactionById(id);
        if (transaction == null)
        {
            return null;
        }

        var transactionViewModel = new TransactionViewModel
            {
                TransactionId = transaction.Id,
                Amount = transaction.Amount,
                IssueDate = transaction.IssueDate,
                FullName = transaction.User.Name,
                TransactionType = transaction.TransactionType.Name,
                AccountNumber = transaction.AccountNumber,
                BankCode = transaction.BankCode
            };
            return transactionViewModel;
    }
}