using Microsoft.Extensions.Logging;
using Portfolio.Common.Api.BaseRepositories;
using Portfolio.Core.Entities;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class ProjectTechnologyReadOnlyRepository : ReadOnlyRepository<ProjectTechnology, PortfolioDbContext>
    {
        public ProjectTechnologyReadOnlyRepository(PortfolioDbContext dbContext, ILogger<ProjectTechnologyReadOnlyRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
