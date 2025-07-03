namespace Fundo.Domain.Commons;

public abstract class BaseCatalogEntity : IBaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int Id { get; set; }
    public bool IsActive { get; set; }
}