using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Core.Entities.Base;
using Portfolio.Core.Repositories.Base;

namespace Portfolio.Web.Api.BaseCrud
{
    public abstract class ReadOnlyRepositoryApi<TEntity, TRepository, TDbContext> : ControllerBase
        where TEntity : BaseEntity
        where TRepository : ReadOnlyRepository<TEntity, TDbContext>
        where TDbContext : DbContext
    {
        internal readonly TRepository _repository;
        internal readonly ILogger _logger;

        public ReadOnlyRepositoryApi(TRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.Get(id));
        }
    }
}
