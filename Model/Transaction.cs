namespace MyWebApiWithControllers.Model;

public enum TransactionType
{
    Incoming=0,
    Outgoing=1,
    Withdraw=2
}


public class Transaction
{
    public decimal TransactionId { get; set; }

    public required string FullName { get; set; }

    public TransactionType TransactionType { get; set; }

    public required string AccountNumber { get; set; }

    public required string BankCode { get; set; }

    public DateTime IssueDate { get; set; }

    public decimal Amount { get; set; }
}
