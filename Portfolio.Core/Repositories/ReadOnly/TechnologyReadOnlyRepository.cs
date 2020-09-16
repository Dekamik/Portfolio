using Microsoft.Extensions.Logging;
using Portfolio.Core.Entities;
using Portfolio.Core.Repositories.Base;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class TechnologyReadOnlyRepository : ReadOnlyRepository<Technology, PortfolioDbContext>
    {
        public TechnologyReadOnlyRepository(PortfolioDbContext dbContext, ILogger<TechnologyReadOnlyRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
