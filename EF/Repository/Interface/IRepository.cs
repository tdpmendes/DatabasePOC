using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace DatabasePOC.EF.Repository.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : EntityBase
    {
        Task AddAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(int Id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int Id);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChangesAsync();
        Task<int> DeleteManyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);
    }
}
