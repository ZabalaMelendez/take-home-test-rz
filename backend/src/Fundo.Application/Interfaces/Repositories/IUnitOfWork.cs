using Fundo.Application.Interfaces.Repositories.Applicants;
using Fundo.Application.Interfaces.Repositories.Loan;

namespace Fundo.Application.Interfaces.Repositories;

public interface IUnitOfWork
{
    IApplicantRepository ApplicantRepository { get; }
    ILoanRepository LoanRepository { get; }
    
    Task<int> SaveChangesAsync();   
    Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess);
}