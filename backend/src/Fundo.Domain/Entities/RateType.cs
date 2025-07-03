using Fundo.Domain.Commons;

namespace Fundo.Domain.Entities;

/// <summary>
/// Defines the type of rate applicable to a loan.
/// </summary>
public class RateType : BaseCatalogEntity
{
    public string Description { get; set; } = string.Empty;
}