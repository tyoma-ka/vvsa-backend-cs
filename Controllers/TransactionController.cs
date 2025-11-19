using Microsoft.AspNetCore.Mvc;
using MyWebApiWithControllers.Services;
using MyWebApiWithControllers.Repository;
using MyWebApiWithControllers.DatabaseModel;
namespace MyWebApiWithControllers.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _transactionService;

    public TransactionController(ITransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    [HttpGet(Name = "GetAllTransactions")]
    public List<TransactionViewModel> GetAllTransactions()
    {
        return _transactionService.GetAllTransactions();
    }

    [HttpGet("{id}", Name = "GetTransactionById")]
    public ActionResult<TransactionViewModel> GetTransactionById(int id)
    {
        var result = _transactionService.GetTransactionById(id);
        if (result == null)
        {
            return NotFound();
        }
        return result;
    }
}
