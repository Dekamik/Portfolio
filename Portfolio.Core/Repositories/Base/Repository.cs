using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities.Base;
using System.Threading.Tasks;

namespace Portfolio.Core.Repositories.Base
{
    public abstract class Repository<TEntity, TDbContext> : ReadOnlyRepository<TEntity, TDbContext>
        where TEntity : BaseEntity
        where TDbContext : DbContext
    {
        public bool AutoSave { get; set; }

        private DbSet<TEntity> _set => _dbContext.Set<TEntity>();

        public Repository(TDbContext dbContext) : base(dbContext) { }

        public async Task Create(params TEntity[] entity)
        {
            _set.AddRange(entity);
            await CheckAutoSaveAsync();
        }

        public async Task Update(params TEntity[] entity)
        {
            _set.UpdateRange(entity);
            await CheckAutoSaveAsync();
        }

        public async Task Delete(params TEntity[] entity)
        {
            _set.RemoveRange(entity);
            await CheckAutoSaveAsync();
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }

        private async Task CheckAutoSaveAsync()
        {
            if (AutoSave)
            {
                await SaveChanges();
            }
        }
    }
}
