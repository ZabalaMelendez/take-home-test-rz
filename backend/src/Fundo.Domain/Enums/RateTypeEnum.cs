using Ardalis.SmartEnum;

namespace Fundo.Domain.Enums;

public class RateTypeEnum : SmartEnum<RateTypeEnum, int>
{
    public RateTypeEnum(string name, int value) : base(name, value)
    {
    }
    
    public static readonly RateTypeEnum Fixed = new RateTypeEnum("Fixed", 1);
    public static readonly RateTypeEnum Variable = new RateTypeEnum("Variable", 2);
    public static readonly RateTypeEnum Adjustable = new RateTypeEnum("Adjustable", 3);
    public static readonly RateTypeEnum Simple = new RateTypeEnum("Simple", 4);
}