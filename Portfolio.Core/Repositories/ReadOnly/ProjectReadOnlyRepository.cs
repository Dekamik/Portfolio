using Microsoft.Extensions.Logging;
using Portfolio.Core.Entities;
using Portfolio.Core.Repositories.Base;

namespace Portfolio.Core.Repositories.ReadOnly
{
    public class ProjectReadOnlyRepository : ReadOnlyRepository<Project, PortfolioDbContext>
    {
        public ProjectReadOnlyRepository(PortfolioDbContext dbContext, ILogger<ProjectReadOnlyRepository> logger) : base(dbContext, logger)
        {
        }
    }
}
