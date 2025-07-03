using Fundo.Domain.Commons;

namespace Fundo.Domain.Entities;

public class Applicant : BaseEntity
{
    public string SocialSecurityNumber { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
}