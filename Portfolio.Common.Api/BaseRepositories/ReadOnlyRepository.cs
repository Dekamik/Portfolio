﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseEntities;
using System;
using System.Linq;

namespace Portfolio.Common.Api.BaseRepositories
{
    public abstract class ReadOnlyRepository<TEntity, TDbContext> 
        where TEntity : BaseEntity
        where TDbContext : DbContext
    {
        internal readonly TDbContext _dbContext;

        internal readonly ILogger _logger;

        private IQueryable<TEntity> _set => _dbContext.Set<TEntity>().AsNoTracking();

        public ReadOnlyRepository(TDbContext dbContext, ILogger logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public IQueryable<TEntity> GetAll()
        {
            _logger.LogDebug($"Getting all {nameof(TEntity)}");
            return _set;
        }

        public IQueryable<TEntity> Get(params int[] id)
        {
            _logger.LogDebug($"Getting {nameof(TEntity)} with Id {string.Join(",", id)}");
            return GetAll().Where(e => id.Contains(e.Id));
        }
    }
}