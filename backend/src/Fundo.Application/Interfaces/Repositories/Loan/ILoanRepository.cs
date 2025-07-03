namespace Fundo.Application.Interfaces.Repositories.Loan;

public interface ILoanRepository : IBaseRepository<Domain.Entities.Loan>
{
    Task<IEnumerable<Domain.Entities.Loan>> GetActiveLoans();
    Task<IEnumerable<Domain.Entities.Loan>> GetPendingLoans();
}