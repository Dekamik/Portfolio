using System.Threading.Tasks;

namespace Portfolio.Common.Api.BaseRepositories
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity>
    {
        Task Create(params TEntity[] entity);

        Task Update(params TEntity[] entity);

        Task Delete(params int[] id);

        Task SaveChanges();
    }
}
