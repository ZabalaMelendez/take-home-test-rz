using Fundo.Domain.Commons;

namespace Fundo.Domain.Entities;

/// <summary>
/// Defines the  loan information to save.
/// </summary>
public class Loan : BaseEntity
{
    public decimal Amount { get; set; }
    public decimal CurrentBalance { get; set; }
    public int StatusId { get; set; }
    public int RateTypeId { get; set; }
    public int ApplicantId { get; set; }
    public int? GuarantorId { get; set; }
    public DateTimeOffset DueDate { get; set; }
    public DateTimeOffset? PaidAt { get; set; }
}