using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseEntities;
using System;
using System.Linq;

namespace Portfolio.Common.Api.BaseRepositories
{
    public abstract class ReadOnlyRepository<TEntity, TDbContext> : IReadOnlyRepository<TEntity>
        where TEntity : BaseEntity
        where TDbContext : DbContext
    {
        internal readonly TDbContext _dbContext;

        internal readonly ILogger _logger;

        private IQueryable<TEntity> _set => _dbContext.Set<TEntity>().AsNoTracking();

        public ReadOnlyRepository(TDbContext dbContext, ILogger logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            try
            {
                _logger.LogDebug($"Getting all {nameof(TEntity)}");
                return _set;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }

        public virtual IQueryable<TEntity> Get(params int[] id)
        {
            try
            {
                _logger.LogDebug($"Getting {nameof(TEntity)} with Id {string.Join(",", id)}");
                return GetAll().Where(e => id.Contains(e.Id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }
    }
}
