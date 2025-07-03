namespace Fundo.Domain.Commons;
public interface IBaseEntity
{
    int Id { get; set; }
    bool IsActive { get; set; }
}

public interface IAuditableEntity : IBaseEntity
{
    DateTimeOffset CreatedAt { get; set; }
    DateTimeOffset? UpdatedAt { get; set; }
    int CreatedBy { get; set; }
    int? UpdatedBy { get; set; }
    bool IsDeleted { get; set; }
    DateTimeOffset? DeletedAt { get; set; }
    int? DeletedBy { get; set; }
    string? DeletedReason { get; set; }
 
}