using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseEntities;
using Portfolio.Common.Api.BaseRepositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Common.Api.BaseCrud
{
    public abstract class ReadOnlyApi<TEntity, TRepository, TDbContext> : ControllerBase, IReadOnlyApi
        where TEntity : BaseEntity
        where TRepository : IReadOnlyRepository<TEntity>
        where TDbContext : DbContext
    {
        internal readonly TRepository _repository;
        internal readonly ILogger _logger;

        public ReadOnlyApi(TRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug($"{nameof(GetAll)} endpoint for {nameof(TRepository)} ({nameof(TEntity)}) called.");

                IQueryable<TEntity> entities = _repository.GetAll();

                return Ok(entities);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug($"{nameof(Get)} endpoint for {nameof(TRepository)} ({nameof(TEntity)}) called.");

                TEntity entity = await _repository.Get(id).SingleOrDefaultAsync();

                return Ok(entity);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                throw;
            }
        }
    }
}
