using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Common.Api.BaseRepositories
{
    public interface IReadOnlyRepository<TEntity>
    {
        IQueryable<TEntity> Get(params int[] id);

        IQueryable<TEntity> GetAll();
    }
}
