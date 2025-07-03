using System.Linq.Expressions;
using Fundo.Domain.Commons;

namespace Fundo.Application.Interfaces.Repositories;

public interface IBaseRepository <TEntity> where TEntity : BaseEntity, IBaseEntity
{
    Task<TEntity> Add(TEntity entity);
    Task<IEnumerable<TEntity>> Add(IEnumerable<TEntity> entity);
    Task<TEntity> Update(TEntity entity);
    Task<TEntity> Update(int id, TEntity entity);
    Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> GetById(int id);
    Task<IEnumerable<TEntity>> GetAll();
    Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate);
    Task<bool> Any(Expression<Func<TEntity, bool>> predicate);
    Task<int> Count(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> Delete(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> Delete(int id);

}