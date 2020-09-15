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

        public Repository(TDbContext dbContext) : base(dbContext) { }

        public async Task Create(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            await CheckAutoSaveAsync();
        }

        public async Task Update(TEntity entity)
        {
            _dbContext.Update(entity);
            await CheckAutoSaveAsync();
        }

        public async Task Delete(TEntity entity)
        {
            _dbContext.Remove(entity);
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
