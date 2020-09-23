using System;
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
        where TRepository : IRepository<TEntity>
        where TDbContext : DbContext
    {
        public CrudApi(TRepository repository, ILogger logger) : base(repository, logger) { }

        [HttpPost]
        public async Task<IActionResult> Create(TEntity entity)
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug($"{nameof(Create)} endpoint for {nameof(TRepository)} ({nameof(TEntity)}) called.");

                await _repository.Create(entity);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(TEntity entity)
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug($"{nameof(Update)} endpoint for {nameof(TRepository)} ({nameof(TEntity)}) called.");

                await _repository.Update(entity);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug($"{nameof(Delete)} endpoint for {nameof(TRepository)} ({nameof(TEntity)}) called.");

                await _repository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }
    }
}
