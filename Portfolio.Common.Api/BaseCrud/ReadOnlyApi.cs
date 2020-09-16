using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseEntities;
using Portfolio.Common.Api.BaseRepositories;

namespace Portfolio.Common.Api.BaseCrud
{
    public abstract class ReadOnlyApi<TEntity, TRepository, TDbContext> : ControllerBase, IReadOnlyApi
        where TEntity : BaseEntity
        where TRepository : ReadOnlyRepository<TEntity, TDbContext>
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
            return Ok(_repository.GetAll());
        }

        [HttpGet, Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.Get(id));
        }
    }
}
