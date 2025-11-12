using MyWebApiWithControllers.DatabaseModel;

namespace MyWebApiWithControllers.Services;

public interface ITransactionService
{
    List<TransactionViewModel> GetAllTransactions();
    TransactionViewModel GetTransactionById(int id);
}