using MyWebApiWithControllers.DatabaseModel;

public class TransactionViewModel
{
    public decimal TransactionId { get; set; }
    public required string FullName { get; set; }    
    public required string TransactionType { get; set; }
     public required string AccountNumber { get; set; }

    public required string BankCode { get; set; }

    public DateTime IssueDate { get; set; }

    public decimal Amount { get; set; }
}