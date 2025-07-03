using Ardalis.SmartEnum;

namespace Fundo.Domain.Enums;

public class LoanStatusEnum : SmartEnum<LoanStatusEnum, int>
{
    public LoanStatusEnum(string name, int value) : base(name, value)
    {
    }
    
    public static readonly LoanStatusEnum Active = new LoanStatusEnum("Active", 1);
    public static readonly LoanStatusEnum Pending = new LoanStatusEnum("Pending", 2);
    public static readonly LoanStatusEnum Closed = new LoanStatusEnum("Closed", 3);
    public static readonly LoanStatusEnum InDefault = new LoanStatusEnum("In Default", 4);
    
}