namespace Fina.Core.Models;
using Fina.Core.Enums;

public class Transaction
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrderReceivedAt { get; set; }
    public EtransactionType Type { get; set; } EtransactionType.withdraw;

    public long CategoryId { get; set; }
    public Category Category { get; set; }
    public string UserId { get; set; } = string.empty;
}
