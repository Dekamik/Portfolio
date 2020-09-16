using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseEntities;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Common.Api.BaseRepositories
{
    public abstract class Repository<TEntity, TDbContext> : ReadOnlyRepository<TEntity, TDbContext>
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
            _logger.LogDebug($"Creating {entity.Length} {nameof(TEntity)}");

            _set.AddRange(entity);
            await CheckAutoSave(entity);
        }

        public async Task Update(params TEntity[] entity)
        {
            _logger.LogDebug($"Updating {nameof(TEntity)} with Id {string.Join(",", entity.Select(e => e.Id))}");

            _set.UpdateRange(entity);
            await CheckAutoSave(entity);
        }

        public async Task Delete(params TEntity[] entity)
        {
            _logger.LogDebug($"Deleting {nameof(TEntity)} with Id {string.Join(",", entity.Select(e => e.Id))}");

            _set.RemoveRange(entity);
            await CheckAutoSave(entity);
        }

        public async Task SaveChanges(TEntity[] entity)
        {
            await _dbContext.SaveChangesAsync();
            _logger.LogDebug($"Changes to {nameof(TEntity)} with Id {string.Join(",", entity.Select(e => e.Id))} persisted");
        }

        private async Task CheckAutoSave(TEntity[] entity)
        {
            if (AutoSave)
            {
                await SaveChanges(entity);
            }
        }
    }
}
