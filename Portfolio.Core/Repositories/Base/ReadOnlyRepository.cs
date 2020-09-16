using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities.Base;
using System;
using System.Linq;

namespace Portfolio.Core.Repositories.Base
{
    public abstract class ReadOnlyRepository<TEntity, TDbContext> 
        where TEntity : BaseEntity
        where TDbContext : DbContext
    {
        internal readonly TDbContext _dbContext;

        public ReadOnlyRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll() => _dbContext.Set<TEntity>().AsNoTracking();

        public IQueryable<TEntity> Get(params int[] id)
        {
            return GetAll().Where(e => id.Contains(e.Id));
        }
    }
}
