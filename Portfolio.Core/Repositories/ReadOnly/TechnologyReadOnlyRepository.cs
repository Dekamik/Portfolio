using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseRepositories;
using Portfolio.Core.Entities;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class TechnologyReadOnlyRepository : ReadOnlyRepository<Technology, PortfolioDbContext>
    {
        public TechnologyReadOnlyRepository(PortfolioDbContext dbContext, ILogger<TechnologyReadOnlyRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
