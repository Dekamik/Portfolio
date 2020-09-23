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

                var existingEntities = _set.Where(e => entity.Select(n => n.Id).Contains(e.Id));
                if (existingEntities.Count() != entity.Count())
                {
                    var missingIds = entity.Select(e => e.Id).Where(id => !existingEntities.Select(ee => ee.Id).Contains(id));
                    _logger.LogWarning($"Couldn't find {nameof(TEntity)} with Id {string.Join(",", missingIds)} for update");
                }

                foreach (var e in existingEntities)
                {
                    e.Copy(entity.SingleOrDefault(n => n.Id == e.Id));
                }

                await CheckAutoSave();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }

        public async Task Delete(params int[] id)
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug($"Deleting {nameof(TEntity)} with Id {string.Join(",", id)}");

                var entities = _set.Where(e => id.Contains(e.Id));
                if (entities.Count() != id.Length)
                {
                    var missingIds = id.Where(i => !entities.Select(e => e.Id).Contains(i));
                    _logger.LogWarning($"Couldn't find {nameof(TEntity)} with Id {string.Join(",", missingIds)} for deletion");
                }

                _set.RemoveRange(entities);
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
