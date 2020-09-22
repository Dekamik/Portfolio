using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseEntities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Common.Api.BaseRepositories
{
    public abstract class Repository<TEntity, TDbContext> : ReadOnlyRepository<TEntity, TDbContext>, IRepository<TEntity>
        where TEntity : BaseEntity
        where TDbContext : DbContext
    {
        public bool AutoSave { get; set; }

        private DbSet<TEntity> _set => _dbContext.Set<TEntity>();

        public Repository(TDbContext dbContext, ILogger logger) : base(dbContext, logger) 
        {
        }

        public async Task Create(params TEntity[] entity)
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug($"Creating {entity.Length} {nameof(TEntity)}");

                _set.AddRange(entity);
                await CheckAutoSave();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }

        public async Task Update(params TEntity[] entity)
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug($"Updating {nameof(TEntity)} with Id {string.Join(",", entity.Select(e => e.Id))}");

                _set.UpdateRange(entity);
                await CheckAutoSave();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }

        public async Task Delete(params TEntity[] entity)
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug($"Deleting {nameof(TEntity)} with Id {string.Join(",", entity.Select(e => e.Id))}");

                _set.RemoveRange(entity);
                await CheckAutoSave();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }

        public async Task SaveChanges()
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Trace))
                    _logger.LogDebug($"Persisting changes asynchronously");

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }

        private async Task CheckAutoSave()
        {
            try
            {
                if (AutoSave)
                {
                    if (_logger.IsEnabled(LogLevel.Trace))
                        _logger.LogDebug("Autosaving");

                    await SaveChanges();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }
    }
}
