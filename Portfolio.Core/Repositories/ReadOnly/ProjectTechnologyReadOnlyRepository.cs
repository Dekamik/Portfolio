using Microsoft.Extensions.Logging;
using Portfolio.Core.Entities;
using Portfolio.Core.Repositories.Base;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class ProjectTechnologyReadOnlyRepository : ReadOnlyRepository<ProjectTechnology, PortfolioDbContext>
    {
        public ProjectTechnologyReadOnlyRepository(PortfolioDbContext dbContext, ILogger<ProjectTechnologyReadOnlyRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
