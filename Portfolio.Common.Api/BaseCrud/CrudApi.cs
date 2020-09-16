using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseEntities;
using Portfolio.Common.Api.BaseRepositories;

namespace Portfolio.Common.Api.BaseCrud
{
    public class CrudApi<TEntity, TRepository, TDbContext> : ReadOnlyApi<TEntity, TRepository, TDbContext>, ICrudApi<TEntity>
        where TEntity : BaseEntity
        where TRepository : Repository<TEntity, TDbContext>
        where TDbContext : DbContext
    {
        public CrudApi(TRepository repository, ILogger logger) : base(repository, logger) { }

        [HttpPost]
        public async Task<IActionResult> Create(TEntity entity)
        {
            await _repository.Create(entity);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(TEntity entity)
        {
            await _repository.Update(entity);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            TEntity entity = _repository.Get(id).SingleOrDefault();

            if (entity == default)
            {
                return NotFound();
            }

            await _repository.Delete(entity);
            return Ok();
        }
    }
}
