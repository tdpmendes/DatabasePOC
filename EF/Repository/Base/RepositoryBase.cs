using DatabasePOC.EF.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace DatabasePOC
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : EntityBase, new()
    {
        protected readonly DatabasePOCContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public RepositoryBase(DatabasePOCContext db)
        {
            Db = db ?? throw new ArgumentNullException(nameof(db));
            DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(
                Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking()
                              .Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int Id)
        {
            return await DbSet.FindAsync(Id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            DbSet.AddOrUpdate(entity);
            await SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int Id)
        {
            DbSet.Remove(new TEntity { Id = Id });
            await SaveChangesAsync();

        }

        public async Task<int> SaveChangesAsync()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            //Db?.Dispose();
        }

        public async Task<int> DeleteManyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            var entities = DbSet.Where(predicate).ToList();
            return await SaveChangesAsync();
        }

    }
}
