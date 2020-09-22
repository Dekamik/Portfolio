using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Common.Api.BaseRepositories
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity>
    {
        Task Create(params TEntity[] entity);

        Task Update(params TEntity[] entity);

        Task Delete(params TEntity[] entity);

        Task SaveChanges();
    }
}
