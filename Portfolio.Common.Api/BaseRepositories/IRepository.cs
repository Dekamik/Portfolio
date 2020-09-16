using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Common.Api.BaseRepositories
{
    interface IRepository<TEntity>
    {
        Task Create(params TEntity[] entity);

        Task Update(params TEntity[] entity);

        Task Delete(params TEntity[] entity);

        Task SaveChanges(TEntity[] entity);
    }
}
