using MyWebApiWithControllers.DatabaseModel;

namespace MyWebApiWithControllers.Services;

public interface ITransactionService
{
    List<TransactionViewModel> GetAllTransactions();
    Transaction GetTransactionById(int id);
}